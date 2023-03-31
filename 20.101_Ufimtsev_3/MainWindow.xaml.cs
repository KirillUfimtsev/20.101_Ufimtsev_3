using _20._101_Ufimtsev_3.Entity;
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

namespace _20._101_Ufimtsev_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var db = Entities.GetContext().Discipline.Where(p => p.IdDiscipline == 2).ToList();

            if (db == null)
            {
                MessageBox.Show("Ничего не найдено!");
                return;
            }

            LoadData.ItemsSource = db;
        }
    }

    
}
