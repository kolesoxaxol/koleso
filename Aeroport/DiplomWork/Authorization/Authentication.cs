using AirModel.Models;
using BusinessLogicLayer.Services.IServices;
using DiplomWork.Authorization.AuthInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace DiplomWork.Authorization
{
    public class Authentication:IAuthentication
    {
         private readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private const string CookieName = "AUTH_COOKIE";
        private IPrincipal _currentUser;
        readonly IAuthenticationService _authService;

        public Authentication(IAuthenticationService authService)
        {
            _authService = authService;
        }

        public HttpContext HttpContext { get; set; }  
        public User Login(string userName, string password, bool isPersistent)
        {
            try
            {
                User regUser = _authService.Login(userName, password);
                if (regUser != null)
                {
                    CreateCookie(userName, isPersistent);
                }
                return regUser;
            }
            catch(Exception ex)
            {
                _logger.Error("Some error GameStoreAuthentication.cs " + ex.Message);
                throw;
            }

        }


        public User Login(string userName)
        {
            try
            {
                User retUser = _authService.Login(userName);
                if (retUser != null)
                {
                    CreateCookie(userName);
                }
                return retUser;
            }
            catch (Exception ex)
            {
                _logger.Error("Some error GameStoreAuthentication.cs " + ex.Message);
                throw;
            }
        }

        public void LogOut()
        {
            try
            {
                var httpCookie = HttpContext.Response.Cookies[CookieName];
                if (httpCookie != null)
                {
                    httpCookie.Value = string.Empty;
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Some error GameStoreAuthentication.cs " + ex.Message);
                throw;
            }
        }


        private void CreateCookie(string userName, bool isPersistent = false)
        {
            try
            {
                var ticket = new FormsAuthenticationTicket(
                   1,
                   userName,
                   DateTime.Now,
                   DateTime.Now.Add(FormsAuthentication.Timeout),
                   isPersistent,
                   string.Empty,
                   FormsAuthentication.FormsCookiePath);

                // Encrypt the ticket.
                var encTicket = FormsAuthentication.Encrypt(ticket);

                // Create the cookie.
                var authCookie = new HttpCookie(CookieName)
                {
                    Value = encTicket,
                    Expires = DateTime.Now.Add(FormsAuthentication.Timeout)
                };
                
                HttpContext.Response.Cookies.Set(authCookie);
            }
            catch (Exception ex)
            {
                _logger.Error("Some error GameStoreAuthentication.cs " + ex.Message);
                throw;
            }
        }

        public IPrincipal CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    try
                    {
                       
                        HttpCookie authCookie = HttpContext.Request.Cookies.Get(CookieName);
                        if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                        {
                            var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                            if (ticket != null)
                                _currentUser = new UserProvider(ticket.Name, _authService);
                        }
                        else
                        {
                            _currentUser = new UserProvider(null, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.Error("Failed authentication: " + ex.Message);
                        _currentUser = new UserProvider(null, null);
                    }
                }
                return _currentUser;
            }
    }
}
}