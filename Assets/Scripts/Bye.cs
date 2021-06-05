using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bye : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject, 0.08f);
        }
    }
 
}
