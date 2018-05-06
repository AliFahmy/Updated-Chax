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
        enemy.Health -= damage;
		healthBar.fillAmount =  enemy.Health / enemy.MainHealth ;

        if (enemy.Health <= 0)
        {
            GameManagerScript.Game.EnemiesAlive--;
            GameManagerScript.Game.Coins += enemy.KillReward;
            SoundManagerScript.playsound("Destroyed");
            Destroy(gameObject);
        }
    }
    public void Slow(float amount)
    {
        enemy.CurrentSpeed =enemy.Speed *amount;
    }
    public abstract void Move();
   
    protected void AtEnd()
    {

        GameManagerScript.Game.EnemiesAlive--;
        GameManagerScript.Game._Lives--;
        Destroy(gameObject);
    }

}
