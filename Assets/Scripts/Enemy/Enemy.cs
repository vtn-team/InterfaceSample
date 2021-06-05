using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ISave
{
    public void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    public void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.Position = this.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Destroy(this);
        }
    }

}
