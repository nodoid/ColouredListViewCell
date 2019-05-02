using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using ColouredListViewCell.CustomUI;
using ColouredListViewCell.iOS.CustomUIRenderers;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace ColouredListViewCell.iOS.CustomUIRenderers
{
    public class CustomViewCellRenderer : TextCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            var view = item as CustomViewCell;
            cell.SelectedBackgroundView = new UIView
            {
                BackgroundColor = view.BackgroundColor.ToUIColor(),
            };

            return cell;
        }
    }
}
