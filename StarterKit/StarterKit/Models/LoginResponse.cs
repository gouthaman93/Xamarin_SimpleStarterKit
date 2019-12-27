using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKit.Models
{
    /// <summary>
    /// Login Response
    /// </summary>
    public class LoginResponse
    {
        public bool IsAuthenticated { get; set; }

        public User User { get; set; }
    }
}
