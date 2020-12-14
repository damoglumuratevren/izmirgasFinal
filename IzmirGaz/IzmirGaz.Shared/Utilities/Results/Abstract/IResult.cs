using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;

namespace IzmirGaz.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message{ get;  }

        public Exception Exception { get; }
    }
}
