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
                // Obtener la ruta de la imagen elegida por usuario 
                string rutaImagen = openFileDialog1.FileName;

                // Actualizar la imagen en 
                BitmapImage bitmapImage = new BitmapImage(new Uri(rutaImagen));
                imgFoto.Source = bitmapImage;

                
            }
        }


        private void Txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox) {
                if (textBox.Text == "Direccion" || textBox.Text == "Ciudad" || textBox.Text == "Provincia" || textBox.Text == "Codio Postal" || textBox.Text == "Pais")
                {
                    textBox.Text = "";
                }
            }
        }


        private void Txt_lostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    //if (textBox.Name == "txtDireccion")


                }

            }
        }


            private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Cogemos el texto de los textBox, los metemos en variables
            //Las variables son añadidas al dataGridColumn donde su Binding="{Binding Apellidos}"
            //Lo que junta es el valor de binding en el dataGrid 
            //Para recordar esto dejo al dataGrid de Email con nombre X

            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;

            dataGrid.Items.Add(new { Nombre = nombre, Apellidos = apellidos, X = email, Telefono = telefono });

        }


    }
}
