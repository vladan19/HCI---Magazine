using Magazine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class AccountController {
        public static magazineEntities entities = new magazineEntities();
        public static user User;

        public static bool RegisterUser(string fisrtName, string lastName, string email, string username, string password, string role) {
            if(entities.users.Any(us=> us.Username == username)) {
                return false;
            }
            user u = new user();
            u.Firstname = fisrtName;
            u.Lastname = lastName;
            u.Email = email;
            u.Username = username;
            List<byte[]> saltNhash = PasswordUtility.GenerateHash(password);
            u.Password = saltNhash[1];
            u.Salt = saltNhash[0];
            u.group = entities.groups.Where(g => g.Name == role).First();
            entities.users.Add(u);
            entities.SaveChanges();
            return true;
        }
        
        public static bool Login(string username, string password) {
            if (entities.users.Any(us => us.Username == username)) {
                user u = entities.users.Where(us => us.Username == username).First();
                if(PasswordUtility.CheckPassword(password, u.Password, u.Salt)) {
                    User = u;
                    return true;
                }
                else {
                    return false;
                }
            }
            return false;
        }
    }
}
