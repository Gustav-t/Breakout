using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    int hp = 1;

    public void takeDamage()
    {

        hp -= 1;

        if (hp == 0)
        {

            Destroy(gameObject);

        }

    }

}
