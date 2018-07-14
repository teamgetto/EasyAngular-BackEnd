using System;
using EasyAngular.Model;
using EasyAngular.Model.Security;
using Microsoft.AspNetCore.Mvc;


namespace EasyAngular.Api.Controllers.Security
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {

        [HttpPost]
        public JsonResult Login([FromBody]RequestDTO<LoginDTO> requestDTO)
        {
            if (requestDTO.Entity.UserName == "at012337" && requestDTO.Entity.Password == "_qaws.3040")
            {
                return Json(new ResponseDTO<TokenDTO>
                {
                    Entity = new TokenDTO
                    {
                        Key = Guid.NewGuid().ToString()
                    }
                });
            }
            else 
            {
                return Json(new ResponseDTO<TokenDTO>
                {
                    HasError=true,
                    Error ="LoginNotFound"
                });
            }
           
        }

    }
}
