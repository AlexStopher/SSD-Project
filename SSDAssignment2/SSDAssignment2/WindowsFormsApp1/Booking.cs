using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            //Take information from the combo boxes and store it in strings. This will then be used to check against the database 
            //To see if the booking can be made or not

            string Platform = comboBox1.GetItemText(comboBox1.SelectedItem);
            string TimeLength = comboBox2.GetItemText(comboBox2.SelectedItem);
            string Software = comboBox3.GetItemText(comboBox3.SelectedItem);
            string NoOfPeople = NoOfPeopleComboBox.GetItemText(NoOfPeopleComboBox.SelectedItem);

            DateTime Date = monthCalendar1.SelectionStart;
            string Time = TimeBox.GetItemText(TimeBox.SelectedItem);



            //Code for button on click event
            //This is where the values stored in the date picker will be used to push through to the data base

            /*
            If - datepicker date != database values
                add to database
                confirm success

            else
                Send message to user that dates are unavailable
                    Maybe suggest closest date available?
            */


            //If successful
            if (Platform != "" && TimeLength != "" && Time != "" && Software != "" && NoOfPeople != "")
            {
                bool IsDuplicate = false;

                for(int i = 0; i < dataGridView2.RowCount - 1; i++)
                {                

                    if (Time == dataGridView2.Rows[i].Cells[3].Value.ToString())
                    {
                        IsDuplicate = true;
                    }
                }

                if (IsDuplicate == false)
                {
                    dataGridView2.Rows.Insert(dataGridView2.RowCount - 1, Platform, TimeLength, Date.ToShortDateString(), Time, Software, NoOfPeople);
                    MessageBox.Show("Booking has been made!", "Booking check", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Duplicate booking, choose another time.", "Booking check", MessageBoxButtons.OK);
            }

        }

        //to be deleted
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void CheckBookingsButton_Click_1(object sender, EventArgs e)
        {
            //if pressed etc. 

            //Use data taken from the dates to show all bookings 

            dataGridView1.Visible = true;
        }

        //To delete
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoOfPeopleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
