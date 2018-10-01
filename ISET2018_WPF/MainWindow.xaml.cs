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

namespace ISET2018_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnClic_Click(object sender, RoutedEventArgs e)
		{
			DoubleAnimation da = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromSeconds(2)));
			da.AutoReverse = true;
			btnClic.BeginAnimation(Button.OpacityProperty, da);
			MessageBox.Show("H e l l o   w o r l d");
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			DoubleAnimation da = new DoubleAnimation(0, -360, new Duration(TimeSpan.FromSeconds(3)));
			da.RepeatBehavior = RepeatBehavior.Forever;
			ImgYeti.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, da);
		}

		private void btnSsBouton_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Clic sur le 'sous-'bouton");
		}

		private void btnSrBouton_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Clic sur le 'sur-'bouton");
		}

		private void lbQualite_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			MessageBox.Show("Bonjour " + ((ListBoxItem)lbQualite.SelectedItem).Content.ToString());
		}

		private void btnFen1_Click(object sender, RoutedEventArgs e)
		{
			Fenetre1 f = new Fenetre1();
			f.ShowDialog();
		}

		private void btnFen2_Click(object sender, RoutedEventArgs e)
		{
			Fenetre2 f = new Fenetre2();
			f.ShowDialog();
		}

		private void btnFen3_Click(object sender, RoutedEventArgs e)
		{
			Fenetre3 f = new Fenetre3();
			f.ShowDialog();
		}
	}
}
