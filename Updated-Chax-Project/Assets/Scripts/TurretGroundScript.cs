using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TurretGroundScript : MonoBehaviour {
	private GameObject turret;

    private Renderer rend;
    public Color hovercolor;
    private Color normalcolor;
	private Vector3 halfabove;
    
	public Color NotEnoughMoney;
    private BuildManager buildManager;
    
	public GameObject BuildEffect;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        normalcolor = rend.material.color;
        halfabove = new Vector3(0f, 0.5f, 0f);


        buildManager = BuildManager.instance;
	}

	public Vector3 GetBuildPosition()
	{
		return this.transform.position + halfabove;
	}
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;


        if (turret!= null)
        {
			buildManager.selectNode(this);
            return;
        }
		if (buildManager.GetTurrettoBuild() == null)
			return;
        
		// build
        if (GameManagerScript.Game.Coins>=BuildManager.turretcost)
        {

        GameManagerScript.Game.Coins -= BuildManager.turretcost;
        GameObject turrettobuild = buildManager.GetTurrettoBuild();
        turret = Instantiate(turrettobuild, transform.position+halfabove, transform.rotation )as GameObject ;
       	GameObject effect=(GameObject) Instantiate(BuildEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
           
       
        }
    }
	public void SellTurret ()
	{
		if (turret.GetComponent<StandardTurretScript>() != null) {
			GameManagerScript.Game.Coins += turret.GetComponent<StandardTurretScript> ().turret.cost / 2;
			//turret = null;
			Destroy (turret.gameObject);
			return;
		}
		if (turret.GetComponent<MissleLauncherScript>() != null) {
			GameManagerScript.Game.Coins += turret.GetComponent<MissleLauncherScript> ().turret.cost / 2;
			Destroy (turret.gameObject);
			return;
		}
		if (turret.GetComponent<LaserTurretScript>() != null) {
			GameManagerScript.Game.Coins += turret.GetComponent<LaserTurretScript> ().turret.cost / 2;
			//turret = null;
			Destroy (turret.gameObject);
			return;
		}
	}

	public void UpgradeCurrentTurret()
	{
		if (turret.GetComponent<StandardTurretScript>() != null) {
			if (GameManagerScript.Game.Coins >= turret.GetComponent<StandardTurretScript> ().turret.Upgradecost) {
				GameManagerScript.Game.Coins -= turret.GetComponent<StandardTurretScript> ().turret.Upgradecost;
				turret.GetComponent<StandardTurretScript> ().turret.UpgradeTurret ();
			}
			return;
		}
		if (turret.GetComponent<MissleLauncherScript>() != null) {
			if (GameManagerScript.Game.Coins >= turret.GetComponent<MissleLauncherScript> ().turret.Upgradecost) {
				GameManagerScript.Game.Coins -= turret.GetComponent<MissleLauncherScript> ().turret.Upgradecost;
				turret.GetComponent<MissleLauncherScript> ().turret.UpgradeTurret ();
			}
			return;
		}
		if (turret.GetComponent<LaserTurretScript>() != null) {
			if (GameManagerScript.Game.Coins >= turret.GetComponent<LaserTurretScript> ().turret.Upgradecost) 
			{
				GameManagerScript.Game.Coins -= turret.GetComponent<LaserTurretScript> ().turret.Upgradecost;
				turret.GetComponent<LaserTurretScript> ().turret.UpgradeTurret ();
				//turret.GetComponent<LaserTurretScript> ().upgrade ();
				turret.GetComponent<LaserTurretScript> ().laserbullet.Power = turret.GetComponent<LaserTurretScript> ().turret.attack;

			}
			return;
		}
	}
    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTurrettoBuild() == null)
            return;
        if (GameManagerScript.Game.Coins >= BuildManager.turretcost)
        {
            rend.material.color = hovercolor;
        }
        else
        {
            rend.material.color = NotEnoughMoney;
        }
    }
    private void OnMouseExit()
    {
        rend.material.color = normalcolor;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
