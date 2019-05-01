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
  }
