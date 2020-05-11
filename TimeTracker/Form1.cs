using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        private List<DateTimeOffset> dateTimes_Work = new List<DateTimeOffset>();
        private List<DateTimeOffset> dateTimes_Break = new List<DateTimeOffset>();
        private List<int> flags_Work = new List<int>();
        private List<int> flags_Break = new List<int>();
        private bool CanAddTime = false;

        public Form1()
        {
            InitializeComponent();
            UpdateTime(false);
        }

        private void button_AddTime_Click(object sender, EventArgs e)
        {
            UpdateTime(true);
            CanAddTime = false;
            button_AddTime.Enabled = CanAddTime;

            if (textBox_Time.Text == "")
            {
                textBox_Time.ForeColor = SystemColors.ActiveBorder;
                textBox_Time.Text = "13:00";
            }

            //set the active control to null to ensure nothing is selected
            ActiveControl = null;
            ActiveControl = textBox_Time;
        }

        private void ListBox_Work_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = sender as ListBox;

            if (e.Index == -1)
                return;

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush textBrush = Brushes.Black;

            if (flags_Work.AsParallel().Contains(e.Index))
            {
                //set the text for a flagged item
                //textBrush = Brushes.Red;

                //set the background for a flagged item
                Brush brush = new SolidBrush(Color.FromArgb(128, 128, 255, 128));
                e.Graphics.FillRectangle(brush, (sender as ListBox).GetItemRectangle(e.Index));
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            e.Graphics.DrawString(listBox_Work.Items[e.Index].ToString(),
                e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        private void ListBox_KeyUp(object sender, KeyEventArgs e)
        {
            var listBox = sender as ListBox;
            if (e.KeyCode == Keys.Delete && listBox.SelectedIndex >= 0)
            {
                if (listBox.Name.ToLower().Contains("break"))
                    dateTimes_Break.RemoveAt(listBox.SelectedIndex);
                else if (listBox.Name.ToLower().Contains("work"))
                    dateTimes_Work.RemoveAt(listBox.SelectedIndex);

                listBox.Items.RemoveAt(listBox.SelectedIndex);

                UpdateTime(false);
            }
            else if (e.KeyCode == Keys.Space && listBox.SelectedIndex >= 0)
            {
                FlagItem();
            }
        }
        private void TextBox_Time_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ActiveControl = null;
                UpdateTime(false);
            }
        }
        private void TextBox_Time_Enter(object sender, EventArgs e)
        {
            CanAddTime = true;
            button_AddTime.Enabled = CanAddTime;

            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor == SystemColors.ActiveBorder)
            {
                textBox.Clear();
                textBox.ForeColor = SystemColors.WindowText;
            }

        }
        private void TextBox_Time_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.ForeColor = SystemColors.ActiveBorder;
                textBox.Text = "13:00";

                CanAddTime = false;
                button_AddTime.Enabled = CanAddTime;
            }
        }

        private void Button_Flag_Click(object sender, EventArgs e)
        {
            FlagItem();
        }
        private void Button_ClearFlag_Click(object sender, EventArgs e)
        {
            flags_Work.Clear();
            //invalidate list boxes
            listBox_Work.Invalidate();
            listBox_Break.Invalidate();
        }

        private void UpdateTime(bool isNewTime)
        {
            if (isNewTime)
                AddTime(textBox_Time, checkBox_Break);

            //calculate the time worked/on break
            var workTotal = 0.0;
            for (int i = 1; i < dateTimes_Work.Count; i++)
            {
                var diff = (dateTimes_Work[i] - dateTimes_Work[i - 1]).TotalMinutes;
                workTotal += diff;
            }
            var breakTotal = 0.0;
            //for (int i = 1; i < dateTimes_Break.Count; i++)
            //{
            //    var diff = (dateTimes_Break[i] - dateTimes_Break[i - 1]).TotalMinutes;
            //    breakTotal += diff;
            //}

            var total = workTotal - breakTotal;

            var minutes = (total % 60).ToString();
            if (minutes.Length > 4)
                minutes = minutes.Substring(0, 4);
            var hours = (total / 60).ToString().Split('.')[0];
            textBox_Total.Text = $"{hours}h {minutes}m";

            //30 minutes of paid lunch every 7 hours worked
            var lunchMinutes = double.Parse(hours) * (30 / 7) +
                (double.Parse(minutes) / 60) * (30 / 7);

            textBox_LunchTotal.Text = $"{Math.Round(lunchMinutes, 1)}m";
        }
        private void AddTime(Control inputTextBox, Control inputCheckBox)
        {
            TextBox textBox = inputTextBox as TextBox;
            CheckBox checkBox = inputCheckBox as CheckBox;

            int tbLength = textBox.Text.Split(':').Length;
            string outputText = "";

            //ensure the time has a : or a value
            if (tbLength > 0)
            {
                var time = textBox_Time.Text.Split(':');

                //if the hour can't be parsed then exit prematurely
                //HOUR
                double hour = 0.0;
                if (tbLength > 0 && !double.TryParse(time[0], out hour))
                    return;
                if (radioButton_PM.Checked && hour < 12)
                    hour += 12;

                //MINUTE
                double min = 0.00;
                if (tbLength > 1)
                    double.TryParse(time[1], out min);

                //conditional minute, add an extra 0 or not
                string condMin = min.ToString().Length > 1 ? min.ToString() : min.ToString() + "0";
                outputText = $"{hour}:{condMin}";


                //list structured { List<DateTimeOffset>, Control<ListBox> }
                object[] targetList = new object[] { dateTimes_Work, listBox_Work };
                if (checkBox.Checked)
                    targetList = new object[] { dateTimes_Break, listBox_Break };

                //add to internal structures
                (targetList[0] as List<DateTimeOffset>).Add(new DateTimeOffset()
                    .AddHours(hour)
                    .AddMinutes(min));
                //reset UI
                textBox.Clear();
                //update UI
                (targetList[1] as ListBox).Items.Add(outputText);
            }
        }
        private void FlagItem() 
        {
            ListBox selectedListBox = null;
            if (listBox_Work.SelectedIndex >= 0)
                selectedListBox = listBox_Work;
            else if (listBox_Break.SelectedIndex >= 0)
                selectedListBox = listBox_Break;

            if (selectedListBox != null)
            {
                if (!flags_Work.Contains(selectedListBox.SelectedIndex))
                    flags_Work.Add(selectedListBox.SelectedIndex);
                else
                    flags_Work.Remove(selectedListBox.SelectedIndex);

                selectedListBox.Invalidate();
                this.ActiveControl = selectedListBox;
            }
        }
    }
}
