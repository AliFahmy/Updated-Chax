using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public GameObject StandardTurretPrefab;
    public GameObject MissleTurretPrefab;
    public GameObject LaserTurretPrefab;
    private GameObject turrettobuild;
    public static BuildManager instance;

    public static int turretcost;

    private void Awake()
    {
        if (instance!= null)
        {
            Debug.Log("More than one build manager in scene!");
            return;
        }
        instance = this;
    }
    public void selectedNode(TurretGroundScript Node)
    {

        turrettobuild = null;//while showing the ui of the turret we cant build one there 

    }
    public GameObject GetTurrettoBuild()
    {
        return turrettobuild;
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

    }
}
