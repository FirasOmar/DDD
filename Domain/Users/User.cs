using Domain.Base;
using Domain.Departments;
using System;
using System.Collections.Generic;

namespace Domain.Users
{
    public partial class User : BaseEntity<int>
    {
        public User()
        {
          
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Address { get; private set; }
   
        public int DepartmentId { get; private set; }

        public virtual Department Department { get; private set; }
    }
}