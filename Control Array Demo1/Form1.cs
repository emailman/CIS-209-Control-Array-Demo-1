using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Control_Array_Demo1
{
    public partial class Form1 : Form
    {
        // Create a list of TextBox objects
        // Must be global to the class
        List<TextBox> students = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;
            double grade;
            double largest = double.MinValue;
            double smallest = double.MaxValue;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Look at all the controls in the panel
            foreach (Control each in panel1.Controls)
            {
                if (each is TextBox)
                {
                    // Add all text boxes found in the panel
                    // to the list
                    students.Add((TextBox)each);
                }
            }
        }
    }
}

