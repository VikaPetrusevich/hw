using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.BL
{
    public class TransportNotFoundException : Exception
    {
        public TransportNotFoundException() : base()
        { 
        
        }

        public TransportNotFoundException(string message) : base(message)
        { 
        
        }

        public TransportNotFoundException(string message, Exception innerException) : base(message, innerException) 
        { 
        
        }
    }
}