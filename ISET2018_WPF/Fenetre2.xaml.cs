using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace ISET2018_WPF
{
	/// <summary>
	/// Interaction logic for Fenetre2.xaml
	/// </summary>
	public partial class Fenetre2 : Window
	{
		public Fenetre2()
		{
			InitializeComponent();
		}
	}

	public class Degre2Radian : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (double)value * Math.PI / 180;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double angle = 0;
			if (double.TryParse(value.ToString(), out angle))
			{
				if (angle < 0) angle = 0;
				else if (angle > 2 * Math.PI) angle = 2 * Math.PI;
			}
			return angle * 180 / Math.PI;
		}
	}
}
