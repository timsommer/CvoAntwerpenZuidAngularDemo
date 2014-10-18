using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CvoBooksDemo.Domain;
using CvoBooksDemo.Domain.Repositories;
using CvoBooksDemo.Dto;
using CvoBooksDemo.Repository.Repository;

namespace CvoBooksDemo.Controllers
{
    public class ClientsController : ApiController
    {
        // Private fields
        private readonly IClientRepository _ClientRepository;



        // Class Initializers
        public ClientsController(IClientRepository clientRepository)
        {
            _ClientRepository = clientRepository;
        }


        public ClientsController() : this(new ClientRepository())
        {
            
        }



        // Public API methods
        // GET api/clients
        public HttpResponseMessage Get()
        {
            try
            {
                var clients = _ClientRepository.Get().ToList();

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
                var client = _ClientRepository.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, new SaveClientMessage { Client = client });
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // POST api/clients
        public HttpResponseMessage Post(SaveClientMessage message)
        {
            try
            {
                _ClientRepository.Save(message.Client);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // PUT api/clients/5
        public HttpResponseMessage Put(int id, SaveClientMessage message)
        {
            try
            {
                _ClientRepository.Save(message.Client);

                //update message
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

                //delete message
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
