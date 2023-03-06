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

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlockIspis.Text = "Hello Alojz Rubinić";
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int b = Int32.Parse(textBox2.Text);
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a + b;
            textBlockAns.Text = result.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a - b;
            textBlockAns.Text = result.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a * b;
            textBlockAns.Text = result.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int result = a / b;
            textBlockAns.Text = result.ToString();
        }
    }
}
