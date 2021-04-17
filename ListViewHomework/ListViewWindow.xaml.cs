using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.ComponentModel;

namespace ListViewHomework
{
    public partial class ListViewWindow : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ListViewWindow()
        {
            InitializeComponent();
            MainListView.ItemsSource = Human.Humans;
        }


        private void SwitchWindowButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
        }

        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NameTextBlock.DataContext = MainListView.SelectedItem;
            BirthYearTextBlock.DataContext = MainListView.SelectedItem;
            BirthNumberTextBlock.DataContext = MainListView.SelectedItem;
        }

        //private string nameText;
        //public string NameText
        //{
        //    get { return nameText; }
        //    set 
        //    {
        //        nameText = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameText));
        //    }
        //}

    }
}
