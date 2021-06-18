using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ISave
{
    bool _isDead = false;

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
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