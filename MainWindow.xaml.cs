using MySqlConnector;
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

namespace WPFCRUDOperations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DDBBConnection connectionObj = new DDBBConnection();
        MySqlConnection conn;
        public MainWindow()
        {
            InitializeComponent();
        }

        /*  When users clicks LOG IN btn fires this method.
         *  Checks if txtBox and Pass are filled
         *  If so, tries to set a connection to the SQL DDBB
         * 
         */
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxUser.Text != "" && passBox.Password! != "")
            {
                conn = connectionObj.Connect(txtBoxUser.Text, passBox.Password);
            }
        }
    }
}
