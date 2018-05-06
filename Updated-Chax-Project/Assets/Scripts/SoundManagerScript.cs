using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip missleshoot,standardshoot,lasershoot,destroyed,buyturret;
    static AudioSource AS,AH;
    // Use this for initialization
	void Start ()
    {
        
        missleshoot = Resources.Load<AudioClip>("Missile+2");
        standardshoot = Resources.Load<AudioClip>("Bomb+1");
        lasershoot = Resources.Load<AudioClip>("Laser2");
        destroyed = Resources.Load<AudioClip>("Explosion1");
        buyturret = Resources.Load<AudioClip>("buyitem");
        AS = GetComponent<AudioSource>();
        AH = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public static void playsound(string s)
    {
        if (s == "missleshoot")
        {
           
            AS.PlayOneShot(missleshoot);
        }
        else if (s == "standardshoot")
        {
            AS.volume = 0.1f;
            AS.PlayOneShot(standardshoot);
        }
        else if (s == "Lasershoot")
        {
            Debug.Log("laser");
            AS.volume = .1f;
            AS.PlayOneShot(lasershoot);
        }
        else if (s == "Destroyed")
        {
            AS.PlayOneShot(destroyed);
        }
        else if (s == "buyturret")
        {
            Debug.Log("buyyyy");
            AS.volume = 1f;
            AS.PlayOneShot(buyturret);
        }
    }
}
