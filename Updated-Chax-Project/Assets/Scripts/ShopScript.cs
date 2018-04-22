using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour {
    BuildManager buildmanager;
    //private StandardTurret turret;
    //private MissleTurret missleturret;
    
    private void Start()
    {
        //missleturret = new MissleTurret();
        //turret = new StandardTurret();
        buildmanager = BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        buildmanager.SetTurretToBuild(buildmanager.StandardTurretPrefab);

    }

    public void PurchaseMissleTurret()
    {
        buildmanager.SetTurretToBuild(buildmanager.MissleTurretPrefab);
    }
    public void PurchaseLaserTurret()
    {
        buildmanager.SetTurretToBuild(buildmanager.LaserTurretPrefab);
    }
}
