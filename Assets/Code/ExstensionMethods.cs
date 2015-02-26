using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public static class ExstensionMethods
{
  public static void SetX(this Vector2 sorce, float x)
  {
    sorce = new Vector2(x, sorce.y);
  }

  public static void SetY(this Vector2 sorce, float y)
  {
    sorce = new Vector2(sorce.x, y);
  }

}
