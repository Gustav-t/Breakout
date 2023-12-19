using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D myRidgidbody;
    

    // Start is called before the first frame update
    void Start()
    {
        myRidgidbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRidgidbody.AddForce(new Vector2(3, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRidgidbody.AddForce(new Vector2(-3, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRidgidbody.AddForce(new Vector2(0, 3));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRidgidbody.AddForce(new Vector2(0, -3));
        }
    }
}
