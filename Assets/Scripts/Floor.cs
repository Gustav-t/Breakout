using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject otherGameObject = collision.gameObject;
        boll2 hitBlock = otherGameObject.GetComponent<boll2>();

        if (hitBlock != null)
        {

            hitBlock.bollDamage();

        }

    }

}

 