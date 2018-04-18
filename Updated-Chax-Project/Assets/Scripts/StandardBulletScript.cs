using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//LAZEM NEFHM AL CLASS BY3ML EH 
public class StandardBulletScript : MonoBehaviour {
    private Transform target;
    private StandardBullet bullet;
    public GameObject Impacteffect;
    public void seek(Transform _target)
    {
        bullet = new StandardBullet();
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisframe = bullet.Speed * Time.deltaTime;
        if (dir.magnitude <= distanceThisframe)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisframe, Space.World);
        transform.LookAt(target);
    }
    void HitTarget()
    {
        GameObject EffectIns = (GameObject)Instantiate(Impacteffect, transform.position, transform.rotation);
        Destroy(EffectIns.gameObject, 2f);
        damage(target.transform);
        Debug.Log("Destroyed");
        Destroy(gameObject);
    }
    void damage(Transform todamage)
    {
        if (todamage.gameObject.GetComponent<SimpleEnemyMovement>() != null)
        {
            todamage.gameObject.GetComponent<SimpleEnemyMovement>().hitted(bullet.Power);

        }
        if (todamage.gameObject.GetComponent<FlyEnemyMovement>() != null)
        {
            todamage.gameObject.GetComponent<FlyEnemyMovement>().hitted(bullet.Power);
        }
        if (todamage.gameObject.GetComponent<ToughEnemyMovement>() != null)
        {
            todamage.gameObject.GetComponent<ToughEnemyMovement>().hitted(bullet.Power);
        }
    }
}
