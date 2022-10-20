using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Security;

namespace unoProyectServidor
{
    [ServiceContract]
    interface ICredentialsManager
    {
        [OperationContract]
        bool LogIn(Credentials credentialsReceived);

        [OperationContract]
        int SignUp(Credentials credentialsReceived);
    }

    [DataContract]
    public class Credentials
    {
        private String username;
        private String password;
        private String email;

        [DataMember]
        public String Username { get { return username; } set { username = value; } }

        [DataMember]
        public String Password { get { return password; } set { password = value; } }

        [DataMember]
        public String Email { get { return email; } set { email = value;  } }

    }
}
