using UnityEngine;

public class MoveUpDown : MonoBehaviour
{ // Start is called before the first frame update
    private float limitx = 0.75f;
    private float speed = 5f;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x) >= limitx)
        {
            speed *= -1f;
        }
    }
}
