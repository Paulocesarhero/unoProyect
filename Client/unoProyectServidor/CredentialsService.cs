using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoEntitys;

namespace unoProyectServidor
{
    public class CredentialsService : ICredentialsManager
    {
        public bool LogIn(Credentials credentialsReceived)
        {
            credentials _credentials = new credentials
            {
                username = credentialsReceived.Username,
                password = credentialsReceived.Password
            };
            bool result = false;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {
                    var query = from credent in _context.credentialsSet
                                where credent.username == _credentials.username && credent.password == _credentials.password
                                select credent.username;
                    if (query.Count() > 0)
                    {
                        result = true;
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Console.WriteLine("Resultado: ", result);
            return result;
        }

        /**
         * Retorna 0 si ocurrió una excepción, 1 si se registró correctamente, 2 si ya existía ese username registrado
         * */
        public int SignUp(Credentials credentialsReceived)
        {
            credentials _credentials = new credentials
            {
                username = credentialsReceived.Username,
                password = credentialsReceived.Password,
                email = credentialsReceived.Email
            };
            int result = 0;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {
                    images _images = new images { Id = 1 };
                    _context.imagesSet.Attach(_images);
                    player _player = new player { wins = 0, losts = 0, images = _images };
                    _credentials.player = _player;

                    var query = from credent in _context.credentialsSet
                                where credent.username == _credentials.username
                                select credent.username;
                    if (query.Count() == 0)
                    {
                        _context.credentialsSet.Add(_credentials);
                        _context.SaveChanges();
                        result = 1;
                    }
                    else
                    {
                        result = 2;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
