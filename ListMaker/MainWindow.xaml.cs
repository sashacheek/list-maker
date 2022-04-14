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

namespace ListMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Row(object sender, RoutedEventArgs e)
        {
            //RowDefinition rowDefinition = new RowDefinition();
            //rowDefinition.Height = GridLength.Auto;
            //CheckList.Add(rowDefinition);

            //// TextBox selectedTextBox = (TextBox)CheckList.SelectedItem;

            TextBox textBox = new TextBox();
            textBox.AcceptsReturn = true;
            textBox.TextWrapping = TextWrapping.Wrap;
            textBox.Padding = new Thickness(5);
            CheckList.Items.Add(textBox);

            //Grid.SetRow(textBox, CheckList.RowDefinitions.Count - 1);

            //foreach (ListViewItem listViewItem in CheckList.Items)
            //{

            //}


            //CheckList.Items.Add(textBox);

            //string item = CheckList.SelectedIndex.ToString();
            //MessageBox.Show(item);

            //ListView listView = new ListView();
            //int i = 0;

            // listView.Items.Add(item);
            //foreach (ListItem listViewItem in CheckList.Items)
            //{

            //    if (i == CheckList.SelectedIndex)
            //    {
            //        TextBox textBox = new TextBox();
            //        textBox.AcceptsReturn = true;
            //        textBox.TextWrapping = TextWrapping.Wrap;
            //        textBox.Padding = new Thickness(5);
            //        listView.Items.Add(textBox);
            //    }
            //    TextBox textBox2 = new TextBox();
            //    textBox2.AcceptsReturn = true;
            //    textBox2.TextWrapping = TextWrapping.Wrap;
            //    textBox2.Padding = new Thickness(5);
            //    textBox2.Text = listViewItem.Text;
            //    listView.Items.Add(textBox2);

            //listView.Items.Add(listViewItem);
            //    i++;
            //}

            //CheckList = listView;

        }

    }
}
