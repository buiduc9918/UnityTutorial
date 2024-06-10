using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConstroller : MonoBehaviour
{
    public float speed = 8;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
