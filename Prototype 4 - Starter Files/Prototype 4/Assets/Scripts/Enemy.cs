using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

        Vector3 lookDirection = (player.transform.position - transform.forward).normalized;
        enemyRb.AddForce(lookDirection * speed);


    }
}
