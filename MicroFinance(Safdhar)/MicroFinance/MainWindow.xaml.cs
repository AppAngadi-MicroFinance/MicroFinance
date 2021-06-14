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
using MicroFinance.Models;

namespace MicroFinance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string LoginDesignation;

       public static StaticProperty StatusMsg = new StaticProperty();

        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new Uri("AddCustomer.xaml", UriKind.Relative));
            MessageStatus.DataContext = StatusMsg;
        }

        public static void StatusMessageofPage(int Type,string Message)
        {
            StatusMsg.MessageType = Type;
            StatusMsg.StatusMessage = Message;
        }
    }
}
