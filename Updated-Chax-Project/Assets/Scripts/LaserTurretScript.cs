using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurretScript : TurretBaseScript {

    private void Start()
    {
        ReloadTime = 0;
        target = null;
        turret = new LaserTurret();
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    public override void firstShoot()
    {
        Shoot();
    }


    public override void Shoot()
    {
        if (!linerenderer.enabled)
            linerenderer.enabled = true;
        linerenderer.SetPosition(0, FirePoint.position);
        linerenderer.SetPosition(1, target.position);
        
    }
    public void Update()
    {
        if (target == null)
        {
            
                if (linerenderer.enabled)
                    linerenderer.enabled = false;
                return;
            
        }
        RotateAndShoot();
    }
}
