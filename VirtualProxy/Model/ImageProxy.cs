using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using VirtualProxy.Annotations;

namespace VirtualProxy.Model
{
    public class ImageProxy : INotifyPropertyChanged
    {
        private Uri imageSource;
        private BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/imgs/loading.jpg"));

        public BitmapImage Image
        {
            get => image;
            private set
            {
                if (value != image)
                {
                    image = value;
                    OnPropertyChanged();
                }
            }}

        public ImageProxy(Uri imageSource)
        {
            this.imageSource = imageSource;
            LoadRealImage();
        }

        private void LoadRealImage()
        {
            var img = new BitmapImage(imageSource);
            img.DownloadCompleted += (sender, args) => Image = img;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}