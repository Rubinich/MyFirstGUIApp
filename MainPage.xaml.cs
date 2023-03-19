using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyFirstGUIApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a + b;
            textBlockAns.Text = result.ToString();
            radioButton1.IsChecked = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a - b;
            textBlockAns.Text = result.ToString();
            radioButton1.IsChecked = true;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a * b;
            textBlockAns.Text = result.ToString();
            radioButton1.IsChecked = true;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a / b;
            textBlockAns.Text = result.ToString();
            radioButton1.IsChecked = true;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            if(radioButton1.IsChecked == true) { 
                textBlockAns.Text = Convert.ToString(result, 10);
            }  
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            if(radioButton2.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 2);
            }
        }
        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            if (radioButton3.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 16);
            }
        }
        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            if (radioButton4.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(result, 8);
            }
        }
    }
}
