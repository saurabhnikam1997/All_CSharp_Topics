using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiThreadingWPF
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        UserControl1 userControl1 = new UserControl1();
        public UserControl2()
        {
            InitializeComponent();
            userControl1.MyTextChanged += UserControl1_MyTextChanged;
        }

        private void UserControl1_MyTextChanged(object sender, string newText)
        {
            // Handle the event and respond accordingly
        }
    }
}
