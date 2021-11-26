using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_task4_23
{
    public partial class Form1 : Form
    {
        private Student student;
        private AdvancedStudent advStudent;
        private string surname;
        private double score;
        private int studyYear;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            surname = textBox1.Text;
            score = double.Parse(textBox2.Text);
            studyYear = int.Parse(textBox3.Text);

            student = new Student(surname, score, studyYear);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                advStudent = new AdvancedStudent(surname, score, studyYear, true);
            else advStudent = new AdvancedStudent(surname, score, studyYear, false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (advStudent != null)
            {
                textBox4.Text = advStudent.GetInfo();
            } else
            {
                if (student != null)
                {
                    textBox4.Text = student.GetInfo();
                } else
                {
                    textBox4.Text = "Сначала запишите данные о студенте";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (advStudent != null)
            {
                textBox5.Text = advStudent.DefineQuality().ToString();
            }
            else
            {
                if (student != null)
                {
                    textBox5.Text = student.DefineQuality().ToString();
                }
                else
                {
                    textBox5.Text = "Сначала запишите данные о студенте";
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
