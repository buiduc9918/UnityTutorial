using UnityEngine;

public class DestroyOfBounds : MonoBehaviour
{

    public float Bound = 20;
    public GameObject OJJ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > Bound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -Bound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > Bound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -Bound)
        {
            Destroy(gameObject);
        }
    }
}
