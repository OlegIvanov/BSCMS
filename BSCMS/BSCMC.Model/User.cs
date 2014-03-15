using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
