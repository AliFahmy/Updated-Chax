﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToughEnemyMovement : EnemyBaseScript
{
    
    private int waypointindex = 0;
    // Use this for initialization
    void Start()
    {
        enemy = new ToughEnemy();
        
        target = WayPoints.waypoints[waypointindex];
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.Speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            if (waypointindex >= WayPoints.waypoints.Length - 1)
            {
                AtEnd();
                return;
            }
            waypointindex++;
            target = WayPoints.waypoints[waypointindex];
        }
        return;

    }
}
