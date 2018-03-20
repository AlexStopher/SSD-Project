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
using CalendarUI;
using HardwareSoftwareBrowsing;
using GameCafeLibrary;

namespace WireFrame
{
    public partial class Form1 : Form
    {
        //Class members
        
        protected static EmployeeForm m_EmployeeInfo = new EmployeeForm();
        protected static HardSoftForm m_ViewCurrentStock = new HardSoftForm();
        protected static CalendarForm m_Bookings = new CalendarForm();

        public Form1()
        {
            InitializeComponent();
          
        }

        private void SubmitBooking_Click(object sender, EventArgs e)
        {
          

            //Take information from the combo boxes and store it in strings. This will then be used to check against the database 
            //To see if the booking can be made or not

            string Platform = PlatformCombobox.GetItemText(PlatformCombobox.SelectedItem);
            string TimeLength = comboBox2.GetItemText(comboBox2.SelectedItem);
            string Software = comboBox3.GetItemText(comboBox3.SelectedItem);
            string NoOfPeople = NoOfPeopleComboBox.GetItemText(NoOfPeopleComboBox.SelectedItem); 
            string Time = TimeBox.GetItemText(TimeBox.SelectedItem);



         
            //This is where the values stored in the date picker will be used to push through to the data base,
            //Below includes a simple check to ensure that the information is filled before sending and a check
            //to ensure double bookings dont happen (Needs to be updated)

            //If successful
        //    if (Platform != "" && TimeLength != "" && Time != "" && Software != "" && NoOfPeople != "")
        //    {
        //        bool IsDuplicate = false;

        //        for (int i = 0; i < dataGridView2.RowCount - 1; i++)
        //        {

        //            if (Time == dataGridView2.Rows[i].Cells[3].Value.ToString())
        //            {
        //                IsDuplicate = true;
        //            }
        //        }

        //        //Add code to check if member here or not , maybe make into a switch using time data
        //        if (IsDuplicate == false && TimeLength == "1 Hour")
        //        {

        //            if (MessageBox.Show("Booking will cost £1.50", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //            {
        //                dataGridView2.Rows.Insert(dataGridView2.RowCount - 1, Platform, TimeLength, Date.ToShortDateString(), Time, Software, NoOfPeople);
        //            }
        //            else
        //            {

        //            }
        //        }
        //        else if (IsDuplicate == false && TimeLength == "2 Hours")
        //        {
        //            if (MessageBox.Show("Booking will cost £2.50", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //            {
        //                dataGridView2.Rows.Insert(dataGridView2.RowCount - 1, Platform, TimeLength, Date.ToShortDateString(), Time, Software, NoOfPeople);
        //            }
        //            else
        //            {

        //            }
        //        }
        //        else if (IsDuplicate == false && TimeLength == "5 Hours")
        //        {
        //            if (MessageBox.Show("Booking will cost £4.00", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //            {
        //                dataGridView2.Rows.Insert(dataGridView2.RowCount - 1, Platform, TimeLength, Date.ToShortDateString(), Time, Software, NoOfPeople);
        //            }
        //            else
        //            {

        //            }
        //        }

        //        //if (IsDuplicate == false)
        //        //{
        //        //    dataGridView2.Rows.Insert(dataGridView2.RowCount - 1, Platform, TimeLength, Date.ToShortDateString(), Time, Software, NoOfPeople);
        //        //    MessageBox.Show("Booking has been made!", "Booking check", MessageBoxButtons.OK);
        //        //}
        //        //else
        //        //    MessageBox.Show("Duplicate booking, choose another time.", "Booking check", MessageBoxButtons.OK);
        //    }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("[ENTER COPYRIGHT INFO HERE]");
            //this.Show();
        }

        private void CheckBookingsButton_Click(object sender, EventArgs e)
        {  
            m_Bookings.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {      
           m_ViewCurrentStock.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Press yes to access the employee info, will add proper authentication later on
            if(MessageBox.Show("Placeholder", "Placeholder", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {        
                m_EmployeeInfo.ShowDialog();
            }           
        }
    }
}