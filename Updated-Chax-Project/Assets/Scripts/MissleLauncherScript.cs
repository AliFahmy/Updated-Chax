using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLauncherScript : MonoBehaviour {

    private TurretsBuilding turret;
    public Transform target;
    public float x;
    public Transform partToRotate;
    public float ReloadTime;
    public GameObject BulletPrefab;
    public Transform FirePoint;
    private void Start()
    {
        ReloadTime = 0;
        target = null;
        turret = new MissleTurret();
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    //gets the nearest target within our range (if exist )
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
    }

    private void Update()
    {
        if (target == null)
            return;
        // rotate for the target
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

        if (ReloadTime <= 0f)
        {
            Shoot();
            ReloadTime = 1f / turret.attackSpeed;
        }
        ReloadTime -= Time.deltaTime;
    }
    void Shoot()
    {
        // 3ali kfaya copy paste b2a :D
        GameObject bullet = (GameObject)Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        MissleBulletScript B = bullet.GetComponent<MissleBulletScript>();
        if (B != null)
        {
            B.missle = new MissleBullet(turret.attack);
            B.seek(target);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, turret.range);
    }
}
