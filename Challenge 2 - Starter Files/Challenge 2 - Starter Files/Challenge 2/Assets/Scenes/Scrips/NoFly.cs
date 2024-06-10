using UnityEngine;

public class NoFly : MonoBehaviour
{
    public float high;
    public float low;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > high)
        {
            low = transform.position.y - high;
            transform.position = transform.position + new Vector3(0, -low, 0);
        }
        if (transform.position.y < high)
        {
            low = high - transform.position.y;
            transform.position = transform.position + new Vector3(0, low, 0);
        }

    }
}
