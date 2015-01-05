using BusinessLogicLayer.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace DiplomWork.Authorization
{
    public class UserProvider : IPrincipal
    {
        private UserIndentity UserIdentity { get; set; }

        readonly IAuthenticationService _authService;
        public UserProvider(string name, IAuthenticationService authService)
        {
            _authService = authService;
            UserIdentity = new UserIndentity();
            UserIdentity.Init(name, authService);
        }


        /// <summary>
        /// user id
        /// </summary>
        public IIdentity Identity
        {
            get
            {
                return UserIdentity;
            }
        }


        /// <summary>
        /// exist in role or not
        /// </summary>
        /// <param name="role">role name</param>
        /// <returns>is exist this role</returns>
        public bool IsInRole(string role)
        {
            if (UserIdentity.User == null)
                return false;
            return _authService.InRoles(role, UserIdentity.User);
        }

        public override string ToString()
        {
            return UserIdentity.Name;
        }
    }
}