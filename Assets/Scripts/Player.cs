using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ISave
{
    //string prefabName = "Player";

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            //this.gameObject.SetActive(false);
        }
    }
}