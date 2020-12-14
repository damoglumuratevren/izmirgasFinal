using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;

namespace IzmirGaz.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}
