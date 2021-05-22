using System;
using System.Collections.Generic;

#nullable disable

namespace RadioDatabase
{
    public partial class User
    {

        public User(string firstName, string lastName, string userName, string email, string passWord)
        {
            PlayLists = new HashSet<PlayList>();
            
            FirstName = firstName;
            LastName = lastName;
            Username = userName;
            Email = email;
            PassWord = passWord;
            DateJoined = DateTime.Now;
        }

        public User()
        {
            PlayLists = new HashSet<PlayList>();
            
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassWord { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}
