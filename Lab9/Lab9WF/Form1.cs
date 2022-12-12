using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab9;

namespace Lab9WF
{
    public partial class Form1 : Form
    {
        ComplexNumber firstComplex;
        ComplexNumber secondComplex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if(firstIm.Text=="" || secondIm.Text=="" || firstRe.Text == "" || secondRe.Text == "")
            {
                HideElements();
                mainTextBox.Text = "Вы не ввели все данные";
            }
            else
            {
                try
                {

                    firstComplex = new ComplexNumber(Convert.ToDouble(firstRe.Text), Convert.ToDouble(firstIm.Text));
                    secondComplex = new ComplexNumber(Convert.ToDouble(secondRe.Text), Convert.ToDouble(secondIm.Text));
                }
                catch
                {
                    HideElements();
                    mainTextBox.Text = "Вы некорректно ввели данные.";
                    return;
                }
                HideElements();
                mainTextBox.Text = "Первое введённое число в комплексном виде: ";
                mainTextBox.Text += firstComplex.OutputComplex();

                mainTextBox.Text+="\r\nВторое введённое число в комплексном виде: ";
                mainTextBox.Text+=secondComplex.OutputComplex();

                mainTextBox.Text += "\r\nСумма двух чисел в комплексном виде: ";
                ComplexNumber complexSum = firstComplex + secondComplex;
                mainTextBox.Text += complexSum.OutputComplex();

                mainTextBox.Text+="\r\nПроизведение двух чисел в комплексном виде: ";
                ComplexNumber complexMultiplication = firstComplex * secondComplex;


                mainTextBox.Text += complexMultiplication.OutputComplex();
            }
        }

        private void HideElements()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            firstRe.Visible = false;
            secondRe.Visible = false;
            firstIm.Visible = false;
            secondIm.Visible = false;
            startButton.Visible = false;
            mainTextBox.Visible = true;
        }
    }
}
