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
    public static int wavenumber=1;
    public Transform GroundSpawnPoint;
    public Transform FlyingSpawnPoint;
    void Update()
    {
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = TimeBetweenWaves;
        }
        leftfornextround.text = (Mathf.Ceil( countdown ) ).ToString();
        countdown -= Time.deltaTime;
    }
     IEnumerator SpawnWave()
    {
        for(int i = 0; i < wavenumber; i++)
        {
            SpawnGroundEnemy(SimpleEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < wavenumber /100; i++)
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
        Instantiate(tospawn , GroundSpawnPoint.position, GroundSpawnPoint.rotation);
    }
    void SpawnFlyingEnemy(GameObject tospawn)
    {
        Instantiate(tospawn, FlyingSpawnPoint.position, FlyingSpawnPoint.rotation);
    }
}
