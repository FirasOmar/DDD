using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Users;
namespace UserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void username_Validate()
        {
            //arrange
            string username = "Firas";
            string password = "pass@123";
            string Address = "Ramallah";
            int DepartmentId = 12;

            User u = new User(username,password,Address,DepartmentId);

            //Assert
            Assert.IsNotNull(u.UserName);
        }

        [TestMethod]
        public void Add_Department()
        {
            //arrange
            string username = "Firas";
            string password = "pass@123";
            string Address = "Ramallah";
            int DepartmentId = 12;

            User u = new User(username, password, Address, DepartmentId);

            //Act
            u.AddDepartment(u.DepartmentId);

            //Assert
            Assert.IsInstanceOfType(u.DepartmentId, typeof(int));
        }
    }
}
