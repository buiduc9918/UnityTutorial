using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject gun;
    public GameObject x;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gun, x.transform.position, gun.transform.rotation);
        }
    }
}
