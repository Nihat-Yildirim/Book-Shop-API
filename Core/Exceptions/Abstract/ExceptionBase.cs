using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions.Abstract
{
    public class ExceptionBase : Exception
    {
        public HttpStatusCode StatusCodes { get; private set; }

        public ExceptionBase(HttpStatusCode statusCodes,string message) : base(message)
        {
            StatusCodes = statusCodes;
        }
    }
}