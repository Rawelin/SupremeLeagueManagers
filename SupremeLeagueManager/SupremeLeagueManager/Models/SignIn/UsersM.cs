using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;

using SLMContextDB;
using SupremeLeagueManager.Models.Global;

namespace SupremeLeagueManager.Models.SignIn
{
    public class UsersM : Users
    {
        public int UserRegistration()
        {
            int result = 0;
            int IdUser = 0;

            try
            {
                if (!(CRUD.EmailExist(this.eMail)))
                {
                    IdUser = CRUD.AddNewUser(this);

                    if(IdUser != 0)
                    {
                        ThisServer server = new ThisServer();

                        UriBuilder uriBuilder = server.GetUrl();

                        Email.RegistrationEmail(uriBuilder, this.Password, IdUser);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return result;
        }
    }
}