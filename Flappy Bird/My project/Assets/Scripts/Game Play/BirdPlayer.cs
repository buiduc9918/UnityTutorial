using UnityEngine;

public class BirdPlayer : MonoBehaviour
{
    public int newOrderInLayer = 2;
    public float Speed = 4f;
    public Rigidbody birdRb;
    public GameObject bird;
    public SpawnPipe spawnPipe;
    // Start is called before the first frame update
    void Start()
    {
        birdRb = GetComponent<Rigidbody>();
        GetComponent<Renderer>().sortingOrder = newOrderInLayer;
        spawnPipe = GameObject.Find("Spawn Pipe").GetComponent<SpawnPipe>();
    }
    // Update is called once per frame
    void Update()
    {
        birdFly();
        if (transform.position.y < -5)
        {
            spawnPipe.GameOver();
        }
        if (spawnPipe.score > 20)
        {
            spawnPipe.Champion();
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pipe Couple"))
        {
            spawnPipe.GameOver();
        }
        if (other.gameObject.CompareTag("Pipe Simple"))
        {
            spawnPipe.GameOver();
        }
    }
    public void birdFly()
    {
        Vector3 initialVelocity = transform.up * Speed;
        if (spawnPipe.run == true)
        {
            birdRb.isKinematic = false; // Kích hoạt chuyển động
            if (Input.GetKeyDown(KeyCode.Space))
            {
                birdRb.velocity = initialVelocity;
                transform.position = bird.transform.position + new Vector3(0, 0.1f, 0);
            }

        }
        else if (spawnPipe.run == false)
        {
            birdRb.isKinematic = true; // Vô hiệu hóa chuyển động
        }
    }
}
