/*
    Exemplary file for Chapter 5 - Animations and Graphics.
    Recipe: Handling the "pinch" and "rotate" touch events.
*/

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CH05
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Image_ImageOpened(object sender, RoutedEventArgs e)
        {
            Image image = (Image)sender;
            ImageRotateTransform.CenterX = image.ActualWidth / 2;
            ImageRotateTransform.CenterY = image.ActualHeight / 2;
            ImageScaleTransform.CenterX = image.ActualWidth / 2;
            ImageScaleTransform.CenterY = image.ActualHeight / 2;
        }

        private void Image_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            ImageScaleTransform.ScaleX /= e.Delta.Scale;
            ImageScaleTransform.ScaleY /= e.Delta.Scale;
            ImageRotateTransform.Angle += e.Delta.Rotation;
        }
    }
}
