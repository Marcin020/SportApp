﻿using System;

namespace SportApp.Tables
{
    public class RegUserTable
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

    }
}
