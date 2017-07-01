using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FightBack_SS
{
	public partial class SS_SideMenuMasterDetail : MasterDetailPage
	{
		public List<SideMenuItem> menuList { get; set; }

		public SS_SideMenuMasterDetail()
		{
            InitializeComponent(); BindingContext = new MenuViewModel();
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SS_HomeScreen)));

			navigationDrawerList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
			{
				var item = (SideMenuItem)e.SelectedItem;
				Type page = item.TargetType;

				if (item.Title.Equals("Logout"))
				{
					Application.Current.MainPage = new SS_LoginScreen();
				}
				else
				{
					Detail = new NavigationPage((Page)Activator.CreateInstance(page));
					IsPresented = false;
				}
			};
		}
	}
}