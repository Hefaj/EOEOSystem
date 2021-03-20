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
            var a = passwordTb.Text;
            var b = loginTb.Text;


            // jezeli sie powiedzie to otwiera main window
            var mainScreen = new MainScreen();
            mainScreen.Show();
            this.Close();
        }
    }
}
