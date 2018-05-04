using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleBulletScript : MonoBehaviour {
    private Transform target;
    public Bullet missle;
    public GameObject Impacteffect;
	public void seek(Transform _target , int p)
    {
        // create missle object
        missle = new MissleBullet( p);
        // makes the target
        target = _target;
    }
    void Update()
    {
        // check if there is target to hit ( still alive )
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        //calculate the distance between the bullet and the target
        Vector3 dir = target.position - transform.position;
        // get the distance that the bullet will travel next frame
        float distanceThisframe = missle.Speed * Time.deltaTime;
        // check if the bullet will reach the target at the next frame
        if (dir.magnitude <= distanceThisframe)
        {
            // hits the target
            HitTarget();
            return;
        }
        // move the bullet toward the target
        transform.Translate(dir.normalized * distanceThisframe, Space.World);
        //make the bullet point at the target 
        transform.LookAt(target);
    }
    void HitTarget()
    {
        // make the missle effect
        GameObject EffectIns = (GameObject)Instantiate(Impacteffect, transform.position, transform.rotation);
        // destory the missle effect after 5 Seconds 
        Destroy(EffectIns.gameObject, 5f);
        // damage all enemy near but the target and the target itself
        Explode();

        Debug.Log("missle shooted");
        // destory the missle
        Destroy(gameObject);
    }
    void Explode()
    {
        //get all game objects in the area of the bullet explosion
        Collider[] nearby = Physics.OverlapSphere(transform.position, missle.ExplosionRadius);
        foreach (Collider near in nearby)
        {
            // damage every game object that have enemy tag
            if (near.tag=="Enemy")
            {

                damage(near.transform);
            }
        }
    }
    void damage(Transform todamage)
    {
        //damage the given gameobject
        if (todamage.gameObject.GetComponent<SimpleEnemyMovement>() != null)
        {
            todamage.gameObject.GetComponent<SimpleEnemyMovement>().hitted(missle.Power);

        }
        if (todamage.gameObject.GetComponent<FlyEnemyMovement>() != null)
        {
            todamage.gameObject.GetComponent<FlyEnemyMovement>().hitted(missle.Power);
        }
        if (todamage.gameObject.GetComponent<ToughEnemyMovement>() != null)
        {
            todamage.gameObject.GetComponent<ToughEnemyMovement>().hitted(missle.Power);
        }
        //Destroy(todamage.gameObject);
    }
    private void OnDrawGizmosSelected()
    {
        //change color of gizmo to red
        Gizmos.color = Color.red;
        //draw wired sphere around the game object with the gizmo color
        Gizmos.DrawWireSphere(transform.position, missle.ExplosionRadius);
    }
}
