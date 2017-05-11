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
using System.Windows.Media.Animation;

namespace PathAnimation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            path1.Freeze(); // Freeze pat1 for performance benefits.
            DoubleAnimationUsingPath daPath = new DoubleAnimationUsingPath();
            daPath.Duration = TimeSpan.FromSeconds(5);
            daPath.RepeatBehavior = RepeatBehavior.Forever;
            daPath.AccelerationRatio = 0.6;
            daPath.DecelerationRatio = 0.4;
            daPath.AutoReverse = true;
            daPath.PathGeometry = path1;
            daPath.Source = PathAnimationSource.X;
          ellipse1.BeginAnimation(Canvas.LeftProperty, daPath);

            daPath = new DoubleAnimationUsingPath();
            daPath.Duration = TimeSpan.FromSeconds(5);
            daPath.RepeatBehavior = RepeatBehavior.Forever;
            daPath.AccelerationRatio = 0.6;
            daPath.DecelerationRatio = 0.4;
            daPath.AutoReverse = true;
            daPath.PathGeometry = path1;
            daPath.Source = PathAnimationSource.Y;
            ellipse1.BeginAnimation(Canvas.TopProperty, daPath);
        }
    }
}
