﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class UserLoginCache
    {
        public static int IdUser { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }
        public static int Saldos { get; set; }
        public static string Cedula { get; set; }
        public static string LoginName { get; set; }
    }
}
