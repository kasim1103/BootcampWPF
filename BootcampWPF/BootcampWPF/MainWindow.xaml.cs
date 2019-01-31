using BootcampWPF.Model;
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

namespace BootcampWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Suppliers supplier = new Suppliers();
        Bootcamp22Entities _context = new Bootcamp22Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var result = 0;
            supplier.Name = txt_name.Text;
            supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
            supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
            _context.Suppliers.Add(supplier);
            result = _context.SaveChanges();
            if(result > 0)
            {
                MessageBox.Show("Insert Succesfully");
                txt_name.Clear();
            }
            else
            {
                MessageBox.Show("Insert Failed");
                txt_name.Clear();
            }
        }

        private void txt_name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z .]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            comboBox.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = dataGrid.SelectedItem;
            txt_name.Text = (dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            int choose = 0;
            var id = Convert.ToInt16(txt_search.Text);
            var name = txt_search.Text;
            var joindate = Convert.ToDateTime(txt_search.Text);

            choose = Convert.ToInt16(cb_search.SelectedIndex) + 1;
            switch(choose)
            {
                case 1:
                    dataGrid.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false && x.id == id).ToList();
                    break;

                case 2:
                    dataGrid.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false && x.Name == name).ToList();
                    break;

                case 3:
//                    dataGrid.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false && x.JoinDate == joindate).ToList();
                    break;

                default:
                    MessageBox.Show("Please choose a category");
                    break;
        }
    }
    }
}
