using Logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.ServiceModel.Configuration;
using UnoEntitys;

namespace Logic
{
    public class SignUp
    {
        public bool addImages()
        {
            bool result = false;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {
                    images _image = new images {path = "images/avatar1" };
                    _context.imagesSet.Add(_image);
                    _context.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool addCredentials(string usernameReceived, string passwordReceived, string emailReceived)
        {
            CredentialsManagerClient client = new CredentialsManagerClient();
            
            /*
            credentials _credentials = new credentials
            {
                username = usernameReceived,
                password = passwordReceived,
                email = emailReceived
            };
            bool result = false;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {
                    images _images = new images { Id = 1 };
                    _context.imagesSet.Attach(_images);
                    player _player = new player { wins = 0, losts = 0, images = _images };
                    _credentials.player = _player;

                    var query = from credent in _context.credentialsSet
                                where credent.username == _credentials.username select credent.username;
                    if (query.Count() == 0)
                    {
                        _context.credentialsSet.Add(_credentials);
                        _context.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
            */
        }
        public bool ItsAUser(string usernameReceived, string passwordReceived)
        {
            //se tiene que conectar con el servidor
            credentials _credentials = new credentials
            {
                username = usernameReceived,
                password = passwordReceived
            };
            bool result = false;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {
                    var query = from credent in _context.credentialsSet
                                                  where credent.username == _credentials.username && credent.password == _credentials.password
                                                  select credent.username;
                    if(query.Count() > 0) 
                    {
                        result = true;
                    };
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