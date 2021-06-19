using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SavedObject
{
    bool _isDead = false;

    private void Awake()
    {
        setPrefabName("Enemy");
    }

    private void Update()
    {
        //将来的にはGameManagerに消してもらう
        if (_isDead)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //将来的にはGameManagerに消してもらう
            _isDead = true;
        }
    }
}