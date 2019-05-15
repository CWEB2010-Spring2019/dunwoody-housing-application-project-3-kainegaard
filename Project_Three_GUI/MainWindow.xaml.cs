using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Project_Three_GUI
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

        Window1 registration = new Window1();
        Welcome welcome = new Welcome();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if ((textBoxUsername.Text == "home") && (passwordBox1.Text == "1234"))
            {
                Welcome welcomeView = new Welcome();
                welcomeView.Show();
                this.Close();
            }
            else {
                textBoxUsername.Text = "";
                passwordBox1.Text = "";

                MessageBox.Show("Sorry, Invalid Credentials try again");
                //errormessage.Text = "Enter a valid username.";
                //textBoxUsername.Select(0, textBoxUsername.Text.Length);
                //textBoxUsername.Focus();
            }
            //else
            //{
            //    string username = textBoxUsername.Text;
            //    string password = passwordBox1.Password;
            //    SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=home;Password=1234");
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("Select * from Registration where Username='" + username + "'  and password='" + password + "'", con);
            //    cmd.CommandType = CommandType.Text;
            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    adapter.SelectCommand = cmd;
            //    DataSet dataSet = new DataSet();
            //    adapter.Fill(dataSet);
            //    if (dataSet.Tables[0].Rows.Count > 0)
            //    {
            //        string username1 = dataSet.Tables[0].Rows[0]["FirstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["LastName"].ToString();
            //        welcome.TextBlockName.Text = username1;//Sending value from one form to another form.  
            //        welcome.Show();
            //        Close();
            //    }
            //    else
            //    {
            //        errormessage.Text = "Sorry! Please enter existing emailid/password.";
            //    }
            //    con.Close();
            //}
        }
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    }
}