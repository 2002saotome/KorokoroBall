using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rigidbbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbbody.AddForce(new Vector3(1, 0, 0) * power);
        }
    }
}
