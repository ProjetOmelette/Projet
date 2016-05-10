using UnityEngine;
using System.Collections;

public class EnnemyDeplacement : MonoBehaviour {

    public GameObject Player;
    private Vector3 Direction;
    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
    }
}