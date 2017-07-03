using System;
using System.Threading.Tasks;

namespace FightBack_SS
{
	public interface IAppHandler
	{
		Task<bool> LaunchApp(string uri);
	}
}
