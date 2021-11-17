using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ObjectBase
{
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.Position = this.transform.position;
    }
}