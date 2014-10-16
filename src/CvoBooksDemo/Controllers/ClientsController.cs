using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CvoBooksDemo.Domain;
using CvoBooksDemo.Dto;

namespace CvoBooksDemo.Controllers
{
    public class ClientsController : ApiController
    {

        // GET api/clients
        public HttpResponseMessage Get()
        {
            try
            {

                var clients = new List<Client>()
                        {
                            new Client(){Id=1, Name="tim is een held", Address = "123456"}
                        };

                return Request.CreateResponse(HttpStatusCode.OK, new GetClientsRequestMessage { Clients = clients });


            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // GET api/clients/5
        public HttpResponseMessage Get([FromUri]int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK,
                                              new SaveClientMessage { Client = new Client() { Name = "tim", Id = id } });


            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // POST api/clients
        public HttpResponseMessage Post(SaveClientMessage client)
        {
            try
            {
                //create new client
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // PUT api/clients/5
        public HttpResponseMessage Put(int id, SaveClientMessage client)
        {
            try
            {
                //update client
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // DELETE api/clients/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                //delete client
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
