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

namespace clikerfirst
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        int allclicks = 0;
        double count = 0;
        double upgrade = 15;
        double upgrade2 = 150;
        double countPerclick = 1;
        double time = 1;
        double a = 1;
        double b = 1;

        Boolean isTimer = false;
        private void Click_Click(object sender, RoutedEventArgs e)
        {
            allclicks++;
            count += countPerclick;
            allclick.Text = count.ToString();
            Schet.Text = allclicks.ToString() + ": кликов с начала игры";
            Proverka();
        }

        private void Timer_Tick(object sender, object e)
        {
            count += time;
            allclick.Text = count.ToString();
            Proverka();
        }

        private void upgradeclick_Click(object sender, RoutedEventArgs e)
        {
            count -= upgrade;
            countPerclick *= 1.25;
            a++;
            Schet1.Text = a.ToString() + ": уровень клика";
            Schet2.Text = countPerclick.ToString() + ": сила клика самородков за клик";
            upgrade *= 1.40;
            Proverka();
            allclick.Text = count.ToString();
            upgradeclick.Content = $"Улучшение (" + upgrade + ") самородков";
        }

        public void Proverka()
        {
            if (count >= upgrade)
            {
                upgradeclick.IsEnabled = true;
            }
            else
            {
                upgradeclick.IsEnabled = false;
            }

            if (count >= upgrade2)
            {
                auto.IsEnabled = true;
            }
            else
            {
                auto.IsEnabled = false;
            }
        }

        private void auto_Click(object sender, RoutedEventArgs e)
        {
            count -= upgrade2;
            allclick.Text = count.ToString();
            b++;
            if (isTimer == false)
            {
                isTimer = true;
                DispatcherTimer timer;
                timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1) };
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            else
            {
                time *= 1.20;
            }
            upgrade2 *= 1.30;
            Schet3.Text = b.ToString() + ": уровень автоклика";
            Schet4.Text = time.ToString() + " самородков/с";
            auto.Content = $"Автоклик {upgrade2} самородков в секунду";
            Proverka();
        }
    }
}
