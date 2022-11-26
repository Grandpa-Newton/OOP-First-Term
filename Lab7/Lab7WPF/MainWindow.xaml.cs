using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab7;

namespace Lab7WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numberOfProducers;
        string[] producers;
        Type[] classes;

        Candy[] candies =
            {
                new Caramel("Malibu",5,"Malibu","Russia"),
                new Caramel("Ledenets s myatoy",2,"Spartak","Belarus"),
                new Caramel("Barbaris",2,"Spartak","Belarus"),
                new Chocolate("Snickers",9,"Mars","Russia"),
                new Chocolate("Twix",8,"Mars","Russia"),
                new Chocolate("Bounty",9,"Mars","Russia"),
                new Chocolate("Muesli",1,"Spartak","Belarus"),
                new Toffee("Vanyckers",4,"Ivan Prod.","Zimbabwe"),
                new Toffee("Letuchka",12,"Mathematica","Belarus"),
                new Caramel("Harryk Potter",4,"IP 'Ronald Wisley'","Great Britain"),
            };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void firstTaskButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text = "Количество производителей равно " + numberOfProducers;
        }

        private void secondTaskButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text = "";
            double sum;
            int numberOfCandies;

            for (int i = 0; i < producers.Length; i++)
            {
                sum = 0;
                numberOfCandies = 0;
                for (int j = 0; j < candies.Length; j++)
                {
                    if (producers[i] == candies[j].Producer.Name)
                    {
                        numberOfCandies++;
                        sum += candies[j].Cost;
                    }
                }
                mainTextBox.Text += $"Средняя цена конфет производителя {producers[i]} равна {sum / numberOfCandies}\r\n";
            }
        }

        private void thirdTaskButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text = "";
            double sum;
            int numberOfCandies;
            for (int i = 0; i < classes.Length; i++)
            {
                sum = 0;
                numberOfCandies = 0;
                for (int j = 0; j < candies.Length; j++)
                {
                    if (classes[i] == candies[j].GetType())
                    {
                        numberOfCandies++;
                        sum += candies[j].Cost;
                    }
                }
                mainTextBox.Text += $"Средняя цена конфет {classes[i].ToString().Substring(classes[i].ToString().LastIndexOf(".") + 1)} равна {sum / numberOfCandies}\r\n";
            }
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.Visibility = Visibility.Hidden;
            mainTextBox.Visibility = Visibility.Visible;
            firstTaskButton.Visibility = Visibility.Visible;
            secondTaskButton.Visibility = Visibility.Visible;
            thirdTaskButton.Visibility = Visibility.Visible;
            mainLabel.Visibility = Visibility.Visible;


            bool isFounded;
            numberOfProducers = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < i; j++)
                {
                    if (candies[i].Producer.Name == candies[j].Producer.Name)
                    {
                        isFounded = true;
                    }
                }
                if (!isFounded)
                    numberOfProducers++;
            }

            producers = new string[numberOfProducers];
            producers[0] = candies[0].Producer.Name;

            int indexOfProducers = 1;

            for (int i = 1; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < producers.Length; j++)
                {
                    if (candies[i].Producer.Name == producers[j])
                    {
                        isFounded = true;
                        break;
                    }
                }
                if (!isFounded)
                {
                    producers[indexOfProducers] = candies[i].Producer.Name;
                    indexOfProducers++;
                }
            }

            int numberOfClasses = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < i; j++)
                {
                    if (candies[i].GetType() == candies[j].GetType())
                        isFounded = true;
                }
                if (!isFounded)
                    numberOfClasses++;
            }

            classes = new Type[numberOfClasses];
            classes[0] = candies[0].GetType();

            int indexOfClasses = 1;


            for (int i = 1; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < classes.Length; j++)
                {
                    if (candies[i].GetType() == classes[j])
                    {
                        isFounded = true;
                        break;
                    }
                }
                if (!isFounded)
                {
                    classes[indexOfClasses] = candies[i].GetType();
                    indexOfClasses++;
                }
            }
        }

        
    }
}
