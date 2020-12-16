using System.Windows;
using MVVM_Example.ViewModel;

namespace MVVM_Example {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		private readonly MainWindowViewModel ViewModel;
		public MainWindow() {

			ViewModel = new MainWindowViewModel();
			DataContext = ViewModel;

			InitializeComponent();
		}
	}
}
