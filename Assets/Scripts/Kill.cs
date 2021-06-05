using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour, ISave
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
    }
    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
