using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace lab6
{
    class User
    {
        public String Name;
        public String Surname;
        public String Hobby;
        public String Proffesion;

        public User(String name, String surname, String hobby, String proffesion)
        {
            Name = name;
            Surname = surname;
            Hobby = hobby;
            Proffesion = proffesion;
        }
        public static bool operator ==(User user1, User user2)
        {
            if (user1.Name == user2.Name && user1.Surname == user2.Surname)
                return true;
            return false;
        }

        public static bool operator !=(User user1, User user2)
        {
            return !(user1 == user2);
        }
    }
    
}
