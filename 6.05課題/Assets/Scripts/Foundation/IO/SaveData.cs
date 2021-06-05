using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ローカルセーブ用クラス
/// </summary>
[Serializable]
public class SaveData
{
    [Serializable]
    public class ObjectData
    {
        public string PrefabName;
        public Vector3 Position;
    }

    public string Version = "0.1";
    public List<ObjectData> ObjectList = new List<ObjectData>();
}