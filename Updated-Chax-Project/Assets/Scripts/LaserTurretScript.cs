using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurretScript : TurretBaseScript {
	public LaserBullet laserbullet;
    public ParticleSystem ImpactEffect;
    private float SlowingRate;
    private void Start()
    {
        SlowingRate = 0.5f;
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
	public void upgrade()
	{
		laserbullet.Power = turret.attack;
	}

    public override void Shoot()
    {
		Debug.Log (laserbullet.Power);
        if (!linerenderer.enabled)
        {
            linerenderer.enabled = true;
            ImpactEffect.Play();
        }
        linerenderer.SetPosition(0, FirePoint.position);
        linerenderer.SetPosition(1, target.position);
        Vector3 dir = FirePoint.position - target.position;
        ImpactEffect.transform.position = target.position+dir.normalized; 
        ImpactEffect.transform.rotation = Quaternion.LookRotation(dir);
        damage (target);
        
    }

		void damage(Transform todamage)
		{
			if (todamage.gameObject.GetComponent<SimpleEnemyMovement>() != null)
			{
			todamage.gameObject.GetComponent<SimpleEnemyMovement>().hitted(laserbullet.Power);
            todamage.gameObject.GetComponent<SimpleEnemyMovement>().Slow(SlowingRate);
            }
			if (todamage.gameObject.GetComponent<FlyEnemyMovement>() != null)
			{
			todamage.gameObject.GetComponent<FlyEnemyMovement>().hitted(laserbullet.Power);
            todamage.gameObject.GetComponent<FlyEnemyMovement>().Slow(SlowingRate);
        }
			if (todamage.gameObject.GetComponent<ToughEnemyMovement>() != null)
			{
			todamage.gameObject.GetComponent<ToughEnemyMovement>().hitted(laserbullet.Power);
            todamage.gameObject.GetComponent<ToughEnemyMovement>().Slow(SlowingRate);
        }
		}

    public void Update()
    {
        if (target == null)
        {
            if (linerenderer.enabled)
            {
                linerenderer.enabled = false;
                ImpactEffect.Stop();
            }
                return;
            
        }
        RotateAndShoot();
    }
}
