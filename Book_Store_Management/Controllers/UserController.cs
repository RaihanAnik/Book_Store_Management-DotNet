using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;



namespace Book_Store_Management.Controllers

{
   
    
    public class UserController : ApiController
    {

        
        [HttpGet]
        [Route("api/users")]
        public HttpResponseMessage Users()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [Route("api/user/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserDTO user)
        {

            try
            {
                var data = UserService.Create(user);


                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "A New User Created Successfully");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/user/update/{id}")]
        public HttpResponseMessage UpdateUser(UserDTO user)
        {

            try
            {
                var data = UserService.Update(user);
                return Request.CreateResponse(HttpStatusCode.OK, "Information Updated");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }



        [Route("api/user/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteUser(string id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [HttpGet]
        [Route("api/user/{id}/product")]
        public HttpResponseMessage Products(string id)
        {
            try
            {
                var data = UserService.GetwithProducts(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}