using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EOEOSystem.CustomControl
{
    /// <summary>
    /// Interaction logic for IconTitleTextBox.xaml
    /// </summary>
    /// 
    public partial class IconTitleTextBox : UserControl
    {
        public ImageSource Source {  set { loginImg.Source = value; } }
        public string Title { get; set; }
        public string Text => loginTb.Text;

        public IconTitleTextBox()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
