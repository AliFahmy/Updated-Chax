using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GroundEnemy : Enemy
{
   private Transform target;
    
    public Transform Target
    {
        get
        {
            return target;
        }
        set
        {
            target= value;
        }
    }
    public GroundEnemy()
    {
       
    }
}
