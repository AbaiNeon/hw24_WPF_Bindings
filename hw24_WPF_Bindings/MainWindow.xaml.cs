using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hw24_WPF_Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private ObservableCollection<Good> goods;
        private Good gas;
        private Good burger;
        private Good drink;
        private Good chocolate;
        public MainWindow()
        {
            InitializeComponent();

            gas = new Good();
            burger = new Good();
            drink = new Good();
            chocolate = new Good();

            textboxGasPrice.DataContext = gas;
            textboxGasCount.DataContext = gas;
            textboxBurgersPrice.DataContext = burger;
            textboxBurgersCount.DataContext = burger;
            textboxDrinkPrice.DataContext = drink;
            textboxDrinkCount.DataContext = drink;
            textboxChocolatePrice.DataContext = chocolate;
            textboxChocolateCount.DataContext = chocolate;
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            textboxResult.Text = gas.Price * gas.Count + burger.Price * burger.Count + drink.Price * drink.Count + chocolate.Price * chocolate.Count + "";
        }
    }
}
