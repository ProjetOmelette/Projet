using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    float speed = 200f;
    // Use this for initialization
    void Start()
    {

    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0.0f, v);

        if (h != 0f || v != 0f)
            GetComponent<Rigidbody>().velocity = movement * speed * Time.deltaTime;

      //  if (Input.GetKeyDown(KeyCode.Space))
       //     GameObject.Find("Player").GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
