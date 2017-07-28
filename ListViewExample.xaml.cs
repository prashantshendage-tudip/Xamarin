using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXamarinForm.ViewModels;
using Xamarin.Forms;

namespace TestXamarinForm
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        public ObservableCollection<VeggieViewModel> veggies { get; set; }
        public MainPage()
        {
            InitializeComponent();
            veggies = new ObservableCollection<VeggieViewModel>();
            veggies.Add(new VeggieViewModel { Name = "Tomato dcfvgbhb frtgyhu br55tyh", Type = "Fruit", Image = "icon.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable",Image=null });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "icon.png" });
            lstView.ItemsSource = veggies;
        }
      
    }
}
