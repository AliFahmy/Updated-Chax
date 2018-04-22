using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TurretGroundScript : MonoBehaviour {
    private Renderer rend;
    private GameObject turret;
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
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurrettoBuild() == null)
            return;

        if (turret!= null)
        {
            return;
        }
        
        if (GameManagerScript.Game.Coins>=BuildManager.turretcost)
        {

        GameManagerScript.Game.Coins -= BuildManager.turretcost;
        GameObject turrettobuild = buildManager.GetTurrettoBuild();
        turret = Instantiate(turrettobuild, transform.position+halfabove, transform.rotation )as GameObject ;
       GameObject effect=(GameObject) Instantiate(BuildEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
           
       
        }
        // build
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
