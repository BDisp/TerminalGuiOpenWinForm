using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TerminalGuiOpenWinForm
{
    public static class Program
    {
        public static bool _loggedIn;

        static void Main(string[] args)
        {
            Terminal.Gui.Application.Init();
            //Terminal.Gui.Application.Run();

            Terminal.Gui.Application.Run(new LoginWindow());
            //System.Console.WriteLine($"Username: {((LoginWindow)Terminal.Gui.Application.Top).usernameText.Text}");

            // Before the application exits, reset Terminal.Gui for clean shutdown
            Terminal.Gui.Application.Shutdown();

            if (_loggedIn)
            {
                var folderSep = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? @"\" : "/";
                ProcessStartInfo info = new ProcessStartInfo()
                {
                    FileName = $"..{folderSep}..{folderSep}..{folderSep}..{folderSep}WinFormsApp1{folderSep}bin{folderSep}Debug{folderSep}net6.0-windows{folderSep}WinFormsApp1.exe",
                    UseShellExecute = true,

                };
                Process.Start(info);

                Task.Delay(1000).Wait();
            }
        }
    }

}