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

namespace ball
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //double nRotation = 360 * 640 / 2 / Math.PI / 55;

            //DoubleAnimation da = new DoubleAnimation(0, 640, TimeSpan.FromSeconds(5));
            //da.RepeatBehavior = RepeatBehavior.Forever;
            //da.AutoReverse = true;
            //ellipse1.BeginAnimation(Canvas.LeftProperty, da);

            //da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(5));
            //da.RepeatBehavior = RepeatBehavior.Forever;
            //da.AutoReverse = true;
            //ellipse1Rotate.BeginAnimation(RotateTransform.AngleProperty, da);

        }
    }
}
