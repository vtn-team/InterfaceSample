﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObject : MonoBehaviour, ISave
{
    //string prefabName = "FieldObject";
    //private void Start()
    //{
    //    prefabName = this.name.Replace("(Clone)", "");
    //}
    // Save Load をまとめる？

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = this.name.Replace("(Clone)", "");
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
