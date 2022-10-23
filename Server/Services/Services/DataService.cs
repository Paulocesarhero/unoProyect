using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    public class DataService : IDataService
    {
        public bool AddCredentials(DTOCredentials credentials)
        {
            Console.WriteLine("Se agrego la credencial " + credentials.Username);
            return true;
        }

        public bool AddImages()
        {
            throw new NotImplementedException();
        }
    }
}
