//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using RadioDatabase;
//using Radio;

//namespace RadioTests
//{
//    public class AuthenticationTests
//    {
//        UserManager userManager;
//        [SetUp]
//        public void Setup()
//        {
//            userManager = new UserManager();
//            using (var db = new RadioContext())
//            {
//                db.Users.Add(new User("Bongani", "Luwemba", "Bongiboy777", "bongiluwe777@gmail.com", "1234567"));
//                db.SaveChanges();
//            }
//        }

//        [Test]
//        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
//        {
//            using (var db = new RadioContext())
//            {
//                var currentCount = db.Users.Count();
//                userManager.CreateUser(out string errorMessage);
      
//                Assert.AreEqual(currentCount + 1, db.Users.Count());
//            }
//        }



//        //[TestCase("Mandal")]
//        //[TestCase("Superman")]
//        //[TestCase("123243")]
//        //public void CustomerIDnotover5Chars(string id)
//        //{
//        //    using (var db = new RadioContext())
//        //    {
//        //        Assert.Throws<Microsoft.EntityFrameworkCore.DbUpdateException>(() => userManager.CreateUser("Nish Mandal", "Sparta"));
//        //    }
//        //}



//        [TestCase("Greece", "Sparta", "SPA7TA", "Ladnam Hsin")]
//        [TestCase("France", "Paris", "SP87EA", "Michael Jordan")]
//        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated(string firstName, string lastName, string email, string userName)
//        {
//            using (var db = new RadioContext())
//            {
//                userManager.CreateUser(out string errorMessage2, "MANDA", "Nish Mandal");
//                userManager.UpdateUser(out string errorMessage,db.Users.Where(u => u.FirstName=="MANDA").First() ,firstName, lastName, userName:userName, email:email);
//                Assert.AreEqual(db.Users.Find(2).FirstName, firstName);
//                Assert.AreEqual(db.Users.Find(2).LastName, lastName);
//                Assert.AreEqual(db.Users.Find(2).Email, email);
//                Assert.AreEqual(db.Users.Find(2).Username, userName);

//                db.Users.RemoveRange(db.Users.Where(u => u.FirstName == "MANDA"));
//            }
//        }



//        [Test]
//        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
//        {
//            //using (var db = new NorthwindContext())
//            //{
//            //    userManager.CreateUser("MANDA", "Nish Mandal", "Sparta");
//            //    _customerManager.DeleteCustomer("MANDA");
//            //    Assert.Null(db.Customers.Find("MANDA"));
//            //}
//        }

//        [TearDown]
//        public void Teardown()
//        {
//            //using (var db = new RadioContext())
//            //{
//            //    var x = db.Users.Where(u => u.FirstName == "Bongani" && u.LastName == "Luwemba");
//            //    if(x.ToList().Count == 0)
//            //    {
//            //        db.Users.RemoveRange(x);
//            //    }
//            //    db.SaveChanges();
                
//            //}
//        }



//    }
//}
