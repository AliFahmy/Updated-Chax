using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GroundEnemy : Enemy
{
   private Transform target;
    //private int index;
    //public int Index
    //{
    //    get
    //    {
    //        return index;
    //    }
    //    set
    //    {
    //        Index = value ;
    //    }
    //}
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
