using System;
using System.Collections.Generic;

namespace FightBack_SS
{
	public class MenuViewModel
	{
		public List<SideMenuItem> MenuItems
		{
			get;
		}
		public MenuViewModel()
		{
			MenuItems = new List<SideMenuItem>();

			var page1 = new SideMenuItem() { Title = "Home", Icon = "SideMenu_Home.png", TargetType = typeof(SS_HomeScreen) };
			var page2 = new SideMenuItem() { Title = "Situation CheckList", Icon = "SideMenu_Checklist.png",TargetType = typeof(SS_SituationChecklistScreen)};
			var page3 = new SideMenuItem() { Title = "Legal Help", Icon = "SideMenu_LegalHelp.png"};
			var page4 = new SideMenuItem() { Title = "Demo Video", Icon = "SideMenu_Video.png"};
			var page5 = new SideMenuItem() { Title = "Follow Up", Icon = "SideMenu_FollowUp.png"};
			var page6 = new SideMenuItem() { Title = "Contact Us", Icon = "SideMenu_ContactUs.png"};
			var page7 = new SideMenuItem() { Title = "Logout", Icon = "SideMenu_Logout.png" };


			// Adding menu items to menuList
			MenuItems.Add(page1);
			MenuItems.Add(page2);
			MenuItems.Add(page3);
			MenuItems.Add(page4);
			MenuItems.Add(page5);
			MenuItems.Add(page6);
			MenuItems.Add(page7);
		}
	}
}