using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObject : BaseObject
{
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = this.name.Replace("(Clone)", "");
        data.Position = this.transform.position;
    }
}
