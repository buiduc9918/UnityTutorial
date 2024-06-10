using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = 20;
    private float spawnLimitXRight = 20;
    private float spawnpos = 7;
    private float startDelay = 1.5f;
    private float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomBall();
        }
    }
    void SpawnRandomBall()
    {
        int RandomBall = Random.Range(0, ballPrefabs.Length);

        Vector3 compas = new Vector3(Random.Range(-spawnLimitXLeft, spawnLimitXRight), 0, spawnpos);

        Instantiate(ballPrefabs[RandomBall], compas, ballPrefabs[RandomBall].transform.rotation);

    }
}
