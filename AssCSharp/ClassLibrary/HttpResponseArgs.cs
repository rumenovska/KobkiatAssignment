using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class HttpResponseArgs : EventArgs
    {
        public string HttpBody { get; set; }
        public int ResponseCode { get; set; }

    }
}
