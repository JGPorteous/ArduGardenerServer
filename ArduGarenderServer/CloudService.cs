using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduGarenderServer
{
    class CloudService
    {
        public CloudServiceSettings Settings = new CloudServiceSettings();
        public Exception LastException = new Exception();

        public CloudService()
        { 
            
        }

        public bool TestConnection()
        {
            try
            {
                throw new Exception("Failed to connect to Cloud Services!\nPlease check your settings.");
            }
            catch (Exception thisException)
            {
                LastException = thisException;
                return false;
            }
            return true;
            
        }


    }
}
