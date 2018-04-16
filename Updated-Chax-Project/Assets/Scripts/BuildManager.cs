using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    private void Awake()
    {
        if (instance!= null)
        {
            Debug.Log("More than one build manager in scene!");
            return;
        }
        instance = this;
    }
    
    public GameObject StandardTurretPrefab;
    public GameObject MissleTurretPrefab;
    private GameObject turrettobuild;
    public GameObject GetTurrettoBuild()
    {
        return turrettobuild;
    }
    public void SetTurretToBuild( GameObject t )
    {
        turrettobuild = t;
    }
}
