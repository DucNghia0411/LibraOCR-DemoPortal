using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Model
{
    public class RequestResponse
    {
        public ErrorCode ErrorCode { get; set; }
        public string Content { get; set; }
    }
    public enum ErrorCode
    {
        Success = 0,
        GeneralFailure = 1,
        NotFound = 2
    }
}
