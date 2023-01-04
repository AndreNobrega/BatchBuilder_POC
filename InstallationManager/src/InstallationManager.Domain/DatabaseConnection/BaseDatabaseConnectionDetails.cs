using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DatabaseConnection
{
    public abstract class BaseDatabaseConnectionDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
