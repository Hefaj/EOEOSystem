using System.Windows.Controls;
using System.Windows.Media;

namespace EOEOSystem.CustomControl
{
    /// <summary>
    /// Interaction logic for IconTitlePasswordBox.xaml
    /// </summary>
    public partial class IconTitlePasswordBox : UserControl
    {
        public ImageSource Source { set { loginImg.Source = value; } }
        public string Title { get; set; }
        public string Password => passwordTb.Password;
        public IconTitlePasswordBox()
        {
            InitializeComponent();
        }
    }
}
