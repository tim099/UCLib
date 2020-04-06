using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL.Core;
public class UCL_Test : MonoBehaviour
{
    [UCL_StrListProperty("QAQ", "QWQ")] public string test;
    [UCL_StrListProperty(typeof(UCL.SceneLib.UCL_Scene), "GetScenesName")] public string test2;
    [UCL_StrListProperty(typeof(UCL.SceneLib.UCL_Scene), "GetAllScenesName")] public string test3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
