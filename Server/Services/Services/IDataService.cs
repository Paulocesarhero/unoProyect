using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dtos;

namespace Services
{
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        bool AddImages();

        [OperationContract]
        bool AddCredentials(DTOCredentials credentials);

    }

    
}
