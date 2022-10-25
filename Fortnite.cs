using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectCLauncher
{
    class Fortnite
    {

        public static void StartFortnite()
        {
            var GamePath = ProjectCLauncher.Account.Path;
            var Email = ProjectCLauncher.Account.Email;
            var Password = ProjectCLauncher.Account.Password;

            if (ProjectCLauncher.Account.OldLaunch == true)
            {
                Process process4 = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        Arguments = "node index.js pause"
                    }
                };
                process4.Start();


                Process process2 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                Process process3 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + ProjectCLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + ProjectCLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                process3.WaitForInputIdle();
                process3.WaitForExit();
                process2.Close();
                process3.Close();
                ProjectCLauncher.Account.OldLaunch = false;


            }
            else if (ProjectCLauncher.Account.bCustomFLToken == true)
            {


                Process process = ProcessHelper.StartCustomProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
                Process process2 = ProcessHelper.StartCustomProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                Process process4 = ProcessHelper.StartCustomProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
                Process process3 = ProcessHelper.StartCustomProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + ProjectCLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + ProjectCLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                process3.WaitForInputIdle();
                ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AuroraLatestRedirect.dll"));
                process3.WaitForExit();
                process.Close();
                process2.Close();
                process3.Close();
                process4.Close();
            
            }
            else if (ProjectCLauncher.Account.NewVerSupport == true)
            {
               
                
                    Process process = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
                    Process process2 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                    Process process4 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
                    Process process3 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + ProjectCLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + ProjectCLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                    process3.WaitForInputIdle();
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AuroraLatestRedirect.dll"));
                    process3.WaitForExit();
                    process.Close();
                    process2.Close();
                    process3.Close();
                    process4.Close();
                
            }
            else
            {
                Process process = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
                Process process2 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                Process process4 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
                Process process3 = ProcessHelper.StartProcess(ProjectCLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + ProjectCLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + ProjectCLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                process3.WaitForInputIdle();
                ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ProjectCLauncher.Account.RedirectDLL));
                if (ProjectCLauncher.Account.bisSinglePlayer == true)
                {
                   
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ProjectCLauncher.Account.SinglePlayerDLL));
                }
                else
                {
                    
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ProjectCLauncher.Account.MultiplayerDLL));
                }
                process3.WaitForExit();
                process.Close();
                process2.Close();
                process3.Close();
                process4.Close();
            }
        }
    }
}
