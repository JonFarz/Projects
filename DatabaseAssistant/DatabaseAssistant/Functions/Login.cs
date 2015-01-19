using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management.Automation;
using System.Security;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1.Functions
{
    public class Login 
    {
        private static string uname;
        private static SecureString SS;

        public static string UserName
        {
            get { return uname; }
            set { uname = value.ToString(); }
        }

        public static SecureString LoginSecureString
        {
            get { return SS; }
            set { SS = value; }
        }

        public static string ConvertToUnsecureString()
        {
            if (SS == null)
                throw new ArgumentNullException("securePassword");

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(SS);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        public static string ConvertToUnsecureString(SecureString SSS)
        {
            if (SS == null)
                throw new ArgumentNullException("securePassword");

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(SSS);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        /*
        public void SetPasswordSS(this string Pass)
        {
            if (Pass == null)
                throw new ArgumentNullException("Missing Password!");
            unsafe
            {
                fixed (char* P_Star = Pass)
                {
                    var securePassword = new SecureString(P_Star, Pass.Length);
                    securePassword.MakeReadOnly();
                    SS = securePassword;
                    SS.MakeReadOnly();
                }
            }
        }
         */

        public Boolean ValidateLogin(string name, SecureString pass)
        {
            bool valid = false;
            using (PrincipalContext P = new PrincipalContext(ContextType.Domain))
            {
                valid = P.ValidateCredentials(name, ConvertToUnsecureString(pass));
            }

            if (valid)
            {
                SS = pass;
                uname = name;
            }
           return valid;
        }
    }
}
