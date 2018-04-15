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

    private BuildManager buildManager;
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
            Debug.Log("there is some turret here display this");
            return;
        }

        GameObject turrettobuild = buildManager.GetTurrettoBuild();
        turret = Instantiate(turrettobuild, transform.position+halfabove, transform.rotation )as GameObject ;
        buildManager.SetTurretToBuild(null);
        // build
    }
    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTurrettoBuild() == null)
            return;
        rend.material.color = hovercolor;
    }
    private void OnMouseExit()
    {
        rend.material.color = normalcolor;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
