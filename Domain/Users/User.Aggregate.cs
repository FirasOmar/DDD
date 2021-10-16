using Domain.Base;
using Domain.Departments;

using System;
using System.Linq;

namespace Domain.Users
{
    public partial class User: IAggregateRoot
    {
        public User(string userName
            , string password     
            , string address      
            , int departmentId)
        {
            UserName = userName;

            this.Update(
                password      
                , address       
                , departmentId
            );
        }

        public void Update(string password  
            , string address   
            , int departmentId)
        {
            Password = password;       
            Address = address;    
            DepartmentId = departmentId;
        }

        public void AddDepartment(int departmentId)
        {
            DepartmentId = departmentId;
        }

       
    }
}