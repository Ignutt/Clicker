using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
   private int _cookieCount = 1;

   public Color targetColor;
   private Color defaultColor;

   private void Start()
   {
      defaultColor = GetComponent<SpriteRenderer>().color;
   }

   public void IncreaseCookieCount(int value )
   {
      _cookieCount += value;
      Debug.Log(_cookieCount);
   }

   public void OnMouseDown()
   {
      IncreaseCookieCount(1);
      SetToTargetColor();
   }

   public void OnMouseUp()
   {
      SetToDefaultColor();
   }

   public void SetToTargetColor()
   {
      GetComponent<SpriteRenderer>().color = targetColor;
   }
   
   public void SetToDefaultColor(){GetComponent<SpriteRenderer>().color = defaultColor;}
   
}
