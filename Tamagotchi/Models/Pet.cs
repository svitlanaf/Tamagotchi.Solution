using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private int _hungry;
    private int _tired;
    private int _bored;
    private int _id;


    private static List<Pet> _allPets = new List<Pet>{};

    public static List<Pet> GetAllPets()
    {
      return _allPets;
    }

    public static void ClearAll()
    {
      _allPets.Clear();
    }

    public static Pet Find(int id)
    {
      return _allPets[id-1];
    }

    public static void TimePass()
    {
      foreach(Pet myPet in _allPets)
      {
        myPet._hungry++;
        myPet._tired++;
        myPet._bored++;
      }
    }

    public Pet()
    {
      _hungry = 5;
      _tired = 5;
      _bored = 5;

      _allPets.Add(this);

      _id = _allPets.Count;
    }

    public int GetId()
    {
      return _id;
    }

    public int GetHungry()
    {
      return _hungry;
    }

    public int GetTired()
    {
      return _tired;
    }

    public int GetBored()
    {
      return _bored;
    }

    public void FeedPet()
    {
      if (_hungry>0)
      {
        _hungry--;
      }

    }

    public void PutToBed()
    {
      if (_tired>0)
      {
      _tired--;
      }
    }

    public void PlayWithPet()
    {
      if (_bored>0)
      {
      _bored--;
      }
    }

    public string GetImage()
    {
      float average = (_hungry + _tired + _bored)/3;
      if(_hungry>9 || _tired>9 || _bored>9)
      {
        return "dead.png";
      }
      if(_hungry==9 || _tired==9 || _bored==9)
      {
        return "almost_dead.png";
      }
      if(average < 3)
      {
        return "happy.png";
      }
      if(average <= 6)
      {
        return "ok.png";
      }
      else
      {
        return "upset.png";
      }
    }
  }
}
