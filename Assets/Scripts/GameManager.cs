using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadData()
    {
        SaveManager.Load();
        SaveData data = SaveManager.GetData();
        foreach(var d in data.ObjectList)
        {
            GameObject res = Resources.Load<GameObject>(d.PrefabName);
            if (res == null) continue;
            GameObject go = GameObject.Instantiate(res);
            if (go == null) continue;
            ISave saveIf = go.GetComponent<ISave>();
            if (saveIf == null) continue;

            saveIf.Load(d);
        }
    }

    public void SaveData()
    {
        SaveData data = SaveManager.GetData();
        data.ObjectList.Clear();
        var lists = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject go in lists)
        {
            SaveData.ObjectData d = new global::SaveData.ObjectData();
            if (go == null) continue;
            ISave saveIf = go.GetComponent<ISave>();
            if (saveIf == null) continue;
            saveIf.Save(d);
            data.ObjectList.Add(d);
            Debug.Log(d);
        }
        SaveManager.Save();
    }
}
