using UnityEngine;

public class DestroyOfBounds : MonoBehaviour
{
    public GameObject gameObjectDestroy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -8)
        {
            Destroy(gameObjectDestroy);
        }

    }
}