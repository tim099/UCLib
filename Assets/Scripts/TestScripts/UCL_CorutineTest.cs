using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCL_CorutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
