using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NUnit.Framework;
using RadioDatabase;
using Radio;

namespace RadioTests
{
    public class AuthenticationTests
    {
        UserManager userManager;
        [SetUp]
        public void Setup()
        {
            userManager = new UserManager();
            using (var db = new RadioContext())
            {
                db.Users.Add(new User("Bongani", "Luwemba", "Bongiboy777", "bongiluwe777@gmail.com", "1234567"));
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewUserIsAdded_TheNumberOfUsersIncreasesBy1()
        {
            using (var db = new RadioContext())
            {
                var currentCount = db.Users.Count();
                userManager.CreateUser(out string errorMessage);

                Assert.AreEqual(currentCount + 1, db.Users.Count());
            }
        }

        [Test]
        public void CannotAddUserWithMatchingEmail()
        {
            using (var db = new RadioContext())
            {
                var currentCount = db.Users.Count();
                userManager.CreateUser(out string errorMessage, email: "bongiluwe777@gmail.com");

                Assert.NotNull(errorMessage);
                Assert.AreEqual(errorMessage, "This email address is already in use with another account.");
            }
        }

        [TestCase("ashfsads","asfdefdsg","asfdfsfa","asdfdsg","sdffsvs")]
        public void NewCustomerDoesntGiveErrorMessageWhenNoProblems(string firstName, string lastName, string passWord, string email, string userName)
        {
            using (var db = new RadioContext())
            {
                var currentCount = db.Users.Count();
                userManager.CreateUser(out string errorMessage);
                userManager.CreateUser(out string errorMessage2,firstName,lastName,userName,email,passWord);
                Assert.Null(errorMessage);
                Assert.Null(errorMessage2);
                db.Users.RemoveRange(db.Users.Where(u => u.FirstName == firstName && u.LastName == lastName && u.PassWord == passWord && u.Email == email));
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenACustomerIsDeleted_TheNumberOfCustomersDecreasesBy1()
        {
            using (var db = new RadioContext())
            {
                db.Users.Add(new User("lp09ijhs","qwerty","qwerty","qwerty","qwerty"));
                db.SaveChanges();
                int currentCount = db.Users.Count();

                var user = db.Users.First(u => u.FirstName == "lp09ijhs");
                userManager.RemoveUser(out string message,user);
               
                Assert.AreEqual(currentCount - 1, db.Users.Count());
            }
        }



        [TestCase("Mandalasfffffffffffffffffffffafdsgdsgdsvrwbrbsvsrvesvesvscescaecacdsvdsvdsvdsvacdsvdvswcvesvsvsdvdscvadsvdwvqavdsvsavdsvdsavdadv")]
        
        public void TryingToAddWrongDetailsOverCharacterLimitGivesErrorMessage(string field)
        {
            using (var db = new RadioContext())
            {
                userManager.CreateUser(out string errorMessage, firstName:field);
                userManager.CreateUser(out string errorMessage1, lastName:field);
                userManager.CreateUser(out string errorMessage2, passWord:field);
                userManager.CreateUser(out string errorMessage4, email:field);
                userManager.CreateUser(out string errorMessage3, userName:field);
               Assert.NotNull(errorMessage);
                Assert.NotNull(errorMessage1);
                Assert.NotNull(errorMessage2);
                Assert.NotNull(errorMessage3);
                Assert.NotNull(errorMessage4);


            }
        }



        [TestCase("Michael", "Jordan", "MJGOATalltime@nba.com", "MJ")]
        [TestCase("Barry", "Harris", "SP87EA", "")]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated(string firstName, string lastName, string _email, string _userName)
        {
            using (var db = new RadioContext())
            {
                var @var = new User();
                userManager.CreateUser(out string errorMessage2, "MANDA", "Nish Mandal");
                var user = db.Users.Where(u => u.FirstName == "MANDA").First();
                userManager.UpdateUser(out string errorMessage, user, firstName, lastName, userName: _userName, email: _email);
                Assert.AreEqual(user.FirstName, firstName);
                Assert.AreEqual(user.LastName, lastName);
                Assert.AreEqual(user.Email, _email);
                Assert.AreEqual(user.Username, _userName);

                db.Users.RemoveRange(db.Users.Where(u => u.UserId == user.UserId));
                db.SaveChanges();
            }
        }



        [Test]
        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new RadioContext())
            {
                userManager.CreateUser(out string error2,"MANDA", "Nish Mandal", "Spartan");
                userManager.RemoveUser(out string error,db.Users.First(u => u.Username == "Spartan" && u.FirstName == "MANDA"));
                Assert.Throws<InvalidOperationException>(() => db.Users.First(u => u.Username == "Spartan" && u.FirstName == "MANDA"));
            }
        }

        [Test]
        public void VerifyLogInDetailsTrueIfCorrect()
        {
            using (var db = new RadioContext())
            {
                userManager.VerifyUser(out string error2, "MANDA", "Nish Mandal", "Spartan");
                userManager.RemoveUser(out string error, db.Users.First(u => u.Username == "Spartan" && u.FirstName == "MANDA"));
                Assert.Throws<InvalidOperationException>(() => db.Users.First(u => u.Username == "Spartan" && u.FirstName == "MANDA"));
            }
        }


        [TearDown]
        public void Teardown()
        {
            using (var db = new RadioContext())
            {
                var x = db.Users.Where(u => u.FirstName == "Bongani" && u.LastName == "Luwemba");
                if (x.ToList().Count != 0)
                {
                    db.Users.RemoveRange(x);
                }
                db.SaveChanges();

            }
        }





    }
}
