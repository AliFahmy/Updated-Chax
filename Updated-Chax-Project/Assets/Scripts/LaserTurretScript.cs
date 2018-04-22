using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurretScript : TurretBaseScript {
	public LaserBullet laserbullet;
    private void Start()
    {
        ReloadTime = 0;
        target = null;
        turret = new LaserTurret();
		laserbullet = new LaserBullet (turret.attack);
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
		damage (target);
        
    }

		void damage(Transform todamage)
		{
			if (todamage.gameObject.GetComponent<SimpleEnemyMovement>() != null)
			{
			todamage.gameObject.GetComponent<SimpleEnemyMovement>().hitted(laserbullet.Power);

			}
			if (todamage.gameObject.GetComponent<FlyEnemyMovement>() != null)
			{
			todamage.gameObject.GetComponent<FlyEnemyMovement>().hitted(laserbullet.Power);
			}
			if (todamage.gameObject.GetComponent<ToughEnemyMovement>() != null)
			{
			todamage.gameObject.GetComponent<ToughEnemyMovement>().hitted(laserbullet.Power);
			}
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
