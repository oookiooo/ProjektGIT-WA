using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project1.Data;
using Project1.Models;
using System.Diagnostics;

namespace Project1.Controllers
{
    public class CardsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public CardsController( ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            
            _context = context;
            _userManager = userManager;
           
        }
        //public string CardId { get; set; }


        //public string NameCard { get; set; }

        //public int? Cost { get; set; }
        //public int? AttackDamage { get; set; }
        //public int? Hp { get; set; }
        [HttpGet("addCard")]
        public async Task AddCard()
        {
            Cards cards = new Cards { CardId="1" ,NameCard = "test",Cost=12,AttackDamage=13,Hp=13 };
                _context.Cards.Add(cards);
                await _context.SaveChangesAsync();
               
        }
    }
}
