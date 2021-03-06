﻿using Domain;
using InvoiceAPI.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InvoiceAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DetailController : ApiController
    {
        private DetailService service = new DetailService();

        public List<Detail_Response_v1>Get()
        {
            var reponse = (from c in service.Get()
                          select
                          new Detail_Response_v1
                          {
                              DetailID = c.DetailID,
                              Quantity = c.Quantity,
                              Price = c.Price,
                              Product = c.Product,
                              Invoice = c.Invoice
                          }).ToList();
            return reponse;
        }
        public Detail_Response_v1 Get(int id)
        {
            Detail detail=service.GetById(id);
            Detail_Response_v1 response = new Detail_Response_v1();
            response.DetailID = detail.DetailID;
            response.Quantity = detail.Quantity;
            response.Price = detail.Price;
            response.Product = detail.Product;
            response.Invoice = detail.Invoice;

            return response; 
        }
        public void Post([FromBody] Detail_Response_v1 request)
        {
            Detail detail = new Detail();
            detail.Quantity = request.Quantity;
            detail.Price = request.Price;
            
            service.Insert(detail);
        }

        [HttpPost]
        public void Update([FromBody] Detail request)
        {
            service.Update(request, request.DetailID);
        }
        [HttpPost]
        public void Delete([FromBody] Detail request)
        {
            service.Delete(request.DetailID);
        }


    }
}
