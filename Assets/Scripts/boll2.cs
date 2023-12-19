using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boll2 : MonoBehaviour
{

    int hp = 3;

    [SerializeField]
    private TextMeshProUGUI Liv;

    public void bollDamage()
    {

        hp -= 1;
        Liv.text = "Liv: " + hp;

        transform.position

        if (hp == 0)
        {

            Destroy(gameObject);

        }

    }


    // Start is called before the first frame update
    void Start()
    {

        Liv.text = "Liv: " + hp;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
