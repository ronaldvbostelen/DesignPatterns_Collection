using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using VirtualProxy.Annotations;

namespace VirtualProxy.ViewModel
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        private BitmapImage imageSource = new BitmapImage(new Uri("pack://application:,,,/imgs/loading.jpg"));
        public BitmapImage ImageSource
        {
            get => imageSource;
            set
            {
                imageSource = value;
                OnPropertyChanged();
            } 
        }

        public ImageViewModel()
        {
            var btmapDoggo = new BitmapImage(new Uri("https://i.redd.it/s6og1wj07zt41.jpg"));
            btmapDoggo.DownloadCompleted += BtmapDoggoOnDownloadCompleted;
        }

        private void BtmapDoggoOnDownloadCompleted(object? sender, EventArgs e)
        {
            ImageSource = (BitmapImage) sender;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}