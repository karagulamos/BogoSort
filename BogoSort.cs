using System;

public class BogoSort
{
  private readonly int[] _items;
  private readonly Random _rand;

  public BogoSort(int[] items)
  {
    _items = items;
    _rand = new Random((int)DateTime.Now.Ticks);
  }

  public void Sort()
  {
    while(!Sorted)
    {
      Shuffle();
      Passes++;
    }
  }

  public int Passes { get; private set; }

  public bool Sorted
  { 
    get
    {
      for(var idx = 1; idx < _items.Length; idx++)
      {
        if(_items[idx-1] > _items[idx])
          return false;
      }

      return true;
    }
  }

  // Fisher-Yates Shuffle
  private void Shuffle()
  {
    for(var idx = _items.Length-1; idx >= 0; idx--)
    {
      var random = _rand.Next(0, idx);

      var temp = _items[idx];
      _items[idx] = _items[random];
      _items[random] = temp;
    }
  }
}
