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


namespace animationSimple
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 200;
            da.AutoReverse = true;
            da.Duration = TimeSpan.FromSeconds(5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rect1.BeginAnimation(Canvas.LeftProperty, da);
            rect1.BeginAnimation(Canvas.TopProperty, da);
        }
    }
}
