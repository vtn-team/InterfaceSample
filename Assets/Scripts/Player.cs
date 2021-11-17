﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charactor
{
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        base.Save(data);
    }
    public override void Load(SaveData.ObjectData data)
    {
        base.Load(data);
    }
}