using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharaBase
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("死んだ");
            Destroy(gameObject);
        }
    }
}
