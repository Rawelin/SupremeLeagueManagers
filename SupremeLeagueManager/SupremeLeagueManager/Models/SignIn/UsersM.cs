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
        public string Pass { get; set; }

        public UsersM()
        {

        }

        public UsersM(int IdUser, byte[] password)
        {
            this.IdUser = IdUser;
            this.Password = password;
        }

        public void HashPassword()
        {
            PasswordHash passwordHash = new PasswordHash(this.Pass);
            this.Password = passwordHash.ToArray();
        }

        internal bool CheckPassword()
        {
            bool correct = false;

            Users users = new Users();
            users = CRUD.GetUserById(this.IdUser);

            if (this.Password == users.Password)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }

            return correct;
        }

        internal int RegistrationConfirmation()
        {
            int correct = 0;
            Users users = new Users();
            users = CRUD.GetUserById(this.IdUser);

            if (this.Password.SequenceEqual(users.Password))
            {

                users.AccountActivated = 1;
                users.Active = 1;

                CRUD.SaveRegistrationConfirmation(users);

                correct = 1;
            }

            return correct;
        }

        public int UserRegistration()
        {
            int result = 0;
            int IdUser = 0;

            HashPassword();

            try
            {
                if (!(CRUD.EmailExist(this.eMail)))
                {
                    IdUser = CRUD.AddNewUser(this);

                    if(IdUser != 0)
                    {
                        ThisServer server = new ThisServer();

                        UriBuilder uriBuilder = server.GetUrl();

                        EmailManagement.SendViaGmail(this.eMail, "Supreme", Email.RegistrationEmail(uriBuilder, this.Password, IdUser));
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