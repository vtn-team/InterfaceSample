using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : ObjectBase
{
    string prefabName = "TestObject";

    public override void SetName(string pName)
    {
        base.SetName(prefabName);
    }
}
