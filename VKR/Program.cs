using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR
{
    static class AuthClass
    {
        // Static field that stores the authentication status
        public static bool IsAuthenticated = false;
        // Static field that stores the user ID
        public static int auth_id = 0;
        // Static field that stores the user's full name
        public static string auth_fio = null;
        // Static field that stores the user's role title
        public static string auth_role_title = null;
        // Static field that stores the user's role privileges
        public static int auth_role = 0;

        static string sha256(string randomString)
        {
            // Cryptographic magic happens here. The purpose of this method is to hash the input string
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new MainForm());
        }
    }
}

