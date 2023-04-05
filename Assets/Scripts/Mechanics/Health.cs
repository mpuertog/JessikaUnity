using System;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Represebts the current vital statistics of some game entity.
    /// </summary>
    public class Health : MonoBehaviour
    {
        /// <summary>
        /// The maximum hit points for the entity.
        /// </summary>
        public int maxHP = 100;

        /// <summary>
        /// Indicates if the entity should be considered 'alive'.
        /// </summary>
        public bool IsAlive => currentHP > 0;

        int currentHP;
        
        public HealthBarController barcontroller;
        
        public void setHbc(HealthBarController hbc){
	        barcontroller = hbc;
	        hbc.setMaxHealth(100);
	        hbc.setHeath(100);
        }
        /// <summary>
        /// Increment the HP of the entity.
        /// </summary>
        public void Increment()
        {
            currentHP = currentHP + 10;
            if(currentHP > 100){
            	currentHP = 100;
            }
            //barcontroller.setHeath(currentHP);
            //currentHP = Mathf.Clamp(currentHP + 10, 0, maxHP);
        }

        /// <summary>
        /// Decrement the HP of the entity. Will trigger a HealthIsZero event when
        /// current HP reaches 0.
        /// </summary>
        public void Decrement()
        {
            //currentHP = Mathf.Clamp(currentHP - 1, 0, maxHP);
            currentHP = currentHP -50;
       
            if (currentHP <= 0)
            {	
            	currentHP = 0;
                var ev = Schedule<HealthIsZero>();
                ev.health = this;
                
            }
            //barcontroller.setHeath(currentHP);
        }

        /// <summary>
        /// Decrement the HP of the entitiy until HP reaches 0.
        /// </summary>
        public void Die()
        {
            while (currentHP > 0) Decrement();
        }
        
        public void reset(){
            currentHP = 100;
            //barcontroller.setMaxHealth(currentHP);
            //barcontroller.setHeath(currentHP);
        }

        void Awake()
        {

           // barcontroller = GetComponent<HealthBarController>();
            currentHP = 100;
           // barcontroller.setMaxHealth(currentHP);
           // barcontroller.setHeath(currentHP);
        }
    }
}
