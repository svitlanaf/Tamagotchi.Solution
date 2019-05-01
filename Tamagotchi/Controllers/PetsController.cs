using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpPost("/object")]
    public ActionResult Create()
    {
      Pet myPet = new Pet();
      return View("Index", myPet);
    }


    [HttpGet("/object")]
    public ActionResult Index(Pet pet)
    {
      return View(pet);
    }

  }
}
