using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using ColouredListViewCell.CustomUI;
using ColouredListViewCell.Droid.CustomUIRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace ColouredListViewCell.Droid.CustomUIRenderers
{
    public class CustomViewCellRenderer : TextCellRenderer
    {
        Android.Views.View cellCore;
        Drawable unselectedBackground;
        bool selected;

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            cellCore = base.GetCellCore(item, convertView, parent, context);

            // Save original background to rollback to it when not selected,
            // We assume that no cells will be selected on creation.
            selected = false;
            unselectedBackground = cellCore.Background;

            return cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnCellPropertyChanged(sender, args);

            if (args.PropertyName == "IsSelected")
            {
                // I had to create a property to track the selection because cellCore.Selected is always false.
                // Toggle selection
                selected = !selected;

                if (selected)
                {
                    var customTextCell = sender as CustomViewCell;
                    cellCore.SetBackgroundColor(customTextCell.BackgroundColor.ToAndroid());
                }
                else
                {
                    cellCore.SetBackground(unselectedBackground);
                }
            }
        }
    }
}
