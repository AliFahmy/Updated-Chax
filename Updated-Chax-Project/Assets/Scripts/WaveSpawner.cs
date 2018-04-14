using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject SimpleEnemyPrefab;
    [SerializeField]
    private GameObject ToughEnemyPrefab;
    [SerializeField]
    private GameObject FlyEnemyPrefab;

    public float TimeBetweenWaves=20f;
    private float countdown=2f;
    public static int wavenumber=1;
    public Transform SpawnPoint;
    void Update()
    {
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = TimeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }
     IEnumerator SpawnWave()
    {
        for(int i = 0; i < wavenumber; i++)
        {
            SpawnEnemy(SimpleEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < wavenumber /2; i++)
        {
            SpawnEnemy(ToughEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < wavenumber/5; i++)
        {
            SpawnEnemy(FlyEnemyPrefab);
            yield return new WaitForSeconds(0.5f);
        }
        wavenumber++;
    }
    void SpawnEnemy(GameObject tospawn)
    {
        Instantiate(tospawn , SpawnPoint.position,SpawnPoint.rotation);
    }
}
