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
    public class CustomersController : ApiController
    {
        // Private fields
        private readonly ICustomerRepository _CustomerRepository;



        // Class Initializers
        public CustomersController(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }


        public CustomersController() : this(new CustomerRepository())
        {
            
        }



        // Public API methods
        // GET api/customers
        public HttpResponseMessage Get()
        {
            try
            {
                var customers = _CustomerRepository.Get().ToList();

                return Request.CreateResponse(HttpStatusCode.OK, new GetCustomerRequestMessage { Customers = customers });


            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // GET api/customers/5
        public HttpResponseMessage Get([FromUri]int id)
        {
            try
            {
                var customer = _CustomerRepository.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, new SaveCustomerMessage { Customer = customer });
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // POST api/customers
        public HttpResponseMessage Post(SaveCustomerMessage message)
        {
            try
            {
                _CustomerRepository.Save(message.Customer);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // PUT api/customers/5
        public HttpResponseMessage Put(int id, SaveCustomerMessage message)
        {
            try
            {
                _CustomerRepository.Save(message.Customer);

                //update message
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        // DELETE api/customers/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
