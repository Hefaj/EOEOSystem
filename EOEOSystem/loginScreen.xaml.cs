using EOEOSystem.Controller;
using System.Windows;

namespace EOEOSystem
{
    public partial class loginScreen : Window
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            // walidacja danych
            var login = loginTb.Text;
            var password = passwordTb.Password;

            //UserController.AddUser(
            //    "rwojcik",
            //    "1234",
            //    "Rafał",
            //    "Wójcik",
            //    Role.Operator
            //    );

            var user = UserController.GetUser(login, password);

            if (user is null)
            {
                MessageBox.Show("Nie udało się zalogować!");
            }
            else
            {
                MessageBox.Show($"Witaj {user.Name}, Twój login to {user.Login}.");
            }

            // jezeli sie powiedzie to otwiera main window
            //var mainScreen = new MainScreen();
            //mainScreen.Show();
            //this.Close();
        }

        private void loginTb_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }
    }
}
