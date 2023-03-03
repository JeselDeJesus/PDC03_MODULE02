using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity5 : ContentPage
	{ 
        ObservableCollection<employee> employees = new ObservableCollection<employee>();

		public ObservableCollection<employee> Employees { get { return employees; } }
	
		public Activity5 ()
		{
			InitializeComponent ();

			{
				lst.ItemsSource= employees;

				employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", profileimage="img1.jpg" });
				employees.Add(new employee { DisplayName = "Peter", Position = "Vice President", profileimage = "img2.jpg" });
				employees.Add(new employee { DisplayName = "Mercy", Position = "Secretary", profileimage = "img3.jpg" });
			}
		}
	}
}
