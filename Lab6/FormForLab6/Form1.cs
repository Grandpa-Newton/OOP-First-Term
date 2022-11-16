using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6;

namespace FormForLab6
{
    public partial class Form1 : Form
    {
        Workshop[] workByDays = new Workshop[3];

        double sum = 0;
        
        int firstDay=0, secondDay=0;

        //bool confirmButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            for (int i = 0; i < workByDays.Length; i++)
            {
                mainTextBox.Text+=$"ДЕНЬ {i + 1}\r\n";
                for (int j = 0; j < Enum.GetValues(typeof(Work)).Length; j++)
                {
                    mainTextBox.Text+=Enum.GetNames(typeof(Work)).GetValue(j) + ":";
                    mainTextBox.Text+=(int)workByDays[i].NumberOfWork[j] + "\r\n";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            sum = 0;
            for (int i = 0; i < Enum.GetValues(typeof(Work)).Length; i++)
            {
                sum = GetNumberOfWorksByDays(i, workByDays);
                mainTextBox.Text += Enum.GetNames(typeof(Work)).GetValue(i) + " за день = " + sum / Enum.GetValues(typeof(Work)).Length + "\r\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] tempArray = new int[Enum.GetValues(typeof(Work)).Length];

            for (int i = 0; i < this.workByDays.Length; i++)
            {
                for (int j = 0; j < Enum.GetValues(typeof(Work)).Length; j++)
                {
                    tempArray[j] = random.Next(1, 10);
                }
                this.workByDays[i] = new Workshop(tempArray);
            }
            mainTextBox.Text = "КОЛИЧЕСТВО ВЫПОЛНЕННЫХ РАБОТ СГЕНЕРИРОВАНО";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // добавить проверку, что sec>first + что не выходит за рамки

            if (textBox1.Text == "" || textBox2.Text == "")
                mainTextBox.Text = "Неверно указаны (или не указаны) дни в формах.";
            else
            {
                firstDay = Convert.ToInt32(textBox1.Text);
                secondDay = Convert.ToInt32(textBox2.Text);

                if (textBox1.Text == "" || textBox2.Text == "")
                    mainTextBox.Text = "Неверно указаны (или не указаны) дни в формах.";
                else
                {
                    firstDay = Convert.ToInt32(textBox1.Text);
                    secondDay = Convert.ToInt32(textBox2.Text);

                    if (secondDay < firstDay || secondDay > workByDays.Length + 1)
                    {
                        mainTextBox.Text = "Неверно заданы дни (либо второй день больше второго, либо он выходит за рамки количества дней).";
                    }
                    else
                    {
                        sum = 0;
                        for (int i = firstDay - 1; i < secondDay; i++)
                        {
                            for (int j = 0; j < Enum.GetValues(typeof(Work)).Length; j++)
                            {
                                sum += (int)workByDays[i].NumberOfWork[j];
                            }
                        }

                        mainTextBox.Text = $"Количество выполненных заказов за период ({firstDay} - {secondDay} дни) = {sum}";
                    }
                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       /* private void button7_Click(object sender, EventArgs e)
        {
            confirmButton = true;
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                mainTextBox.Text = "Неверно указаны (или не указаны) дни в формах.";
            else
            {
                firstDay = Convert.ToInt32(textBox1.Text);
                secondDay = Convert.ToInt32(textBox2.Text);

                if (secondDay<firstDay || secondDay>workByDays.Length+1)
                {
                    mainTextBox.Text = "Неверно заданы дни (либо второй день больше второго, либо он выходит за рамки количества дней).";
                }
                else
                {
                    int max = 0, index = 0;
                    for (int i = firstDay - 1; i < secondDay; i++)
                    {
                        max += (int)workByDays[i].NumberOfWork[0];
                    }

                    int tempMax = 0;

                    for (int i = 1; i < workByDays.Length; i++)
                    {
                        tempMax = 0;
                        for (int j = firstDay - 1; j < secondDay; j++)
                        {
                            tempMax += (int)workByDays[j].NumberOfWork[i];
                        }
                        if (tempMax > max)
                        {
                            index = i;
                            max = tempMax;
                        }
                    }

                    mainTextBox.Text = "Самый востребованный вид работ - " + Enum.GetNames(typeof(Work)).GetValue(index) + " с количеством = " + max;
                }
                
            }


        }

        static int GetNumberOfWorksByDays(int index, Workshop[] workByDays)
        {
            int sum = 0;
            for (int j = 0; j < workByDays.Length; j++)
            {
                sum += (int)workByDays[j].NumberOfWork[index];
            }

            return sum;

        }
    }
}
