using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public GameObject StandardTurretPrefab;
    public GameObject MissleTurretPrefab;
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
        turrettobuild = t;
    }
}
