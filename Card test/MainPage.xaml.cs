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
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Graphics.Imaging;


namespace Card_test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            list_1.Items.Add("First");
            list_1.Items.Add("Second");
            list_1.Items.Add("Third");
            list_1.Items.Add("Fourth");

            list_2.Items.Add("First");
            list_2.Items.Add("Second");
            list_2.Items.Add("Third");
            list_2.Items.Add("Fourth");

            list_3.Items.Add("First");
            list_3.Items.Add("Second");
            list_3.Items.Add("Third");
            list_3.Items.Add("Fourth");

            list_4.Items.Add("First");
            list_4.Items.Add("Second");
            list_4.Items.Add("Third");
            list_4.Items.Add("Fourth");
            
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //BitmapImage one = new BitmapImage();
            //one.UriSource = new Uri(image.BaseUri, @"C:\Users\wwstudent\Downloads\Books\02taurus.jpg");            
            //image.Source = one;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = list_1.SelectedItem.ToString();
            string b = list_2.SelectedItem.ToString();
            string c = list_3.SelectedItem.ToString();
            string d = list_4.SelectedItem.ToString();
            txt.Text = a + " " + b +" "+ " "+ c +" "+ d;
        }
    }
}