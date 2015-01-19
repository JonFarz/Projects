using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.Diagnostics;
using System.IO;
using System.Security;

namespace WindowsFormsApplication1.Functions
{
    
    class DifferentUserApplicationLaunch 
    {
        private string FindExePath(string exe)
        {
            return Path.GetFullPath(exe);
        }

        public string RunAs(string ApplicationName)
        {
            /*switch (ApplicationName)
            {
                case "SSIS":
                    Process.Start(this.FindExePath(ApplicationName), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    break;
                case "SSMS":
                    Process.Start(this.FindExePath(ApplicationName), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    break;
                case "DataCompare":
                    Process.Start(this.FindExePath(ApplicationName), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    break;
                case "All":
                    Process.Start(this.FindExePath(""), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    Process.Start(this.FindExePath(""), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    Process.Start(this.FindExePath(""), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    break;
                case "CmdPrompt":
                    Process.Start(this.FindExePath(""), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    break;
                case "RemoteServerConnection":
                    Process.Start(this.FindExePath(""), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
                    break;
            }*/
            Process.Start(this.FindExePath(ApplicationName), Login.UserName, Login.LoginSecureString, Environment.UserDomainName);
            return "You have Sucessfully Started An Application with your account";
        }
        


    }
}
