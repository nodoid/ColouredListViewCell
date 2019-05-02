using System.Collections.Generic;
using Xamarin.Forms;

namespace ColouredListViewCell
{
    public class DataObject
    {
        public string Letter { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        List<DataObject> data { get; set; }

        public MainPage()
        {
            data = new List<DataObject> { new DataObject { Letter = "A" }, new DataObject { Letter = "B" }, new DataObject { Letter = "C" }, new DataObject { Letter = "D" }, new DataObject { Letter = "E" } };

            InitializeComponent();
            ListView.ItemsSource = data;
        }
    }
}
