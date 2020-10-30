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

namespace EF_DBFIRST_WPFDEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            PRAC_DB1Entities dbCon = new PRAC_DB1Entities();
            student d1 = new student();
            string kajol = null;
            d1.firstName = kajol;
            d1.lastNmae = "Sharma";
            


            dbCon.students.Add(d1);
            
        }
    }
}
