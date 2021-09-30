using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AzulRadioButton.IsChecked = true;
        }

        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoFinalTextBox.Text = TextoTextBox.Text;
        }

        private void NegritaButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.FontWeight = FontWeights.Bold;
        }

        private void NegritaButton_UnChecked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.FontWeight = FontWeights.Normal;
        }

        private void CursivaButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.FontStyle = FontStyles.Italic;
        }

        private void CursivaButton_UnChecked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.FontStyle = FontStyles.Normal;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBox.Foreground = Brushes.Green;
        }
    }
}
