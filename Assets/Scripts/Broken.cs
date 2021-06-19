using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject, 0.2f);
        }
    }

}
