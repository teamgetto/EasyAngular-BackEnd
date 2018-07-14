using System;
using EasyAngular.Model.Security;

namespace EasyAngular.Model
{
    public class ResponseDTO<T> where T : BaseDTO
    {
        public T Entity
        {
            get;
            set;
        }

        public bool HasError
        {
            get;
            set;
        }


        public string Error
        {
            get;
            set;
        }
    }
}