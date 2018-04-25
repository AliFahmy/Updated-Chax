using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public GameObject StandardTurretPrefab;
    public GameObject MissleTurretPrefab;
    public GameObject LaserTurretPrefab;
    private GameObject turrettobuild;
    public static BuildManager instance;
	TurretGroundScript SelectedTurret;
    public static int turretcost;
	public TurretUIScript turretUI;
    private void Awake()
    {
        if (instance!= null)
        {
            Debug.Log("More than one build manager in scene!");
            return;
        }
        instance = this;
    }
    public void selectNode(TurretGroundScript Node)
    {
		SelectedTurret = Node;
		turretUI.setGround (Node);
        turrettobuild = null;//while showing the ui of the turret we cant build one there 

    }
    public void SetTurretToBuild( GameObject t )
    {

        if (t==StandardTurretPrefab)
        {
            turretcost = GameManagerScript.Game.standardTurretTemp.cost;
        }
        else if (t==MissleTurretPrefab)
        {
            turretcost = GameManagerScript.Game.missleLuncherTemp.cost;
        }
        else if (t == LaserTurretPrefab)
        {
            turretcost = GameManagerScript.Game.LaserTurretTemp.cost;
        }
        turrettobuild = t;
		SelectedTurret = null;
		turretUI.Hide ();
    }
	public GameObject GetTurrettoBuild()
	{
		return turrettobuild;
	}
}
