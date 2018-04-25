using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUIScript : MonoBehaviour {
	private TurretGroundScript currentGround;
	public GameObject ui ;
	public void setGround(TurretGroundScript ground)
	{
		if (currentGround == ground) {
			deselectGround ();
			return;
		}

		currentGround = ground;
		transform.position = ground.GetBuildPosition ();

		ui.SetActive (true);
	}
	public void deselectGround()
	{
		currentGround = null;
		ui.SetActive (false);
	}
	public void Hide()
	{
		deselectGround ();
	}
}
