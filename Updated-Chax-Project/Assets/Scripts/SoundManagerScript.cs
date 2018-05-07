using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip missleshoot,standardshoot,lasershoot,destroyed,buyturret,ticker,sell,upgrade;
    static AudioSource AS;
    // Use this for initialization
	void Awake ()
    {
        upgrade = Resources.Load<AudioClip>("DM-CGS-28");    
        missleshoot = Resources.Load<AudioClip>("Missile+2");
        standardshoot = Resources.Load<AudioClip>("Bomb+1");
        lasershoot = Resources.Load<AudioClip>("Laser2");
        destroyed = Resources.Load<AudioClip>("Explosion1");
        buyturret = Resources.Load<AudioClip>("buyitem");
        ticker = Resources.Load<AudioClip>("DM-CGS-20");
        sell = Resources.Load<AudioClip>("DM-CGS-35");
        AS = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public static void playsound(string s)
    {
        if (s == "missleshoot")
        {
            AS.volume = 1f;
            AS.PlayOneShot(missleshoot);
        }
        else if (s == "standardshoot")
        {
            AS.volume = 0.1f;
            AS.PlayOneShot(standardshoot);
        }
        else if (s == "Lasershoot")
        {
            AS.volume = 0.1f;
            AS.PlayOneShot(lasershoot);
        }
        else if (s == "Destroyed")
        {
            AS.PlayOneShot(destroyed);
        }
        else if (s == "buyturret")
        {
            AS.volume = 1f;
            AS.PlayOneShot(buyturret);
        }
        else if (s == "Ticker")
        {
            AS.volume = 1f;
           AS.PlayOneShot(ticker);
        }
        else if (s == "sell")
        {
            AS.volume = 1f;
            AS.PlayOneShot(sell);
        }
        else if (s == "upgrade")
        {
            AS.volume = 1f;
            AS.PlayOneShot(upgrade);
        }
    }
}
