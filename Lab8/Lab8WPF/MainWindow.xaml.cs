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
using System.IO;
using Lab8;

namespace Lab8WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] lines;
        Lab8.Polygon[] polygons;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void task1Button_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Document.Blocks.Clear();


            mainTextBox.AppendText("");
            lines = File.ReadAllLines("start.txt");
            polygons = new Lab8.Polygon[lines.Length];



            string[] stringArray;
            int[] tempCoordinateArray;

            for (int i = 0; i < lines.Length; i++)
            {
                stringArray = lines[i].Split(' ');

                if (stringArray.Length == 5)
                {
                    tempCoordinateArray = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        tempCoordinateArray[j] = Convert.ToInt32(stringArray[j]);
                    }
                    polygons[i] = new Lab8.Rectangle("Rectangle", tempCoordinateArray, stringArray[4]);
                }
                else if (stringArray.Length == 7)
                {
                    tempCoordinateArray = new int[6];
                    for (int j = 0; j < 6; j++)
                    {
                        tempCoordinateArray[j] = Convert.ToInt32(stringArray[j]);
                    }
                    polygons[i] = new Triangle("Triangle", tempCoordinateArray, stringArray[6]);
                }
            }
            mainTextBox.AppendText("Данные из текстового файла получены и сформированы в массив.") ;
        }

        private void task2Button_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Document.Blocks.Clear();
            mainTextBox.AppendText("");
            for (int i = 0; i < polygons.Length; i++)
            {
                mainTextBox.AppendText (polygons[i].GetInformation()); 
                if (i==0)
                    mainTextBox.AppendText("\r\n");

            }
            int numberOfSymbols = 0;// "Измененные фигуры:\r\n".Length;

            for (int i = 0; i < polygons.Length; i++)
            {
                int lengthOfString = polygons[i].GetInformation().Length;
                TextRange textRange = new TextRange(mainTextBox.Document.ContentStart.GetPositionAtOffset(numberOfSymbols), mainTextBox.Document.ContentStart.GetPositionAtOffset(numberOfSymbols + lengthOfString));
                textRange.ApplyPropertyValue(TextElement.ForegroundProperty, polygons[i].Color);
                numberOfSymbols += lengthOfString + 2;
            }

        }

        private void task3Button_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Document.Blocks.Clear();
            mainTextBox.AppendText("");
            Lab8.Polygon tempPolygon;
            for (int i = 0; i < polygons.Length - 1; i++)
            {
                for (int j = i + 1; j < polygons.Length; j++)
                {
                    if (polygons[i].GetS() > polygons[j].GetS())
                    {
                        tempPolygon = polygons[i];
                        polygons[i] = polygons[j];
                        polygons[j] = tempPolygon;
                    }
                }
            }

            for (int i = 0; i < polygons.Length; i++)
            {
                mainTextBox.AppendText(polygons[i].GetInformation());
                if (i == 0)
                    mainTextBox.AppendText("\r\n");
            }

            int numberOfSymbols = 0;// "Измененные фигуры:\r\n".Length;

            for (int i = 0; i < polygons.Length; i++)
            {
                int lengthOfString = polygons[i].GetInformation().Length;
                TextRange textRange = new TextRange(mainTextBox.Document.ContentStart.GetPositionAtOffset(numberOfSymbols), mainTextBox.Document.ContentStart.GetPositionAtOffset(numberOfSymbols + lengthOfString));
                textRange.ApplyPropertyValue(TextElement.ForegroundProperty, polygons[i].Color);
                numberOfSymbols += lengthOfString + 2;
            }
        }

        private void task4Button_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Document.Blocks.Clear();
            mainTextBox.AppendText("");
            for (int i = 0; i < polygons.Length; i++)
            {
                if (polygons[i] is Triangle)
                {
                    double aSquare = Math.Pow(polygons[i].Coordinates[2] - polygons[i].Coordinates[0], 2)
                        + Math.Pow(polygons[i].Coordinates[3] - polygons[i].Coordinates[1], 2);
                    double bSquare = Math.Pow(polygons[i].Coordinates[2] - polygons[i].Coordinates[4], 2)
                        + Math.Pow(polygons[i].Coordinates[3] - polygons[i].Coordinates[5], 2);
                    double cSquare = Math.Pow(polygons[i].Coordinates[4] - polygons[i].Coordinates[0], 2)
                        + Math.Pow(polygons[i].Coordinates[5] - polygons[i].Coordinates[1], 2);

                    if (aSquare == (bSquare + cSquare) || bSquare == (cSquare + aSquare)
                        || cSquare == (aSquare + bSquare))
                    {
                        if ((polygons[i].Coordinates[0] <= 0) && (polygons[i].Coordinates[2] <= 0) && (polygons[i].Coordinates[4] <= 0)
                            && (polygons[i].Coordinates[1] >= 0) && (polygons[i].Coordinates[3] >= 0) && (polygons[i].Coordinates[5] >= 0))
                        {
                            polygons[i].Color = "Green";
                        }
                    }

                }


            }

           // mainTextBox.AppendText("Измененные фигуры:\r\n");

            for (int i = 0; i < polygons.Length; i++)
            {
                mainTextBox.AppendText(polygons[i].GetInformation());
                if (i == 0)
                    mainTextBox.AppendText("\r\n");
            }

            int numberOfSymbols = 0;// "Измененные фигуры:\r\n".Length;

            for (int i = 0; i < polygons.Length; i++)
            {
                int lengthOfString = polygons[i].GetInformation().Length;
                TextRange textRange = new TextRange(mainTextBox.Document.ContentStart.GetPositionAtOffset(numberOfSymbols), mainTextBox.Document.ContentStart.GetPositionAtOffset(numberOfSymbols+lengthOfString));
                textRange.ApplyPropertyValue(TextElement.ForegroundProperty, polygons[i].Color);
                numberOfSymbols += lengthOfString + 2;
            }
            
        }

        

    }

    
}
