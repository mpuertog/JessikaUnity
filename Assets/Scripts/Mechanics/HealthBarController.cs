using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider slider;
    
    public void setMaxHealth(int mexHealth){
    	slider.maxValue = mexHealth;
    }
    public void setHeath(int health){
    	slider.value = health;
    }
   
}
