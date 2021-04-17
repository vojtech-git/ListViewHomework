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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace ListViewHomework
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void ShowListButton_Click(object sender, RoutedEventArgs e)
        {
            ListViewWindow listViewWindow = new ListViewWindow();

            //foreach (Human human in Human.Humans)
            //{
            //    listViewWindow.MainListView.Items.Add(new ListViewItem());
            //}

            listViewWindow.ShowDialog();
        }

        private void AddHumanButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameText.Text != "" && LastNameText.Text != "" && BirthYearText.Text != "" && BirthNumberText.Text != "")
            {
                Human.Humans.Add(new Human(NameText.Text, LastNameText.Text, Convert.ToInt32(BirthYearText.Text), Convert.ToInt32(BirthNumberText.Text)));
                MessageBox.Show(NameText.Text + " " + LastNameText.Text + " byl přidán do databáze!");
                NameText.Text = string.Empty;
                LastNameText.Text = string.Empty;
                BirthYearText.Text = string.Empty;
                BirthNumberText.Text = "";
            }
            else MessageBox.Show("Špatně zadané informace");
        }

        private void DeleteHumans_Click(object sender, RoutedEventArgs e)
        {
            Human.Humans = new List<Human>();
            MessageBox.Show("Všichni vymázáni");
        }

        private void BirthYearText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }        

        private void BirthNumberText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
