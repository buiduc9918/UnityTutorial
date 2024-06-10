using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    public GameObject powerupPrefabs;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(2);
        Instantiate(enemyPrefabs, GenerateSpawnPositon(), powerupPrefabs.transform.rotation);
    }

    void SpawnEnemyWave(int enemesToSpawn)
    {
        for (int i = 0; i < enemesToSpawn; i++)
        {
            Instantiate(enemyPrefabs, GenerateSpawnPositon(), enemyPrefabs.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPositon()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {

        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefabs, GenerateSpawnPositon(), powerupPrefabs.transform.rotation);
        }
    }
}
