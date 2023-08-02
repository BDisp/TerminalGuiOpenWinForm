using Terminal.Gui;

namespace TerminalGuiOpenWinForm
{
    public class LoginWindow : Window
    {

        public TextField usernameText;


        public LoginWindow()
        {


            Title = "Login to COY Console (Ctrl+Q to quit)";

            // Create input components and labels
            var usernameLabel = new Label()
            {
                Text = "Username:"
            };

            usernameText = new TextField()
            {
                // Position text field adjacent to the label
                X = Pos.Right(usernameLabel) + 1,

                // Fill remaining horizontal space
                Width = Dim.Fill(),
            };

            var passwordLabel = new Label()
            {
                Text = "Password:",
                X = Pos.Left(usernameLabel),
                Y = Pos.Bottom(usernameLabel) + 1
            };

            var passwordText = new TextField()
            {
                Secret = true,
                // align with the text box above
                X = Pos.Left(usernameText),
                Y = Pos.Top(passwordLabel),
                Width = Dim.Fill(),
            };

            // Create login button
            var btnLogin = new Button()
            {
                Text = "Login",
                Y = Pos.Bottom(passwordLabel) + 1,
                // center the login button horizontally
                X = Pos.Center(),
                IsDefault = true,
            };

            // When login button is clicked display a message popup then Windows Form
            btnLogin.Clicked += () => {
                if (usernameText.Text == "admin" && passwordText.Text == "password")
                {
                    MessageBox.Query("Logging In", "Login Successful", "Ok");
                    Application.RequestStop();

                    Program._loggedIn = true;
                }
                else
                {
                    MessageBox.ErrorQuery("Logging In", "Incorrect username or password", "Ok");
                }

                Application.Top.Clear();
            };



            // Add the views to the Window
            Add(usernameLabel, usernameText, passwordLabel, passwordText, btnLogin);

        }
    }
}
