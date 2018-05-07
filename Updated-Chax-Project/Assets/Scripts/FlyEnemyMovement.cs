using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemyMovement : EnemyBaseScript
{
    
    // Use this for initialization
    void Start()
    {
        enemy = new FlyEnemy(WaveSpawner.EnemyStartLevel);

    }
    
    // Update is called once per frame
    void Update()
    {
        //if (enemy.Health <= 0)
        //{
        //    //give coins and kill
        //    Destroy(gameObject);
        //}
        Move();
        enemy.CurrentSpeed = enemy.Speed;

    }
    public override void Move()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.CurrentSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            AtEnd();
        }
        return;

    }


}
