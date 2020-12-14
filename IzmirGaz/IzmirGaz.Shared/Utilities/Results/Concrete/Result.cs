using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Shared.Utilities.Results.Abstract;
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;

namespace IzmirGaz.Shared.Utilities.Results.Concrete
{
  public   class Result:IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }


        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
