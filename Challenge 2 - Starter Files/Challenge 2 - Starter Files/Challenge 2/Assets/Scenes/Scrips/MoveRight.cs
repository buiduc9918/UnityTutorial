using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 3.0f;
    public float Limit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Mathf.Abs(transform.position.x) >= Limit)
        {
            speed *= -1f;
        }
    }
}

