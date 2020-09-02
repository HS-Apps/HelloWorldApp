using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldMessage
{
    public interface IConfigService
    {
        public string MessageApiUri { get; }
    }
}
