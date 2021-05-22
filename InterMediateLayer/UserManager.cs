using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RadioDatabase;

namespace InterMediateLayer
{
    public class UserManager
    {
        private static User user = null;
        public static User User { get => user; private set => user = value; }

        public void CreateUser(out string errorMessage, string firstName = "Bongani", string lastName = "Luwemba", string userName = "Bongiboy777", string email = "Bongtheman@outlook.com", string passWord = "1234567")
        {
            using (var db = new RadioContext())
            {
                errorMessage = null;

                if (db.Users.Where(u => u.Email == email).Count() != 0)
                {
                    errorMessage = $"This email address is already in use with another account.";
                    return;
                }
                try
                {
                    db.Users.Add(new User(firstName, lastName, userName, email, passWord));

                    db.SaveChanges();
                }

                catch (DbUpdateConcurrencyException e)
                {
                    errorMessage = $"Could not add user please check fields: {e.Message}";
                }

                catch (DbUpdateException ex)
                {
                    errorMessage = $"Could not add user please check fields: {ex.Message}";
                }

            }
        }

        public void CreateUser(string firstName = "Bongani", string lastName = "Luwemba", string userName = "Bongiboy777", string email = "Bongtheman@outlook.com", string passWord = "1234567")
        {
            using (var db = new RadioContext())
            {

                try
                {
                    db.Users.Add(new User(firstName, lastName, userName, email, passWord));

                    db.SaveChanges();
                }

                catch (DbUpdateConcurrencyException e)
                {
                    Console.WriteLine($"Could not add user please check fields: {e.Message}");
                }

                catch (DbUpdateException ex)
                {
                    Console.WriteLine($"Could not add user please check fields: {ex.Message}");
                }

            }
        }

        public List<PlayList> GetChannels(User user)
        {
            using (var db = new RadioContext())
            {
                return db.Users.Include(u => u.PlayLists).Where(x => x.UserId == user.UserId).Select(x => x.PlayLists).First().ToList();
            }
        }

        public void UpdateUser(out string errorMessage, User user, string firstName = null, string lastName = null, string passWord = null, string userName = null, string email = null)
        {
            using (var db = new RadioContext())
            {
                errorMessage = null;


                try
                {
                    user.LastName = lastName != null ? lastName : user.LastName;
                    user.FirstName = firstName != null ? firstName : user.FirstName;

                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    errorMessage = $"Could not update firstname or last name fields, please check: {e.Message}";
                }

                try
                {
                    user.Username = userName != null ? userName : user.Username;
                    db.SaveChanges();


                }

                catch (Exception e)
                {
                    errorMessage = $"Username was put in incorrect format, please correct";
                }

                // Assign email
                try
                {
                    user.Email = email != null ? email : user.Email;
                    db.SaveChanges();
                }

                catch (DbUpdateException ex)
                {
                    errorMessage = $"Email was put in incorrect format, please correct";
                }

                try
                {
                    user.PassWord = passWord != null ? passWord : user.PassWord;
                    db.SaveChanges();
                }

                catch (Exception ex)
                {

                }

                db.SaveChanges();
            }
        }

        public void RemoveUser(out string errorMessage, User user)
        {
            using (var db = new RadioContext())
            {
                errorMessage = null;


                try
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    errorMessage = $"Could not update firstname or last name fields, please check: {e.Message}";
                }

                catch (ArgumentNullException ex)
                {
                    errorMessage = $"This user does not exist anymore.";
                }


            }
        }

        public bool VerifyUser(out string error, string password, string email = null, string userName = null)
        {
            error = null;
            
            using (var db = new RadioContext())
            {
                
                try
                {
                    user = userName != null ? db.Users.Where(u => u.Username == userName).First()
                        : email != null ? db.Users.Where(u => u.Email == email).First() : null;
                }

                catch (InvalidOperationException e)
                {
                    error = email == null ? $"Username {userName} is incorrect or does not exist." : $"Email {email} is incorrect or does not exist";
                    return false;
                }

                if (user != null)
                {
                    return user.PassWord == password;
                }

                return false;
            }

        }

        public bool UpdatePassword(User user, string password)
        {
            using (var db = new RadioContext())
            {
                try 
                {
                    db.Users.First(u => u.UserId == user.UserId).PassWord = password;
                    db.SaveChanges();
                    if (user.PassWord == password)
                    {
                        return true;
                    }

                    else { return false; }
                }

                catch
                {
                    return false;
                }
                
            }
        }

    }
}
