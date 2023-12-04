using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
   
       public Slider slider;
       public Gradient gradient;
       public Image fill;
       
       void Update()
       {
           if (slider.value <= slider.minValue)
           {
               
           }
       }
    
       public void SetMaxHealth(float maxHealthValue)
       {
           slider.maxValue = maxHealthValue;
           slider.value = maxHealthValue;
           fill.color = gradient.Evaluate(1f);
       }

 
  public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
  

  
}
