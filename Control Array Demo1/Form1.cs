using System;
using System.Windows.Forms;

namespace Control_Array_Demo1
{
    public partial class Form1 : Form
    {
        // Create an array of TextBox objects
        // as a class variable
        private TextBox[] students;

        public Form1()
        {
            InitializeComponent();

            // Initialize the array with text box controls
            students = new TextBox[] { tbx1, tbx2, tbx3, tbx4 };
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;
            double grade;
            double largest = Double.MinValue;
            double smallest = Double.MaxValue;

            // Handle each Text Box in the array
            foreach (TextBox each in students)
            {
                if (each.Text != "")
                {
                    if (double.TryParse(each.Text, out grade))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            sum += grade;
                            count++;

                            if (grade > largest)
                                largest = grade;

                            if (grade < smallest)
                                smallest = grade;
                        }
                        else
                            MessageBox.Show("Grade outside of range 0-100",
                           "Data Entry Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Non-numeric data",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }

            // Post the results, if any
            if (count >= 1)
            {
                lblGradesEntered.Text = count.ToString();
                lblAverage.Text = (sum / count).ToString();
                lblHigh.Text = largest.ToString();
                lblLow.Text = smallest.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
