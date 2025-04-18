﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarLogOutComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
		{
			var value = context.Admins.ToList();
			var admin = context.Admins.FirstOrDefault();
			if (admin != null)
			{
				ViewBag.photo = admin.ImageUrl;
			}

			return View(value);
		}
	}
}
