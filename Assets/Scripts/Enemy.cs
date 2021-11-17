using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject
{
    [SerializeField]
    private GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == player.tag)
        {
            Debug.Log(player.name + "に当たった");
            this.gameObject.SetActive(false);
        }
    }
}
