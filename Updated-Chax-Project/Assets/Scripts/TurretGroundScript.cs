using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGroundScript : MonoBehaviour {
    private Renderer rend;
    private GameObject turret;
    public Color hovercolor;
    private Color normalcolor;
	private Vector3 halfabove;
    // Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        normalcolor = rend.material.color;
        halfabove = new Vector3(0f, 0.5f, 0f);
	}
    private void OnMouseDown()
    {
        if (turret!= null)
        {
            Debug.Log("there is some turret here display this");
            return;
        }

        GameObject turrettobuild = BuildManager.instance.GetTurrettoBuild();
        turret = Instantiate(turrettobuild, transform.position+halfabove, transform.rotation )as GameObject ;
        // build
    }
    private void OnMouseEnter()
    {
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
