using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLauncherScript : TurretBaseScript {

    
    private void Start()
    {
        ReloadTime = 0;
        target = null;
        turret = new MissleTurret();
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    

    private void Update()
    {
        RotateAndShoot();
    }
    public override void Shoot()
    {
        GameObject bullet = (GameObject)Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        MissleBulletScript B = bullet.GetComponent<MissleBulletScript>();
        if (B != null)
        {
			B.seek(target , turret.attack);
        }
    }
    
}
