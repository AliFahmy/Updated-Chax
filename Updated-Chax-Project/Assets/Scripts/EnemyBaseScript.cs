using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class EnemyBaseScript : MonoBehaviour {
    protected Enemy enemy;
    [SerializeField]
    protected Transform target;
	public Image healthBar;
    bool killed = false;
    public void hitted(int damage)
    {
        enemy.Health -= damage;
		healthBar.fillAmount =  enemy.Health / enemy.MainHealth ;

        if (killed != true && enemy.Health <= 0)
        {
            killed = true;
            GameManagerScript.Game.Kills++;
            GameManagerScript.Game.Score += enemy.Score;
            GameManagerScript.Game.EnemiesAlive--;
            GameManagerScript.Game.Coins += enemy.KillReward;
            SoundManagerScript.playsound("Destroyed");
            Destroy(gameObject);
        }
    }
    public void Slow(float amount)
    {
        //if (enemy.CurrentSpeed==enemy.Speed)
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
