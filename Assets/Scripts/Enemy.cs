using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : FieldObject
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("hit");
            Destroy(this.gameObject);
        }

    }


}
