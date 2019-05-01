using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private int _hungry;
    private int _tired;
    private int _bored;

    public Pet()
    {
      _hungry = 5;
      _tired = 5;
      _bored = 5;
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
      int average = (_hungry + _tired + _bored)/3;
      if(_hungry>9 || _tired>9 || _bored>9)
      {
        return "dead.png";
      }
      if(_hungry==9 || _tired==9 || _bored==9)
      {
        return "almost_dead.png";
      }
      if(average <= 3)
      {
        return "happy.png";
      }
      if(average <= 6)
      {
        return "ok.png";
      }
      if(average >6)
      {
        return "upset.png";
      }
    }
  }
}
