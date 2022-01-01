using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour 
{

    // OBJECT ORIENTED TECHNIQUE: INHERITANCE

    // This is the SUPERCLASS for all characters in the game to inherit from

    // It comes with common attributes and functionality that characters can utilize

    // The PLAYER, the OPPONENTS, the FRIENDLY NPC's, everyone will inherit from this SUPERCLASS

    [SerializeField]
    public virtual int health { get; set; }


    public virtual int getHealth() 
    {
        return health;
    }

    public virtual void setHealth(int healthAmount) 
    {
        health = healthAmount;
    }

    // Fixed Update is called independant of the games framerate
    public virtual void FixedUpdate() 
    {
    
    
    }


}
