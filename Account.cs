using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectCLauncher
{
    class Account
    {
        
        public static string Email = "";
        public static string Password = "";
        public static string Path = "";

      
        public static bool bisSinglePlayer = false;
        public static bool bCustomFLToken = false; 

        
        public static bool OldLaunch = false; 
        public static bool NewVerSupport = false; 


        
        public static string RedirectDLL = "";
        public static string MultiplayerDLL = "";
        public static string SinglePlayerDLL = "";

    
        public static string DefaultFLToken = "87a0c99d9aa3ab5bb6a36C25"; 

        
        public static string CustomFLToken = ""; 
    }
}