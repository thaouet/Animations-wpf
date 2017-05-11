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



namespace exam1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartAnimation();
        }

        private void StartAnimation()
        {
            // Path1 animation:
          

            // Path2 animation:
            path2.Freeze(); // Freeze pat1 for performance benefits.
            DoubleAnimationUsingPath daPath = new DoubleAnimationUsingPath();
            daPath.Duration = TimeSpan.FromSeconds(5);
            daPath.RepeatBehavior = RepeatBehavior.Forever;
            daPath.AccelerationRatio = 0.6;
            daPath.DecelerationRatio = 0.4;
            daPath.AutoReverse = true;
            daPath.PathGeometry = path2;
            daPath.Source = PathAnimationSource.X;
            circle2.BeginAnimation(Canvas.LeftProperty, daPath);
           


           // path3
            path3.Freeze(); // Freeze pat1 for performance benefits.
            DoubleAnimationUsingPath dbPath = new DoubleAnimationUsingPath();
            dbPath.Duration = TimeSpan.FromSeconds(5);
            dbPath.RepeatBehavior = RepeatBehavior.Forever;
            dbPath.AccelerationRatio = 0.6;
            dbPath.DecelerationRatio = 0.4;
            dbPath.AutoReverse = true;
            dbPath.PathGeometry = path3;
            dbPath.Source = PathAnimationSource.X;
            
            chassis.BeginAnimation(Canvas.LeftProperty, dbPath);

            dbPath = new DoubleAnimationUsingPath();
            dbPath.Duration = TimeSpan.FromSeconds(5);
            dbPath.RepeatBehavior = RepeatBehavior.Forever;
            dbPath.AccelerationRatio = 0.6;
            dbPath.DecelerationRatio = 0.4;
            dbPath.AutoReverse = true;
            dbPath.PathGeometry = path3;

            dbPath.Source = PathAnimationSource.Y;

          
            chassis.BeginAnimation(Canvas.TopProperty, dbPath);









            // Path1 animation:
            path1.Freeze(); // Freeze pat1 for performance benefits.
            DoubleAnimationUsingPath dPath = new DoubleAnimationUsingPath();
            dPath.Duration = TimeSpan.FromSeconds(5);
            dPath.RepeatBehavior = RepeatBehavior.Forever;
            dPath.AccelerationRatio = 0.6;
            dPath.DecelerationRatio = 0.4;
            dPath.AutoReverse = true;
            dPath.PathGeometry = path1;
            dPath.Source = PathAnimationSource.X;
            circle1.BeginAnimation(Canvas.LeftProperty, dPath);
           


          
           

            daPath = new DoubleAnimationUsingPath();
            daPath.Duration = TimeSpan.FromSeconds(5);
            daPath.RepeatBehavior = RepeatBehavior.Forever;
            daPath.AccelerationRatio = 0.6;
            daPath.DecelerationRatio = 0.4;
            daPath.AutoReverse = true;
            daPath.PathGeometry = path2;
            
            daPath.Source = PathAnimationSource.Y;

            circle2.BeginAnimation(Canvas.TopProperty, daPath);
           

            dPath = new DoubleAnimationUsingPath();
            dPath.Duration = TimeSpan.FromSeconds(5);
            dPath.RepeatBehavior = RepeatBehavior.Forever;
            dPath.AccelerationRatio = 0.6;
            dPath.DecelerationRatio = 0.4;
            dPath.AutoReverse = true;
            dPath.PathGeometry = path1;

            dPath.Source = PathAnimationSource.Y;
            circle1.BeginAnimation(Canvas.TopProperty, dPath);
         

            double nRotation = 360 * (224 + Math.Sqrt(225 * 225 + 88 * 88)) / 2 / Math.PI / 25;
            DoubleAnimation da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(5));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            da.AccelerationRatio = 0.6;
            da.DecelerationRatio = 0.4;
            circle2Rotate.BeginAnimation(RotateTransform.AngleProperty, da);
            circle1Rotate.BeginAnimation(RotateTransform.AngleProperty, da);


            //nRotation = 15;
            //da = new DoubleAnimation(0, nRotation, TimeSpan.FromSeconds(2));
            
          
            //da.AutoReverse = true;
            //da.RepeatBehavior = RepeatBehavior.Forever;
            //polyrotate.BeginAnimation(RotateTransform.AngleProperty, da);


        }
    
    }
}
