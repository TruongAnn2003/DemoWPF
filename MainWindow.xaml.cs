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

namespace QLHocSinh_WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        private ObservableCollection<SinhVien> listSinhVien;
        public ObservableCollection<SinhVien> ListSinhVien { get { return listSinhVien; } set { listSinhVien = value; } }
        public MainWindow()
        {
            InitializeComponent();
            listSinhVien = new ObservableCollection<SinhVien>();
            ListSinhVien.Add(new SinhVien("Nguyễn Trường An", "21110117", "032325154", "Bến Tre"));
            ListSinhVien.Add(new SinhVien("Trần Đỗ Thanh An", "21110225", "032373622", "Tp Hồ Chí Minh"));
            ListSinhVien.Add(new SinhVien("Đặng Huy Diệu", "21110325", "032325545", "Tp Hồ Chí Minh"));
            ListSinhVien.Add(new SinhVien("Trần Văn An", "21110258", "0323020515", "Đồng Nai"));
            ListSinhVien.Add(new SinhVien("Mai Anh Khoa", "21110147", "032373554", "Tây Ninh"));
            ListSinhVien.Add(new SinhVien("Nguyễn Văn Hoàng", "21110369", "03235551", "Tp Hồ Chí Minh"));
            ListSinhVien.Add(new SinhVien("Hoàng Công Mạnh", "21110258", "032315562", "Hà Nội"));
            ListSinhVien.Add(new SinhVien("Huỳnh Minh Trí", "21110114", "032351555", "Tp Hồ Chí Minh"));
            ListSinhVien.Add(new SinhVien("Nguyễn Hà Quỳnh Giao", "21110226", "0325151588", "Kiên Giang"));
            ListSinhVien.Add(new SinhVien("Đặng Xuân Hùng", "21110332", "032311414", "Đà Nẵng"));
            ListSinhVien.Add(new SinhVien("Đặng Xuân Hùng", "21110332", "0323711244", "Đà Nẵng"));
            listviewSinhVien.ItemsSource = ListSinhVien;
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            ListSinhVien.Add(new SinhVien(txtName.Text, txtID.Text, txtNumberPhone.Text, txtAddress.Text));
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            ListSinhVien.Remove((sender as Button).DataContext as SinhVien);
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            ListSinhVien.Add(new SinhVien(txtName.Text, txtID.Text, txtNumberPhone.Text, txtAddress.Text));
            ListSinhVien.Remove(listviewSinhVien.SelectedItem as SinhVien);
        }

        
    }
}
