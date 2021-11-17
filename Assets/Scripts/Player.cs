using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CalactorBase
{
    private void Start()
    {

    }

    private void Update()
    {
        Move();
    }

    protected override void Move()
    {
        //float v = Input.GetAxisRaw("Vertical");
        //float h = Input.GetAxisRaw("Horizontal");

        //Vector3 vec = Vector3.forward * v + Vector3.right * h;
        //if (vec == Vector3.zero)
        //{
        //    m_rb.velocity = new Vector3(0f, m_rb.velocity.y, 0f);
        //}
        //else
        //{
        //    m_rb.velocity = vec;
        //}
    }

    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.Position = this.transform.position;
    }

    public override void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}