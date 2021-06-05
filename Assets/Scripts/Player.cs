using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : FieldObject
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("敵と接触");
            Destroy(other.gameObject);
        }
    }
}