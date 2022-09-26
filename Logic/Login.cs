using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoEntitys;

namespace Logic
{
    public class Login
    {
        private unoDbModelContainer _context;
        public void logUserIn(string username, string password)
        {
            using (var _context = new unoDbModelContainer())
            {
                var credentialsWithUsername = from credentials in _context.credentialsSet
                    select credentials.player;

          ;
                foreach (var credentials in credentialsWithUsername)
                {
                    Console.WriteLine(credentials);
                }
                Console.WriteLine(credentialsWithUsername);
            }
            Console.WriteLine("Hola mundo logico");
            
        }
         
    }
}
