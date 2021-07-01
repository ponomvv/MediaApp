using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace MediaApp
    {
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage: Page
        {
        public MainPage()
            {
            this.InitializeComponent();
            }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
            {
            headerBlock.Text = "Ошибка открытия файла";
            }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
            {
            headerBlock.Text = media.Source.LocalPath;
            }

        private void media_MediaEnded(object sender, RoutedEventArgs e)
            {
            headerBlock.Text = "Воспроизведение завершено";
            }

        private void Play_Click(object sender, RoutedEventArgs e)
            {
            media.Play();
            }

        private void Pause_Click(object sender, RoutedEventArgs e)
            {
            if (media.CanPause)
                media.Pause();
            }

        private void Stop_Click(object sender, RoutedEventArgs e)
            {
            media.Stop();
            }
        }
    }
