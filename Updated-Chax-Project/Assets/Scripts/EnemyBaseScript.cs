using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class EnemyBaseScript : MonoBehaviour {
    protected Enemy enemy;
    [SerializeField]
    protected Transform target;
	public Image healthBar;
    public void hitted(int damage)
    {
        Debug.Log("health before hit : " + enemy.Health);
        enemy.Health -= damage;
		healthBar.fillAmount =  enemy.Health / enemy.MainHealth ;
        Debug.Log("health After hit : " + enemy.Health);
        if (enemy.Health <= 0)
        {
            GameManagerScript.Game.EnemiesAlive--;
            GameManagerScript.Game.Coins += enemy.KillReward;
            Destroy(gameObject);
        }
    }
    public abstract void Move();
   
    protected void AtEnd()
    {

        GameManagerScript.Game.EnemiesAlive--;
        GameManagerScript.Game._Lives--;
        Destroy(gameObject);
    }
}
