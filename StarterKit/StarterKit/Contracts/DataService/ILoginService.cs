using StarterKit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarterKit.Contracts.Services.Data
{
    /// <summary>
    /// Login Services
    /// </summary>
    interface ILoginService
    {
        /// <summary>
        /// Authentification
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<LoginResponse> Authenticate(string userName, string password);

        /// <summary>
        /// Check user authentificated
        /// </summary>
        /// <returns></returns>
        bool IsUserAuthenticated();
    }
}
