using Xamarin.Forms;

namespace ColouredListViewCell.CustomUI
{
    public class CustomViewCell : TextCell
    {
        public static readonly BindableProperty BackgroundColorProperty = BindableProperty.Create("BackgroundColor", typeof(Color), typeof(CustomViewCell), Color.Default);

        public Color BackgroundColor
        {
            get => (Color)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }
    }
}

