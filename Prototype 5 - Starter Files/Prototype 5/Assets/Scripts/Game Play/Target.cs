using UnityEngine;


public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnpos = -6;
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem explosionParticle;
    private int clickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RamdomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RamdomTorque(), RamdomTorque(), RamdomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    Vector3 RamdomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RamdomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnpos);
    }
    private void OnMouseDown()
    {

        if (gameManager.isGameActive)
        {
            clickCount++;
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpDateScore(pointValue);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log("va cham run");
        //if (!gameObject.CompareTag("Bad"))
        //{
        //    Debug.Log("va cham run");
        //    gameManager.GameOver();
        //}
        if (gameManager.score >= 20 || clickCount >= 30)
        {
            Debug.Log("game over");
            gameManager.GameOver();
        }
        if (gameManager.objectCount > 20)
        {
            Debug.Log(" qua nhieu doi tuong");
            gameManager.GameOver();
        }
    }

}
