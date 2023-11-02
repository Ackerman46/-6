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

namespace Практ6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] array1; int[] array2 ; int[] array3; int[] array4 ; int[] array5;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int.TryParse(ArrayLongTB.Text, out int M);
            if (M < 101 && M > 0)
            {
                Random rnd = new Random();

                array1 = new int[M]; array2 = new int[M]; array3 = new int[M]; array4 = new int[M]; array5 = new int[M];
                FillArray.FillArrays(array1, rnd); FillArray.FillArrays(array2, rnd); FillArray.FillArrays(array3, rnd); FillArray.FillArrays(array4, rnd); FillArray.FillArrays(array5, rnd);
                Array1DG.ItemsSource = ArrayToDG.ToDataTable(array1).DefaultView; Array2DG.ItemsSource = ArrayToDG.ToDataTable(array2).DefaultView; Array3DG.ItemsSource = ArrayToDG.ToDataTable(array3).DefaultView; Array4DG.ItemsSource = ArrayToDG.ToDataTable(array4).DefaultView; Array5DG.ItemsSource = ArrayToDG.ToDataTable(array5).DefaultView;
            }
            else { MessageBox.Show("Задайте корректный размер массива"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Массив 1 имеет эллементы 1 знака = {CheckArray.CheckArrays(array1)}\nМассив 2 имеет эллементы 1 знака = {CheckArray.CheckArrays(array2)}\nМассив 3 имеет эллементы 1 знака = {CheckArray.CheckArrays(array3)}\nМассив 4 имеет эллементы 1 знака = {CheckArray.CheckArrays(array4)}\nМассив 5 имеет эллементы 1 знака = {CheckArray.CheckArrays(array5)}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Даны 5 одномерных массива вещественных элементов. Размер массива не превышает 100, для каждого из массивов определить имеют ли его эллементы 1 знак");
        }
    }
}
