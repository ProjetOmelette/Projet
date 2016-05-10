using UnityEngine;
using System.Collections;

public class SmartCamera : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Camera.main.transform.position = new Vector3(0, 7.5f, -2);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "cafe")
        {
            Camera.main.transform.position = new Vector3((((float)Col.name[5] - 48) * 14) + 0.5f, 7f, (((float)Col.name[7] - 48) * 9) - 3f);
            GameObject.Destroy(GameObject.Find("plane " + char.ToString(Col.name[5]) + " " + char.ToString(Col.name[7])));
        }
    }
}
