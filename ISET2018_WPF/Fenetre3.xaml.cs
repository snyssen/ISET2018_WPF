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
using System.Windows.Shapes;
using System.ComponentModel;

namespace ISET2018_WPF
{
	/// <summary>
	/// Interaction logic for Fenetre3.xaml
	/// </summary>
	public partial class Fenetre3 : Window
	{
		public Fenetre3()
		{
			InitializeComponent();
		}

		private void BtnVerifier_Click(object sender, RoutedEventArgs e)
		{

		}
	}

	public class Data : INotifyPropertyChanged // Génère des événements quand une propriété est changée
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string PropertyName)
		{
			PropertyChangedEventHandler Handler = PropertyChanged;
			if (Handler != null)
				Handler(this, new PropertyChangedEventArgs(PropertyName));
		}
	}

	public class Personne : Data
	{
		private int _ID;
		private string _Nom, _Pre;
		public int ID
		{
			get { return _ID; }
			set { _ID = value; OnPropertyChanged("ID"); /* trigger event on update */ }
		}
		public string Nom
		{
			get { return _Nom; }
			set { _Nom = value; OnPropertyChanged("Nom"); }
		}
		public string Pre
		{
			get { return _Pre; }
			set { _Pre = value; OnPropertyChanged("Pre"); }
		}
		public Personne() { ID = -1; Nom = Pre = ""; }
		public Personne(string Nom_, string Pre_)
		{
			ID = -1;
			Nom = Nom_;
			Pre = Pre_;
		}
		public Personne(int ID_, string Nom_, string Pre_) : this(Nom_, Pre_)
		{
			ID = ID_;
		}
	}

	public class CmdAssigner : ICommand
	{
		public event EventHandler CanExecuteChanged;
		private Action _Action;

		public CmdAssigner(Action Action_)
		{
			_Action = Action_;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			if (_Action != null) _Action();
		}
	}
}
