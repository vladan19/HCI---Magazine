using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class PasswordUtility {
        private const int NumIterations = 10000;
        private const int HashLength = 20;
        private const int SaltLength = 10;

        public static bool CheckPassword(string password, byte[] hash, byte[] salt) {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, NumIterations);
            byte[] newHash = pbkdf2.GetBytes(HashLength);

            for (int i = 0; i < HashLength; i++) {
                if (hash[i] != newHash[i]) {
                    return false;
                }
            }

            return true;
        }

        public static List<byte[]> GenerateHash(string password) {
            List<byte[]> result = new List<byte[]>();
            byte[] salt = new byte[SaltLength];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider()) {
                rngCsp.GetBytes(salt);
            }
            result.Add(salt);
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, NumIterations);
            byte[] hash = pbkdf2.GetBytes(HashLength);
            result.Add(hash);
            return result;
        }
    }
}
