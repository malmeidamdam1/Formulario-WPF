using Microsoft.Win32;
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

namespace Formulario_WPF_Midgard_Almeida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CargarFoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
            if (openFileDialog1.ShowDialog() == true)
            {
                // Obtén la ruta del archivo seleccionado
                string rutaImagen = openFileDialog1.FileName;

                // Actualiza la imagen en el control Image
                BitmapImage bitmapImage = new BitmapImage(new Uri(rutaImagen));
                imgFoto.Source = bitmapImage;
            }
        }
        private void cambiarTexto() {

           // IsNullOrWhiteSpace(txtDireccion);



        }
       
    }

}
