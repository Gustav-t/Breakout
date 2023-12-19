using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    Rigidbody2D myRidgidbody;


    // Start is called before the first frame update
    void Start()
    {
        myRidgidbody = GetComponent<Rigidbody2D>();
        myRidgidbody.AddForce(new Vector2(0, -275));
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 4;
        myRidgidbody.velocity = myRidgidbody.velocity.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject otherGameObject = collision.gameObject;
        Box hitBlock = otherGameObject.GetComponent<Box>();

        if (hitBlock != null)
        {

            hitBlock.takeDamage();

        }

    }
}
//boll


