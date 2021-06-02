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
using MicroFinance.Modal;
using System.Data;
using System.Data.SqlClient;

namespace MicroFinance
{
    /// <summary>
    /// Interaction logic for ModifyEmployee.xaml
    /// </summary>
    public partial class ModifyEmployee : Page
    {
        public string ConnectionString = MicroFinance.Properties.Settings.Default.DBConnection;
        List<dummyemployee> employeelist = new List<dummyemployee> ();
        public ModifyEmployee()
        {
            InitializeComponent();
           // Employeelist.ItemsSource = AddEmployee.EmployeesList;
            employeelist.Add(new dummyemployee { employeeid = "101", employeename = "Ashraf" });
            employeelist.Add(new dummyemployee { employeeid = "102", employeename = "Safdhar" });
            employeelist.Add(new dummyemployee { employeeid = "103", employeename = "Ashraf" });
        }

        private void searchbntn_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(serachtxt.Text))
            {
                Employeelist.Items.Clear();
                ResultedEmployee(serachtxt.Text);
            }
            else
            {
                MessageBox.Show("Please Enter the Name");
            }

        }


        public void ResultedEmployee(string name)
        {
            foreach(var v in AddEmployee.EmployeesList)
            {
                if(v.EmployeeName!="")
                {
                    if ((v.EmployeeName).StartsWith(serachtxt.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Employeelist.Items.Add(v);
                    }
                }
                
            }
           
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = Employeelist.SelectedItem as Employee;
            this.NavigationService.Navigate(new AddEmployee(employee));
            //dummyemployee dummyemp =Employeelist.SelectedItem as dummyemployee;
            //editpanel.IsOpen = true;
            //Editemp.DataContext = dummyemp;
            //MessageBox.Show(dummyemployee.ToString());
        }

        private void serachtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Employeelist.Items.Clear();
            ResultedEmployee(serachtxt.Text);
        }

        private void Employeelist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee employee = Employeelist.SelectedItem as Employee;
            this.NavigationService.Navigate(new AddEmployee(employee));
        }

        private void regionsavebtn_Click(object sender, RoutedEventArgs e)
        {
            using(SqlConnection sqlconn=new SqlConnection(ConnectionString))
            {
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlconn;
                sqlcomm.CommandText = "insert into Region (RegionName)values('"+Regionnamebox.Text+"')";
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }
            AddregionPanel.IsOpen = false;
            MessageBox.Show("Success");
        }

        public void getregionlist()
        {

        }
        private void Addregionbtn_Click(object sender, RoutedEventArgs e)
        {
            AddregionPanel.IsOpen = true;
            Regionnamebox.Text = "";
        }
    }

    public class dummyemployee
    {
        public string employeeid { get; set; }
        public string employeename { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0}  |  Name : {1}", employeeid, employeename);
      
        }
    }
}
