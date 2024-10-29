using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Wpf10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawCircleButton_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();

            if (double.TryParse(RadiusTextBox.Text, out double radius) && radius > 0)
            {
                Ellipse circle = new Ellipse
                {
                    Width = radius * 2,
                    Height = radius * 2,
                    Fill = Brushes.Aquamarine,
                    Stroke = Brushes.Blue,
                    StrokeThickness = 2
                };

                Canvas.SetLeft(circle, (DrawingCanvas.Width - circle.Width) / 2);
                Canvas.SetTop(circle, (DrawingCanvas.Height - circle.Height) / 2);

                DrawingCanvas.Children.Add(circle);
            }
            else
                MessageBox.Show("Будь ласка, введiть коректне значення радiусу.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
