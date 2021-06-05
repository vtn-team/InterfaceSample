using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Chara
{
    string charaName = "Player";
    public override string CharaName { get => charaName; }


    //public virtual void Save(SaveData.ObjectData data)
    //{
    //    data.PrefabName = "Player";
    //    data.Position = this.transform.position;
    //}

    //public virtual void Load(SaveData.ObjectData data)
    //{
    //    this.transform.position = data.Position;
    //}
}