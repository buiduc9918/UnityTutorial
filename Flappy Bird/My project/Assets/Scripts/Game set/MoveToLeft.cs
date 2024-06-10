using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 3.3f * Time.deltaTime);
    }
}
