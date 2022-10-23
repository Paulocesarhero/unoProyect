using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UnoEntitys;
using Dtos;
using Logic;

namespace Services
{
    public class DataService : IDataService
    {
        public bool AddCredentials(DTOCredentials credentials)
        {
            bool result = false;
            DtosToEntitys dtosTo = new DtosToEntitys();
            
            credentials entityCredential = dtosTo.DtoCredentialsToEntity(credentials);


            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {

                    images _images = new images { Id = 1 };
                    _context.imagesSet.Attach(_images);
                    player _player = new player { wins = 0, losts = 0, images = _images };
                    entityCredential.player = _player;
                    _context.credentialsSet.Add(entityCredential);

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

        public bool AddImages()
        {
            throw new NotImplementedException();
        }
    }
}
