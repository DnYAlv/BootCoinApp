﻿using BootCoinApp.Data;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace BootCoinApp.Controllers
{
    public class CoinController : Controller
    {
        private readonly AppDbContext _context;
        public CoinController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult CoinPeople(string query="")
        {
            IEnumerable<User> users = _context.Users.ToList();
            if (!string.IsNullOrEmpty(query))
            {
                users = users.Where(u => u.FullName.ToLower().Contains(query.ToLower()));
            }
            return View(users);
        }

        public IActionResult CoinGroup(string query="")
        {
            IEnumerable<GroupUser> groups = _context.GroupUsers.ToList();
            if (!string.IsNullOrEmpty(query))
            {
                groups = groups.Where(g => g.GroupName.ToLower().Contains(query.ToLower()));
            }
            return View(groups);
        }

        public IActionResult CoinSelect(string query="")
        {
            IEnumerable<AddCoinCategory> coins = _context.AddCoinCategories.ToList();
            if (!string.IsNullOrEmpty(query))
            {
                coins = coins.Where(c => c.AddCoinCategoryName.ToLower().Contains(query.ToLower()));
            }
            return View(coins);
        }

        public IActionResult CoinSelectGroup(string query="")
        {
            IEnumerable<AddCoinCategory> coins = _context.AddCoinCategories.ToList();
            if (!string.IsNullOrEmpty(query))
            {
                coins = coins.Where(c => c.AddCoinCategoryName.ToLower().Contains(query.ToLower()));
            }
            return View(coins);
        }

        public IActionResult AddCoinCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCoinCategory(AddCoinCategory coin)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.AddCoinCategories.Add(coin);
            _context.SaveChanges();
            return Redirect("CoinPeople");
        }

        [HttpPost]
        public IActionResult AddCoinToUser(string coins, string userList)
        {
            if (string.IsNullOrEmpty(userList) || string.IsNullOrEmpty(coins))
            {
                return Redirect("CoinPeople");
            }
            var tempList = userList.Split(",");
            var coinList = coins.Split(",");
            int tempCoins = 0;
            List<User> usersAll = _context.Users.ToList();
            foreach (var item in coinList)
            {
                tempCoins += int.Parse(item);
            }
            var j = tempCoins;
            foreach (var item in tempList)
            {
                foreach (var userTemp in usersAll)
                {
                    int x = int.Parse(item);
                    if(userTemp.Id == x)
                    {
                        var user = _context.Users.Where(u => u.Id == x).FirstOrDefault();
                        user.Bootcoin += tempCoins;
                        _context.Update(user);
                        _context.SaveChanges();
                    }
                }
            }
            return Redirect("CoinPeople");
        }
        [HttpPost]
        public IActionResult AddCoinToGroup(string coins, string userList)
        {
            if (string.IsNullOrEmpty(userList) || string.IsNullOrEmpty(coins))
            {
                return Redirect("CoinGroup");
            }
            var tempList = userList.Split(",");
            var coinList = coins.Split(",");
            int tempCoins = 0;
            List<GroupUser> usersAll = _context.GroupUsers.ToList();
            foreach (var item in coinList)
            {
                tempCoins += int.Parse(item);
            }
            var j = tempCoins;
            foreach (var item in tempList)
            {
                foreach (var groupTemp in usersAll)
                {
                    int x = int.Parse(item);
                    if (groupTemp.Id == x)
                    {
                        var group = _context.GroupUsers.Where(u => u.Id == x).FirstOrDefault();
                        group.Bootcoin += tempCoins;
                        _context.Update(group);
                        _context.SaveChanges();
                    }
                }
            }
            return Redirect("CoinGroup");
        }
        [HttpPost]
        public IActionResult PassingUser(string temp)
        {
            if (temp.IsNullOrEmpty())
            {
                return Redirect("CoinPeople");
            }
            TempData["tempList"] = temp;
            return Redirect("CoinSelect");
        }
        [HttpPost]
        public IActionResult PassingGroup(string temp)
        {
            if (temp.IsNullOrEmpty())
            {
                return Redirect("CoinGroup");
            }
            TempData["tempList"] = temp;
            return Redirect("CoinSelectGroup");
        }
    }
}
