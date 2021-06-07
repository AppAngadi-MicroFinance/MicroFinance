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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using MicroFinance.Modal;

namespace MicroFinance
{
    /// <summary>
    /// Interaction logic for AddRegion.xaml
    /// </summary>
    public partial class AddRegion : Window
    {
        Region region = new Region();
        public AddRegion()
        {
            InitializeComponent();
            RegionMainGrid.DataContext = region;
        }

        private void RegionSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            region.AddRegion();
            this.Close();
            MainWindow.StatusMessageofPage(0, "Region Addeed Successfully");
        }
    }
}
