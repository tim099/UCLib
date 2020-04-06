using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UCL_LoadingTest : MonoBehaviour
{
    [UCL.Core.UCL_StrListProperty(typeof(UCL.SceneLib.UCL_Scene), "GetScenesName")] public string m_LoadScene;

    int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
