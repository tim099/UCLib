using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCL_LoadingTest : MonoBehaviour
{
    [UCL.Core.UCL_StrListProperty(typeof(UCL.SceneLib.UCL_Scene), "GetScenesName")] public string m_LoadScene;
    [UCL.Core.UCL_ButtonProperty] public string Editor_LoadScene = "EditorLoadScene";
    [UCL.Core.UCL_ButtonProperty(typeof(UCL_LoadingTest))] public int test = 2;
    int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
#if UNITY_EDITOR
    public void EditorLoadScene() {
        Debug.LogWarning("EditorLoadScene!!");
        Debug.LogWarning("EditorLoadScene:" + m_LoadScene);
        string path = UCL.SceneLib.UCL_Scene.GetScenePath(m_LoadScene);
        UCL.SceneLib.EditorSceneLoader.LoadScene(path);
    }
    public void Test() {
        Debug.LogWarning("Test()!!");
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
