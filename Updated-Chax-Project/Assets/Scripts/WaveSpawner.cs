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

    public Text leftfornextround;

    public float TimeBetweenWaves=20f;
    private float countdown=2f;
    public static int wavenumber=0;
    public Transform GroundSpawnPoint;
    public Transform FlyingSpawnPoint;
    public void Start()
    {
      wavenumber = 1;
    }
    void Update()
    {
        if (GameManagerScript.Game.EnemiesAlive>0)
        {
            return;
        }

        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = TimeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;
        leftfornextround.text = (Mathf.Ceil( countdown ) ).ToString();
    }
     IEnumerator SpawnWave()
    {
        for(int i = 0; i < wavenumber; i++)
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
