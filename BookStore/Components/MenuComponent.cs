﻿using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class MenuComponent:ViewComponent
    {
        private MenuService _menuService;

        public MenuComponent(MenuService menuService)
        {
            _menuService = menuService;
        }

        public IViewComponentResult Invoke()
        {
            List<Menu> menus = _menuService.GetAllMenus();
            return View(menus);
        }
    }
}
