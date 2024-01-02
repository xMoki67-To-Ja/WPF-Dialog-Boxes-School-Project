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

using System;
using System.Windows;

namespace Okienka_dialogowe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowModalDialogButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To jest okno dialogowe modalne.", "Okno modalne", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ShowNonModalDialogButton_Click(object sender, RoutedEventArgs e)
        {
            nonmodalWin nonModalWindow = new nonmodalWin();
            nonModalWindow.Owner = this;
            nonModalWindow.Show();
        }
        private void NonModalWindow_Opened(object sender, EventArgs e)
        {
            // Tutaj możesz wstawić kod, który będzie wykonywany po otwarciu niemodalnego okna
            MessageBox.Show("Niemodalne okno jest teraz otwarte, możesz ingerować w pierwsze okno.");
        }
    }
}