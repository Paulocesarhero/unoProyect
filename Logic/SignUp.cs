﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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
        public bool addCredentials(credentials _credentials)
        {
            bool result = false;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {
                    images _images = new images { Id = 1 };
                    _context.imagesSet.Attach(_images);
                    player _player = new player { wins = 0, losts = 0, images = _images };
                    _credentials.player = _player;
                    _context.credentialsSet.Add(_credentials);

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
        public bool addFriends(int idplayer1, int idplayer2)
        {
            bool result = false;
            try
            {
                using (unoDbModelContainer _context = new unoDbModelContainer())
                {

                    player _player1 = _context.playerSet.FirstOrDefault(s => s.IdPlayer == idplayer1);
                    player _player2 = _context.playerSet.FirstOrDefault(s => s.IdPlayer == idplayer2);

                    

                    _player1.friends.Add(_player2);
                    _context.playerSet.Add(_player1);
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
        public bool itsAUser(credentials _credentials)
        {
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