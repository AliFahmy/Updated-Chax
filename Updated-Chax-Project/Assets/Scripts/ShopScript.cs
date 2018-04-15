using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour {
    BuildManager buildmanager;
    private StandardTurret turret;
    private void Start()
    {
        turret = new StandardTurret();
        buildmanager = BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        if (GameManagerScript.Game.Coins >= turret.cost)
        {
            Debug.Log(GameManagerScript.Game.Coins);
            Debug.Log(turret.cost);
            buildmanager.SetTurretToBuild(buildmanager.StandardTurretPrefab);
            GameManagerScript.Game.Coins -= turret.cost;

        }
        else
        {
            Debug.Log("cannot buy this :(");
        }
    }
}
