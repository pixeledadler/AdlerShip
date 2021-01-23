using Adler.System.Ship.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Adler.System.Ship.Controllers
{
	public class RollListController : Controller
	{
		public ActionResult NewListItem(RollListViewModel model)
		{
			return View();
		}
	}
}