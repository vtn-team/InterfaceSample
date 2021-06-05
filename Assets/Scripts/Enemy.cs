using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : loaddata
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject,0.5f);
        }
    }

}
