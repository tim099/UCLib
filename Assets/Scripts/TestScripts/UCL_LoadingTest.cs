using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCL_LoadingTest : MonoBehaviour
{
    [UCL.Core.PA.UCL_StrList(typeof(UCL.SceneLib.Lib), "GetScenesName")] public string m_LoadScene;
    [UCL.Core.PA.UCL_Button] public string m_EditorLoadScene;
    [UCL.Core.PA.UCL_Button] public int m_test = 2;
    [UCL.Core.PA.UCL_Button] public UCL_Test m_TestFunc;//(typeof(UCL_Test))
    [UCL.Core.PA.UCL_Button(typeof(UCL_Test), m_FuncName = "TestFunc")] public int m_Test = 2;
    int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
#if UNITY_EDITOR
    ///*
    public void EditorLoadScene() {
        Debug.LogWarning("EditorLoadScene:" + m_LoadScene);
        string path = UCL.SceneLib.Lib.GetScenePath(m_LoadScene);
        UCL.SceneLib.EditorSceneLoader.LoadScene(path);
    }
    public void EditorLoadScene(int str) {
        Debug.LogWarning("EditorLoadScene:" + str);
        Debug.LogWarning("EditorLoadScene:" + m_LoadScene);
        string path = UCL.SceneLib.Lib.GetScenePath(m_LoadScene);
        UCL.SceneLib.EditorSceneLoader.LoadScene(path);
    }
    //*/
    ///*
    public void EditorLoadScene(string str) {
        Debug.LogWarning("EditorLoadScene:" + str);
        Debug.LogWarning("EditorLoadScene:" + m_LoadScene);
        string path = UCL.SceneLib.Lib.GetScenePath(m_LoadScene);
        UCL.SceneLib.EditorSceneLoader.LoadScene(path);
    }
    //*/
    public void EditorLoadScene2() {
        Debug.LogWarning("EditorLoadScene2:" + m_LoadScene);
    }
    public void Test() {
        Debug.LogWarning("Test()!!");
    }
    public void TestFunc(UCL_Test test) {
        Debug.LogWarning("Ohh!!");
        test.TestFunc();
    }
    public void test(int vv) {
        //int vv = 0;
        Debug.LogWarning("test(ddd)!!:"+vv);
    }
#endif
    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer == 20) {
            var data = UCL.SceneLib.UCL_SceneManager.Instance.LoadScene(m_LoadScene);
            data.SetAllowSceneActivation(false);
            data.StartLoad();
        }
    }
}
