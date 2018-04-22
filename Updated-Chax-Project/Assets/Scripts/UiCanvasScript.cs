using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiCanvasScript : MonoBehaviour
{
    public Text wavecount;
    public Text currentcoins;
    public void Awake()
    {
    }
    public void Update()
    {

        wavecount.text ="Wave #"+(WaveSpawner.wavenumber-1).ToString();
        currentcoins.text ="$"+ (GameManagerScript.Game.Coins).ToString();
    }
}
