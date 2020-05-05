using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL.Core.JsonLib;
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
        int a = 1;
        int b = 2;
        object ta = a;
        object tb = 1;
        object tc = b;
        Debug.LogError("TT:" + ta.Equals(tb));
        /*
        var t = new test();
        t.m_F = 123.2221f;
        t.m_S = "Taease";
        t.m_F = 313232;
        */
        JsonData t = new JsonData();
        long ll = long.MaxValue;
        t["m_T"] = 123.2221f;
        t["m_S"] = "Taease";
        t["m_F"] = 313232;
        t["B"] = false;
        t["L"] = ll;
        string str = t.ToJson();//LitMiniJson.JsonMapper.Serialize(t);
        Debug.LogWarning("Json:" + str);
        var data = JsonParser.ToJsonData(str);
        t["Arr"] = data;
        data["WWW"] = "Abigail!!!";
        //Debug.LogError("m_T:" + data["m_T"].ToString());
        //Debug.LogError("m_S:" + data["m_S"].ToString());
        //Debug.LogError("m_F:" + data["m_F"].ToString());
        float vv = (float)data["m_T"];
        var arr = new JsonData();
        var arr2 = new JsonData();
        var da = new JsonData();
        da["XXX"] = 102;
        da["QQ"] = "QWQ";
        data["arr"] = arr;
        data["arr2"] = arr2;
        arr2.Add(da);
        arr2.Add(da);
        for(int i = 0; i < 10; i++) {
            arr.Add(2 * i);
            
        }
        {
            var va = data["arr"];
            Debug.LogWarning(va.ToString() + "," + va.Count);
            foreach(var val in va) {
                Debug.Log("val:" + val);
            }
        }
        Debug.LogWarning("vv:" + vv);

        double vv2 = (double)data["m_T"];
        Debug.LogWarning("vv2:" + vv2);
        Debug.LogWarning("vv2:" + data["WWW"]);
        Debug.LogError("Json:" + t.ToJson());
        

        //StartCoroutine(Test());
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
