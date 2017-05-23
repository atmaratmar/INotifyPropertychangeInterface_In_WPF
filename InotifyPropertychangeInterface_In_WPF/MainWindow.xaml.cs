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

namespace InotifyPropertychangeInterface_In_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //to access object of person class we will have person property 
        public Person objperson { get; set; } /*then in the costractor of this window*/
        public MainWindow()
        {
            InitializeComponent();
            objperson = new Person { _FirstName = "Atmar", _LastName = "kohistany" };
            this.DataContext = objperson;
        }
    }
}
