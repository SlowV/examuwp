﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_Exam.Entity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Exam.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View : Page
    {
        ObservableCollection<ItemCombobox> fonts = new ObservableCollection<ItemCombobox>();
        public View()
        {
            this.InitializeComponent();
        }



        private async void ViewLoad(object sender, RoutedEventArgs e)
        {
            StorageFolder appInstalledFolder = ApplicationData.Current.LocalFolder;
            var fileList = await appInstalledFolder.GetFilesAsync();
            foreach (StorageFile file in fileList)
            {
                Combo.Items.Add(file.Name);
            }
        }
    }
}
