using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldMessage
{
    public interface IWriteService
    {
        public bool WriteMessage(string message);
    }
}
