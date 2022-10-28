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

namespace review1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int number;
            int[] primes = new int[100];
            bool success = int.TryParse(textbox1.Text, out number);
            if (!success)
            {
                MessageBox.Show("輸入數值不為整數", "輸入錯誤");
            }
            else if (number < 2)
            {
                MessageBox.Show($"輸入數值為{number},小於2", "輸入錯誤");
            }
            else
            {
                int index = 0;
                for (int i = 2; i <= number; i++)
                {
                    if (isPrime(i))
                    {
                        primes[index] = i;
                        index++;
                    }
                }
                string primeList = $"小於等於{number}的質數為:";
                string primeMulitiple = "";
                foreach (int p in primes)
                {
                    if (p != 0)
                    {
                        primeList += $"{p} ";
                        primeMulitiple += $"{p}的倍數:";
                        int i = 1;
                        while (p * i <= number)
                        {
                            primeMulitiple += $"{p * i} ";
                            i++;
                        }
                        primeMulitiple += "\n";
                    }
                }
                textbox2.Text = primeList;
                textbox3.Text = primeMulitiple;
            }
        }

        private bool isPrime(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0)
                    return false;
            }
            return true;
        }
    }
}