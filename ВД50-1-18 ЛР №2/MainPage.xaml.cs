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

namespace ВД50_1_18_ЛР__2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(BlankPage1));
        }

        private void Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(BlankPage1));
        }

        private void Settings_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(BlankPage2));
        }

        private void Telephone_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(BlankPage3));
        }

        private void Clock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(BlankPage4));
        }

        private void Play_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(clikerfirst.MainPage));
        }
    }
}
