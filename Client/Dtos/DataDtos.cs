using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dtos
{
    [DataContract]
    public class DTOCredentials
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Email { get; set; }


    }
}
