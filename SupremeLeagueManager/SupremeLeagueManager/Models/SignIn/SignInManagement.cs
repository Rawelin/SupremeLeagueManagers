using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;

using SLMContextDB;
using SupremeLeagueManager.Models.Global;

namespace SupremeLeagueManager.Models.SignIn
{
    public class SignInManagement
    {
        UsersM usersM = new UsersM();
        Users users = new Users();

        public int status = 0;

        public SignInManagement()
        {

        }

        public SignInManagement(UsersM users)
        {
            this.usersM = users;
        }

        public void UserRegistration()
        {
            int IdUser = 0;

            HashPassword();

            try
            {
                if (!(CRUD.EmailExist(usersM.eMail)))
                {
                    IdUser = CRUD.AddNewUser(usersM);

                    if (IdUser != 0)
                    {
                        ThisServer server = new ThisServer();

                        UriBuilder uriBuilder = server.GetUrl();

                        EmailManagement.SendViaGmail(usersM.eMail, "Supreme", Email.RegistrationEmail(uriBuilder, usersM.Password, IdUser));
                    }
                    else
                    {
                        status = 2; //Utworzenie konta nie powiodło się.
                    }
                }
                else
                {
                    status = 1; //eMail istnieje w bazie danych
                }
            }
            catch (Exception ex)
            {
                status = 3; //Błąd podczas próby wysłania maila.
                Debug.WriteLine(ex.ToString());
            }
        }

        public void Confirmation(byte[] password, int IdUser)
        {
            this.users = CRUD.GetUserById(IdUser);

            if(users.IdUser != 0)
            {
                if (password.SequenceEqual(this.users.Password))
                {
                    CRUD.ActivateUsers(this.users);
                }
                else
                {
                    status = 2; //Podane hasło jest nie prawidłowe.
                }
            }
            else
            {
                status = 1; //Użytkownik o pdanym Id nie istnieje.
            }
        }

        public UsersM GetUsersM()
        {
            UsersM users = new UsersM(this.users);
            return users;
        }
        
        public int GetStatus()
        {
            return this.status;
        }

        public void HashPassword()
        {
            PasswordHash passwordHash = new PasswordHash(usersM.Pass);
            usersM.Password = passwordHash.ToArray();
        }

        public bool SessionAdd(UsersM users)
        {
            bool correct = false;

            try
            {
                HttpContext httpContext = HttpContext.Current;

                httpContext.Session["IdUser"] = users.IdUser;
                httpContext.Session["eMail"] = users.eMail;
                httpContext.Session["FirstName"] = users.FirstName;
                httpContext.Session["LastName"] = users.LastName;
                httpContext.Session["AccountActivated"] = users.AccountActivated;
                httpContext.Session["Active"] = users.Active;

                correct = true;
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("SignIn", "SignInManagement", "SessionAdd", ex);
            }

            return correct;
        }

        public bool SessionRemove()
        {
            bool correct = false;

            try
            {
                HttpContext httpContext = HttpContext.Current;

                httpContext.Session["IdUser"] = null;
                httpContext.Session["eMail"] = null;
                httpContext.Session["FirstName"] = null;
                httpContext.Session["LastName"] = null;
                httpContext.Session["AccountActivated"] = null;
                httpContext.Session["Active"] = null;

                correct = true;
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("SignIn", "SignInManagement", "SessionAdd", ex);
            }

            return correct;
        }
    }
}