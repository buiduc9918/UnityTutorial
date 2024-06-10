using UnityEngine;

public class PlayerConstroller : MonoBehaviour
{
    //public float speed = 5.0f;
    // public float turnSpeed;
    //  public float horizontalInput;
    //  public float forwardInput;
    private Rigidbody playerRb;

    private float horsePower = 5.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        //  playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * horsePower * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        //  transform.Translate(Vector3.right* Time.deltaTime * turnSpeed * horizontalInput);
    }
}
