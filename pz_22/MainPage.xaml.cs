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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace pz_22
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int soupCost = 0;
        static int saladCost = 0;
        static int drinkCost = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            int result = 0;

            RadioButton target = (RadioButton)sender;
            int price = Convert.ToInt32(target.Name.ToString().Substring(1));

            if (target.GroupName == "soup")
            {
                soupCost = price;
            }
            else if (target.GroupName == "salad")
            {
                saladCost = price;
            }
            else if (target.GroupName == "drink")
            {
                drinkCost = price;
            }

            totalCost.Text = (soupCost + saladCost + drinkCost).ToString();
        }
    }
}
