using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using VirtualProxy.Annotations;
using VirtualProxy.Model;

namespace VirtualProxy.ViewModel
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        private ImageProxy imageProxy;
        public ImageProxy ImageProxy  {  get => imageProxy;  set  {  if (value != imageProxy)  {  imageProxy = value;  OnPropertyChanged(); } } }

        public ImageViewModel()
        {
            ImageProxy = new ImageProxy(new Uri("https://i.redd.it/s6og1wj07zt41.jpg"));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}