using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Database.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
            : base("mycon")
        {
            DropCreateDatabaseIfModelChanges<User
        }
    }
}