
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VIZSGA_KOROM_KONZOL;

namespace autoform;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Auto> autok = [];
    public MainWindow()
    {
        InitializeComponent();

        

       
    }

    private void btnBeolvas_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        if (ofd.ShowDialog() == true)
        {
            try
            {
                autok = Auto.Beolvas(ofd.FileName);
                dgAutok.ItemsSource = autok;
            }
            catch (Exception)
            {

                MessageBox.Show("Rossz fájlt adott meg!");
            }
        }
    }

    private void tbEv_TextChanged(object sender, TextChangedEventArgs e)
    {
        lbAutoAdatok.Items.Clear();
        foreach (var item in autok.Where(x => x.GyartasiEv == tbEv.Text).ToList())
        {
            lbAutoAdatok.Items.Add($"{item.Marka} - {item.Modell}");
        }   
    }
}