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
      Pet.ClearAll();
      Pet myPet = new Pet();
      return RedirectToAction("Index");
    }


    [HttpGet("/object")]
    public ActionResult Index()
    {
      List<Pet> allPets = Pet.GetAllPets();
      return View(allPets);
    }

    [HttpPost("/object/{thingToDo}/{id}")]
    public ActionResult Update(string thingToDo, int id)
    {
      Pet myPet = Pet.Find(id);
      if(thingToDo == "nap")
      {
        myPet.PutToBed();
      }
      if(thingToDo == "feed")
      {
        myPet.FeedPet();
      }
      if(thingToDo == "play")
      {
        myPet.PlayWithPet();
      }
      return RedirectToAction("Index");
    }

    [HttpPost("/object/timepass")]
    public ActionResult Update()
    {
      Pet.TimePass();
      return RedirectToAction("Index");
    }
  }
}
