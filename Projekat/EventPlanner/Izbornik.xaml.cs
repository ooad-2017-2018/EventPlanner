﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EventPlanner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Izbornik : Page
    {
        public Izbornik()
        {
            this.InitializeComponent();
        }

        private void dugmeazuriraj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AzuriranjeSaradnika2));
        }

        private void dugmeobrisi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ObrisiUsluguSistem_Svoju));
        }

        private void dugmePrijaviSe_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodajUslugu));
        }

        private void dugmeizlaz_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UlazniPage));
        }
    }
}
