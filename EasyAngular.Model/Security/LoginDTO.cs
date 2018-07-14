using System;
namespace EasyAngular.Model
{
    public class LoginDTO : BaseDTO
    {
        public string UserName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
    }
}
