using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace WorkMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public class HoursWorked
    {
        //public class veriables
        public static String MONSUN = "MondaySunday";
        public static String SUNSAT = "SundaySaturday";
        public String saveFile;

        //private class variables
        private String workWeek;
        private Dictionary<String, String[]> records;

        //class constuctors
        public HoursWorked()
        {
            this.workWeek = "";
            this.records = new Dictionary<String, String[]> { };
            this.saveFile = "hours.etxt";
        }
        public HoursWorked(String fileName)
        {
            this.workWeek = "";
            this.records = new Dictionary<String, String[]> { };
            this.saveFile = fileName;
        }
        public HoursWorked(String fileName, String workWeek)
        {
            this.workWeek = workWeek;
            this.records = new Dictionary<String, String[]> { };
            this.saveFile = fileName;
            this.GetInfo();
        }

        //This function will set the work week to a valid work week.
        public void SetWorkWeek(String week)
        {
            if (week == MONSUN || week == SUNSAT)
            {
                this.workWeek = week;
            }
            else
            {
                MessageBox.Show("Invalid work week.");
            }
        }

        //This function will return a Dictionary of records
        public Dictionary<String, String[]> GetRecords()
        {
            return this.records;
        }

        //function to get info from file
        private void GetInfo()
        {
            try{
                String line;
                StreamReader file = new StreamReader(this.saveFile);
                while ((line = file.ReadLine()) != null)
                {
                    String[] words = line.Split('^');
                    String date = words[0];
                    words = words.Skip(1).ToArray();
                    this.records[date] = words.ToArray();
                }

                file.Close();
            }
            catch (FileNotFoundException e)
            {
                //ignore missing file
            }            
        }

        //function to save info to file
        private void Save()
        {
            //overwrite old file
            StreamWriter file = new StreamWriter(this.saveFile);
            file.Write("");
            file.Close();

            //add each item in the dicitionary to the file
            foreach (KeyValuePair<String,String[]> entry in this.records)
            {
                String line = entry.Key;
                Array items = entry.Value;
                foreach(var item in items)
                {
                    line += "^" + item.ToString();
                }
                line += Environment.NewLine;
                File.AppendAllText(this.saveFile, line);
            }
        }

        //funciton to add a record with date, in, out, and lunch breaks
        public void Add(DateTime date, String clockIn, String clockOut, Int32 lunch)
        {
            try
            {
                String mydate = date.ToString("MM/dd/yyyy");
                String[] data = { clockIn, clockOut, lunch.ToString() };
                this.records[mydate] = data;
                this.Save();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        //This function returns a data table of all of the entrys in this objects records.
        //Used for dispaly in data grads.
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            //add columns to datatable
            dt.Columns.Add("Date");
            dt.Columns.Add("Clock In");
            dt.Columns.Add("Clock Out");
            dt.Columns.Add("Lunch Break");           
            
            //add each element of records as a new row to datatable
            foreach (KeyValuePair<String, String[]> entry in this.records)
            {
                object[] arr = (object[])entry.Value;
                String[] myArr = Array.ConvertAll<object, String>(arr, Convert.ToString);
                String clockIn = myArr[0];
                String clockOut = myArr[1];
                String lunchBreak = myArr[2];
                String[] data = { entry.Key, clockIn, clockOut, lunchBreak };
                dt.Rows.Add(data);
            }

            //create new view to sort the datatable 
            DataView view = dt.DefaultView;
            view.Sort = "Date DESC";
            DataTable sorted = view.ToTable();

            return sorted;
        }

        //This fucntion returns the hours worked for this week.
        public Double GetHoursForThisWeek()
        {
            return this.CalculateHours(DateTime.Today);
        }

        //This fucntion returns the hours worked for last week.
        public Double GetHoursForLastWeek()
        {
            return this.CalculateHours(DateTime.Today.AddDays(-7));
        }

        //This function returns the hours worked for the week involving the given date.
        public Double GetHoursForWeek(DateTime date)
        {
            return this.CalculateHours(date);
        }

        //This function will return the the number of hours worked during the week of the given date
        private Double CalculateHours(DateTime date)
        {
            Double hours = 0;
            Int32 numOfDaysThisWeek = 6;

            //calculate hours based on the work week of monday through sunday
            if (this.workWeek == HoursWorked.MONSUN)
            {
                Int32 offset = date.DayOfWeek - DayOfWeek.Monday;
                DateTime lastMonday = date.AddDays(-offset);
                DateTime nextSunday = lastMonday.AddDays(6);
                DateTime now = lastMonday;
                //check to see if now is in records and if so adjust hours accordingly 
                for (int i = numOfDaysThisWeek; i >= 0; i--)
                {
                    if (this.records.ContainsKey(now.Date.ToString("MM/dd/yyyy")))
                    {
                        String[] values = this.records[now.Date.ToString("MM/dd/yyyy")];
                        DateTime clockIn = Convert.ToDateTime(values[0]);
                        DateTime clockOut = Convert.ToDateTime(values[1]);
                        TimeSpan duration = clockOut.Subtract(clockIn);
                        Int32 lunchBreak = Convert.ToInt32(values[2]);

                        duration -= TimeSpan.FromMinutes(lunchBreak);
                        hours += duration.TotalHours;
                    }
                    now = now.AddDays(1);
                }
            //calculate hours based on the work week of sunday through saturday
            }
            else if (this.workWeek == HoursWorked.SUNSAT)
            {
                Int32 offset = date.DayOfWeek - DayOfWeek.Sunday;
                DateTime lastSunday = date.AddDays(-offset);
                DateTime nextSaturday = lastSunday.AddDays(6);
                DateTime now = lastSunday;
                //check to see if nos is in records and if so adjust hours accordingly 
                for (int i = numOfDaysThisWeek; i >= 0; i--)
                {
                    if (this.records.ContainsKey(now.Date.ToString("MM/dd/yyyy")))
                    {
                        String[] values = this.records[now.Date.ToString("MM/dd/yyyy")];
                        DateTime clockIn = Convert.ToDateTime(values[0]);
                        DateTime clockOut = Convert.ToDateTime(values[1]);
                        TimeSpan duration = clockOut.Subtract(clockIn);
                        Int32 lunchBreak = Convert.ToInt32(values[2]);

                        duration -= TimeSpan.FromMinutes(lunchBreak);
                        hours += duration.TotalHours;
                    }
                    now = now.AddDays(1);
                }
            }
            return hours;
        }
    }
}
