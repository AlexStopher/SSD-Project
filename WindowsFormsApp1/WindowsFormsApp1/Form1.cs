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
    public partial class Form1 : Form
    {
        public Form1()
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

            //This will be changed to a message box later, simply is being used to show that the date saved was successful
            BookingComfirmationLabel.Visible = true;            
        }

        //to be deleted
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BookingComfirmationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
