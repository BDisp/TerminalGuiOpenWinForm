using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;
using System.Windows.Forms;

namespace TerminalGuiOpenWinForm
{
    class Program : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            Terminal.Gui.Application.Init();
            //Terminal.Gui.Application.Run();

            Terminal.Gui.Application.Run(new LoginWindow());
            //System.Console.WriteLine($"Username: {((LoginWindow)Terminal.Gui.Application.Top).usernameText.Text}");

            // Before the application exits, reset Terminal.Gui for clean shutdown
            Terminal.Gui.Application.Shutdown();
        }
    }

}