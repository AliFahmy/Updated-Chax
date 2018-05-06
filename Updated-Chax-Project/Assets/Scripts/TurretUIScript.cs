using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurretUIScript : MonoBehaviour {
	private TurretGroundScript currentGround;
	public GameObject ui ;
	public Text upgradetext;
	public Text selltext;
	public void setGround(TurretGroundScript ground)
	{
		if (currentGround == ground) 
		{
			deselectGround ();
			return;
		}
		if (ground.turret.GetComponent<LaserTurretScript> () != null) {
			upgradetext.text = "Upgrade\n"+ground.turret.GetComponent<LaserTurretScript> ().turret.Upgradecost+'$';
		}
		else if (ground.turret.GetComponent<MissleLauncherScript> () != null) {
			upgradetext.text = "Upgrade\n"+ground.turret.GetComponent<MissleLauncherScript> ().turret.Upgradecost+'$';
		}
		else if (ground.turret.GetComponent<StandardTurretScript> () != null) {
			upgradetext.text = "Upgrade\n"+ground.turret.GetComponent<StandardTurretScript> ().turret.Upgradecost+'$';
		}

		if (ground.turret.GetComponent<LaserTurretScript> () != null) {
			selltext.text = "Sell\n"+ground.turret.GetComponent<LaserTurretScript> ().turret.CalculateSellCost()+'$';
		}
		else if (ground.turret.GetComponent<MissleLauncherScript> () != null) {
			selltext.text = "Sell\n"+ground.turret.GetComponent<MissleLauncherScript> ().turret.CalculateSellCost()+'$';
		}
		else if (ground.turret.GetComponent<StandardTurretScript> () != null) {
			selltext.text = "Sell\n"+ground.turret.GetComponent<StandardTurretScript> ().turret.CalculateSellCost()+'$';
		}
		currentGround = ground;

		transform.position = ground.GetBuildPosition ();

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
