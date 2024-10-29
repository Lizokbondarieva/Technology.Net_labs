using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Wpf11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawConcentricCircles();
        }

        private void DrawConcentricCircles()
        {
            double centerX = 200;
            double centerY = 200;

            for (int i = 0; i < 3; i++)
            {
                double radius = 50 + (i * 50);

                Ellipse circle = new Ellipse
                {
                    Width = radius * 2,
                    Height = radius * 2,
                    StrokeThickness = 2
                };

                switch (i)
                {
                    case 0:
                        circle.Stroke = Brushes.Plum;
                        break;
                    case 1:
                        circle.Stroke = Brushes.Aquamarine;
                        break;
                    case 2:
                        circle.Stroke = Brushes.DarkViolet;
                        break;
                }

                Canvas.SetLeft(circle, centerX - radius);
                Canvas.SetTop(circle, centerY - radius);

                DrawingCanvas.Children.Add(circle);
            }
        }
    }
}
