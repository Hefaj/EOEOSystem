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
            var password = passwordTb.Text;

            //UserController.AddUser(
            //    "rwojcik",
            //    "1234",
            //    "Rafał",
            //    "Wójcik",
            //    Role.Operator
            //    );

            var user = UserController.GetUser(login, password);

            // jezeli sie powiedzie to otwiera main window
            var mainScreen = new MainScreen();
            mainScreen.Show();
            this.Close();
        }
    }
}
