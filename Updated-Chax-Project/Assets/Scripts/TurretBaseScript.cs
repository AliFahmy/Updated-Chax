using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretBaseScript : MonoBehaviour {
    public TurretsBuilding turret;
    public Transform target;
    public Transform partToRotate;
    public float ReloadTime;
    public bool UseLaser=false;
    public LineRenderer linerenderer;
    public GameObject BulletPrefab;
    public Transform FirePoint;
    // Use this for initialization
    void Start () {
        turret = null;

	}

    void Rotate()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turret.RotationSpeed).eulerAngles;
        // fe hena 7aga msh fahmnha 
        if (target.transform.position.y > 5)
        {
            //3shan ybos 3la el fly
            partToRotate.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);
        }
        else
        {
            //3shan ybos 3la el ground
            partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }
    }
    public void RotateAndShoot()
    {
        if (target == null)
            return;
        // rotate for the target
        Rotate();
        firstShoot();
    }
    public virtual void firstShoot()
    {
        if (ReloadTime <= 0f)
        {
            Shoot();
            ReloadTime = 1f / turret.attackSpeed;
        }
        ReloadTime -= Time.deltaTime;
    }

    private void UpdateTarget()
    {

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestdistance = Mathf.Infinity;
        GameObject nearestenemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distancetocurrent = Vector3.Distance(transform.position, enemy.transform.position);
            if (distancetocurrent < shortestdistance)
            {
                shortestdistance = distancetocurrent;
                nearestenemy = enemy;
            }

        }

        if (nearestenemy != null && shortestdistance <= turret.range)
        {
            target = nearestenemy.transform;
        }
        else
        target = null;
    }

    private void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, turret.range);


    }
    public abstract void Shoot();
    // Update is called once per frame
    void Update ()
    {
       
	}
 
}
