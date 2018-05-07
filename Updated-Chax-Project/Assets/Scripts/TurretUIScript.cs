using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurretUIScript : MonoBehaviour {
	private TurretGroundScript currentGround;
	public GameObject ui ;
	public Text upgradetext;
	public Text selltext;
	public Text InfoText;
	public void setGround(TurretGroundScript ground)
	{
		if (currentGround == ground) 
		{
			deselectGround ();
			return;
		}

		TurretsBuilding tempturret ;
		if (ground.turret.GetComponent<LaserTurretScript> () != null) {
			tempturret = ground.turret.GetComponent<LaserTurretScript> ().turret;
			//upgradetext.text = "Upgrade\n"+ground.turret.GetComponent<LaserTurretScript> ().turret.Upgradecost+'$';
		}
		else if (ground.turret.GetComponent<MissleLauncherScript> () != null) {
			tempturret = ground.turret.GetComponent<MissleLauncherScript> ().turret;
			//upgradetext.text = "Upgrade\n"+ground.turret.GetComponent<MissleLauncherScript> ().turret.Upgradecost+'$';
		}
		else {
			tempturret = ground.turret.GetComponent<StandardTurretScript> ().turret;
		}
		upgradetext.text = "Upgrade\n"+tempturret.Upgradecost+'$';
		selltext.text = "Sell\n" + tempturret.CalculateSellCost() + '$';
		InfoText.text = "Level : " + tempturret.level+"     ";
		InfoText.text += "Attack : " + tempturret.attack +"\n";
		InfoText.text += "Range : " + tempturret.range +"\n";
		InfoText.text += "Speed : " +(tempturret.attackSpeed) + @" attack/Sec" ;
		currentGround = ground;

		transform.position = ground.GetBuildPosition ();
		// to fix ui position
		transform.position += new Vector3 (0, -2.5f, 5f);
		ui.SetActive (true);
	}
	public void Upgrade()
	{
		currentGround.UpgradeCurrentTurret ();
		deselectGround ();	

	}
	public void sell()
	{
		currentGround.SellTurret ();
		deselectGround ();
	}
	public void deselectGround()
	{
		currentGround = null;
		ui.SetActive (false);
	}
	public void Hide()
	{
		deselectGround ();
	}
}
