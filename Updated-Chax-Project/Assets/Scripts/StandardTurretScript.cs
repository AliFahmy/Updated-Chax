using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTurretScript : TurretBaseScript {
    
    private void Start()
    {
        ReloadTime = 0;
        target = null;
        turret = new StandardTurret();
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    //gets the nearest target within our range (if exist )
    

    private void Update()
    {
        RotateAndShoot();
    }

    public override void Shoot()
    {
        GameObject bullet = (GameObject)Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        StandardBulletScript B = bullet.GetComponent<StandardBulletScript>();
        if (B != null)
        {
			Debug.Log (turret.attack);
            //B.bullet = new StandardBullet(turret.attack);
			B.seek(target ,turret.attack );
        }
        return; 
    }


}
