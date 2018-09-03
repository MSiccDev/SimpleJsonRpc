using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleJsonRpc
{
    public class RpcException : System.Exception
    {
        public RpcException(int code, string message, object data)
        {
            this.Code = code;
            this.Message = message;
            this.Data = data;
        }

        //we cannot make sure that we are always receiving a dicitionary style error, 
        //that's why we are passing object here instead of IDictionary implementation
        //consumer must parse this depending on their needs
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public object Data
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            get;
        }

        public override string Message { get;  }

        public int Code { get; }

    }
}
