using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//including other projects for access to namespaces
using EmployeeEnd;
using HardwareSoftwareBrowsing;
using WindowsFormsApp1;


namespace WireFrame
{
    public partial class Form1 : Form
    {
        //Class members
        
        protected static EmployeeForm m_EmployeeInfo = new EmployeeForm();
        protected static HardSoftForm m_ViewCurrentStock = new HardSoftForm();
        protected static Booking m_Bookings = new Booking();

        bool _signedIn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBookingButton_Click(object sender, EventArgs e)
        {
            if (_signedIn)
            {
                //Take information from the combo boxes and store it in strings. This will then be used to check against the database 
                //To see if the booking can be made or not
                string Platform = PlatformCombobox.GetItemText(PlatformCombobox.SelectedItem);
                string TimeLength = comboBox2.GetItemText(comboBox2.SelectedItem);
                string Software = comboBox3.GetItemText(comboBox3.SelectedItem);
                string NoOfPeople = NoOfPeopleComboBox.GetItemText(NoOfPeopleComboBox.SelectedItem);
                string Time = TimeBox.GetItemText(TimeBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please sign in to quick book", "Quick book", MessageBoxButtons.OK);
            }
        }

        private void CheckBookingsButton_Click(object sender, EventArgs e)
        {  
            m_Bookings.ShowDialog();
        }

        private void HardwareSoftwareButton_Click(object sender, EventArgs e)
        {      
           m_ViewCurrentStock.ShowDialog();
        }

        private void EmployeeInfoButton_Click(object sender, EventArgs e)
        {
            //Press yes to access the employee info, will add proper authentication later on
            if(MessageBox.Show("Placeholder", "Placeholder", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {        
                m_EmployeeInfo.ShowDialog();
            }           
        }
    }
}