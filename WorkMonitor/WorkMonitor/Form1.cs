using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace WorkMonitor
{
    public partial class MainForm : Form
    {
        public HoursWorked schedule;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(this.HoursForDateButton, "Gets for the week from given date.\n" + 
                "Uses the date field.");
            myToolTip.SetToolTip(this.AddButton, "Adds date, clockin, clockout, and\nlunchbreak (in " +
                "minutes) to the list of records.");
            myToolTip.SetToolTip(this.LunchBreakMin, "Lunch break (in minutes.)");
            schedule = new HoursWorked("hours.etxt", HoursWorked.MONSUN);
            this.UpdateGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DatePicker.Value;
                String clockIn = clockInTime.Text.ToString();
                String clockOut = clockOutTime.Text.ToString();
                Int32 lunchBreak = 0;
                if(LunchBreakMin.Text != "")
                {
                    lunchBreak = Convert.ToInt32(LunchBreakMin.Text);
                }
                schedule.Add(date, clockIn, clockOut, lunchBreak);
                this.UpdateGrid();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }

        private void UpdateGrid()
        {
            HoursWorkedLabel.Text = schedule.GetHoursForThisWeek().ToString("F2");
            HoursLastWeekLabel.Text = schedule.GetHoursForLastWeek().ToString("F2");
            dataGridView1.DataSource = schedule.GetDataTable();              
        }

        private void HoursForDateButton_Click(object sender, EventArgs e)
        {
            String text = "The hours worked for the week involving ";
            text += DatePicker.Value.ToString("MM/dd/yyyy");
            text += " is: ";
            text += schedule.GetHoursForWeek(DatePicker.Value).ToString("F2");
            text += " hours.";
            MessageBox.Show(text, "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
