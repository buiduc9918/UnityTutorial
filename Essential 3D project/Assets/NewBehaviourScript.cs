using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string webglProjectURL = Application.absoluteURL;
        Debug.Log("webgl project url: " + webglProjectURL);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
