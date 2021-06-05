using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface ISave
{
    void Save(SaveData.ObjectData data);
    void Load(SaveData.ObjectData data);
}
