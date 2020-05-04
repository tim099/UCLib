using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCL_CorutineTest : MonoBehaviour
{
    [Serializable]
    struct test {
        public int m_T;
        public string m_S;
        public float m_F;
    }
    // Start is called before the first frame update
    void Start()
    {
        /*
        var t = new test();
        t.m_F = 123.2221f;
        t.m_S = "Taease";
        t.m_F = 313232;
        */
        LitMiniJson.JsonData t = new LitMiniJson.JsonData();
        t["m_T"] = 123.2221f;
        t["m_S"] = "Taease";
        t["m_F"] = 313232;
        string str = t.ToJson();//LitMiniJson.JsonMapper.Serialize(t);
        Debug.LogWarning("Json:" + str);
        var ss = LitMiniJson.JsonMapper.Deserialize(str);
        StartCoroutine(Test());
        //Application.SetStackTraceLogType
        //Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.ScriptOnly);
    }

    IEnumerator Test() {
        Debug.LogWarning("Test 1");
        yield return null;
        Debug.LogError("Test 2");
        yield return null;
        TT();
        yield return null;
    }
    void TT() {
        Debug.LogWarning("TT 1");
        Debug.Log("TT 2");
        throw new Exception("Test Exception!!");//System.NullReferenceException();
    }
}
