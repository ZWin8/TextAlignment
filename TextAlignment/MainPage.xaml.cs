using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TextAlignment
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SetFont();
            DisplayProperties.OrientationChanged += OrientationChanged;
        }

        private void OrientationChanged(object sender)
        {
            SetFont();
        }

        private void SetFont()
        {
            bool IsLandScape = DisplayProperties.CurrentOrientation == DisplayOrientations.Landscape || DisplayProperties.CurrentOrientation == DisplayOrientations.Portrait;
            this.FontSize = IsLandScape ? 40:20;
        }

        // Because the horizon aligment is stretch. No matter where you tapped this event handler will be triggered.
        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock txtBlock = e.OriginalSource as TextBlock;
            txtBlock.Text = "TextAlignment is " + txtBlock.TextAlignment.ToString() + "\nHorizontalAligment is " + txtBlock.HorizontalAlignment.ToString();
        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            TextBlock txtBlock = e.OriginalSource as TextBlock;
            txtBlock.Text = "VerticalAligment derived from Grid is " + txtBlock.VerticalAlignment.ToString();
        }

        private void Page_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            HSize.Text = e.NewSize.Width.ToString();
            VSize.Text = e.NewSize.Height.ToString();
            ActHSize.Text = this.ActualWidth.ToString();
            ActVSize.Text = this.ActualHeight.ToString();
        }
    }
}
