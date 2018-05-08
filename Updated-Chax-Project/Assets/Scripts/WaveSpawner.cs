using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject SimpleEnemyPrefab;
    [SerializeField]
    private GameObject ToughEnemyPrefab;
    [SerializeField]
    private GameObject FlyEnemyPrefab;

    public static int winwaves=100;

    public Text leftfornextround;
    public float TimeBetweenWaves=5f;
    private float countdown=2f;

    public static int wavenumber=1;
    public Transform GroundSpawnPoint;
    public Transform FlyingSpawnPoint;
    public GameObject WinUI;
    public static int EnemyStartLevel = 0;
    
    public void Start()
    {
        SoundManagerScript.playsound("Ticker");
        wavenumber = 1;
    }
    void Update()
    {
        
        
        if (GameManagerScript.Game.EnemiesAlive>0)
        {

            return;
        }
        else
        {
            if (wavenumber > winwaves)
            {
                WinUI.SetActive(true);
            }
            

        }

        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = TimeBetweenWaves;
            return;
        }
        if (Mathf.Ceil(countdown) != (Mathf.Ceil(countdown - Time.deltaTime)))
        {
            Sound();
        }
        countdown -= Time.deltaTime;
        leftfornextround.text = (Mathf.Ceil( countdown ) ).ToString();
        
    }
    void Sound()
    {
        SoundManagerScript.playsound("Ticker");
    }
     IEnumerator SpawnWave()
    {
        


        for (int i = 0; i < wavenumber; i++)
        {

            SpawnGroundEnemy(SimpleEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < wavenumber /5; i++)
        {
            SpawnGroundEnemy(ToughEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < wavenumber/2; i++)
        {
            SpawnFlyingEnemy(FlyEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        GameManagerScript.Game.WavesPassed++;

        wavenumber++;

    }
    void SpawnGroundEnemy(GameObject tospawn)
    {
        GameManagerScript.Game.EnemiesAlive++;
        Instantiate(tospawn , GroundSpawnPoint.position, GroundSpawnPoint.rotation);
    }
    void SpawnFlyingEnemy(GameObject tospawn)
    {
        GameManagerScript.Game.EnemiesAlive++;
        Instantiate(tospawn, FlyingSpawnPoint.position, FlyingSpawnPoint.rotation);
    }
}
