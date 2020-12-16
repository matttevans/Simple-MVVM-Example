using System.ComponentModel;

namespace MVVM_Example.ViewModel {

	public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged {

		public DelegateCommand<object> ShowTextCommand { get; }

		private string m_ButtonContent = "Click me!";
		public string ButtonContent {

			get => m_ButtonContent;
			set => SetProperty(ref m_ButtonContent, value);
		}

		private string m_LabelContent;
		public string LabelContent {

			get {

				return m_LabelContent;
			}
			set {

				if(m_LabelContent != value) {
					m_LabelContent = value;
					OnPropertyChanged(nameof(LabelContent));
				}
			}
		}

		#region Main constructor
		public MainWindowViewModel() : base() {

			ShowTextCommand = new DelegateCommand<object>(ShowText);
		}
		#endregion

		private void ShowText(object obj) {

			LabelContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod...";
		}

		#region Property changed & validation
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}
