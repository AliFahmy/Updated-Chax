﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyMovement : MonoBehaviour {
    
    private SimpleEnemy enemy;
    private Transform target;
    private int waypointindex=0;
	// Use this for initialization
	void Start ()
    {
        enemy = new SimpleEnemy(WaveSpawner.wavenumber/3 +1 );
        Debug.Log(enemy.Level.ToString());
        target = WayPoints.waypoints[waypointindex];		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (enemy.Health <= 0)
        {
            //give coins and kill
            Destroy(gameObject);
        }
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.Speed *Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            if (waypointindex >= WayPoints.waypoints.Length-1)
            {
                Destroy(gameObject);
                return;
            }
            waypointindex++;
            target = WayPoints.waypoints[waypointindex];
        }	
	}
}