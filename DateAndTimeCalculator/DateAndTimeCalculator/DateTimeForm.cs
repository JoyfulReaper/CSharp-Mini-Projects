using System;
using System.Media;
using System.Windows.Forms;

namespace DateAndTimeCalculator
{
    public partial class DateTimeForm : Form
    {
        DateTime TargetDate;
        public DateTimeForm()
        {
            InitializeComponent();
            TimerSecond_Tick(this, EventArgs.Empty);
        }

        private void TimerSecond_Tick(object sender, EventArgs e)
        {
            double diff = (DateTime.Now.Subtract(TargetDate)).TotalMilliseconds;
            //Console.WriteLine($"hit: {DateTime.Now} Diff: {diff}");

            lblCurrentContent.Text = $"{DateTime.Now}";
            lblSelectedContent.Text = $"{dateTimePicker1.Value}";

            if (chkAlert.Checked && diff >= 0 && diff <= 1000)
            {
                MessageBox.Show("The time you selected has past!");
            }
        }

        private void btnSetToCurrent_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime outputDate = dateTimePicker1.Value;
            int multipler = 1;
            if(radioSubtract.Checked)
            {
                multipler = -1;
            }

            outputDate = outputDate.AddSeconds((double)numericSeconds.Value * multipler);
            outputDate = outputDate.AddMinutes((double)numericMinutes.Value * multipler);
            outputDate = outputDate.AddHours((double)numericHours.Value * multipler);
            outputDate = outputDate.AddDays((double)numericDays.Value * multipler);
            outputDate = outputDate.AddMonths((int)numericMonths.Value * multipler);
            outputDate = outputDate.AddYears((int)numericYears.Value * multipler);

            TargetDate = outputDate;

            lblResultDate.Text = outputDate.ToString();
            lblResultDate.Visible = true;
        }
    }
}
