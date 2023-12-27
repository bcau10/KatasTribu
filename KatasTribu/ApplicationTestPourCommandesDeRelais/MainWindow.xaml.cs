using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
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

namespace ApplicationTestPourCommandesDeRelais
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

                //InitializeComponent();
                //MainWindowViewModel vm = new MainWindowViewModel(); 
                //DataContext = vm; //pour afficher MainWindowViewModel

                DataContext = this ;
                entries = new ObservableCollection<string>();
                InitializeComponent();


        }

        private ObservableCollection<string> entries;

        private ObservableCollection<string> Entries
        {
            get { return (entries); }
            set { entries = value; }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(TextBoxName.Text);
            Entries.Add(TextBoxSerialNumber.Text);
            Entries.Add(TextBoxQuantity.Text);
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            //Entries.Remove(selectedItem);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Entries.Clear();
        }
    }
}
