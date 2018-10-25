using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Exam.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add : Page
    {
        public Add()
        {
            this.InitializeComponent();
        }

        private async void SaveFile(object sender, RoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            await storageFolder.CreateFileAsync(NameFileAdd.Text, CreationCollisionOption.ReplaceExisting);


            if (await storageFolder.TryGetItemAsync(NameFileAdd.Text) != null)
            {
                StorageFile sampleFile = await storageFolder.GetFileAsync(NameFileAdd.Text);
                await FileIO.WriteTextAsync(sampleFile, Content.Text);
                Debug.WriteLine("Viet file thanh cong");
                await Task.Delay(1 * 1000);
                NameFileAdd.Text = "";
                Content.Text = "";
            }
        }
    }
}
