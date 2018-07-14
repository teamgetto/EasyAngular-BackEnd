using System;
namespace EasyAngular.Model
{
    public class RequestDTO<T> where T :BaseDTO
    {
       public T Entity
        {
            get;
            set;
        }
    }
}
