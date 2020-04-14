using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL.Core;
public class UCL_Test : MonoBehaviour
{
    [UCL.Core.PA.UCL_StrListProperty("QAQ", "QWQ")] public string test;
    [UCL.Core.PA.UCL_StrListProperty(typeof(UCL.SceneLib.Lib), "GetScenesName")] public string test2;
    [UCL.Core.PA.UCL_StrListProperty(typeof(UCL.SceneLib.Lib), "GetAllScenesName")] public string test3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TestFunc() {
        Debug.LogWarning("TestFunc:"+name);
    }
    static public void TestFunc(int v) {
        Debug.LogWarning("TestFuncxxx:" + v);
    }
    static public void Test(int v) {
        Debug.LogWarning("Testxxx:" + v);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
