using UnityEngine;

public class DestroyOutOfBoundInUnder : MonoBehaviour
{
    public float UnderBound = -13;
    private object gui;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < UnderBound)
        {
            Debug.Log("Game Over, good luck.......");
            Destroy(gameObject);
        }
    }
}
