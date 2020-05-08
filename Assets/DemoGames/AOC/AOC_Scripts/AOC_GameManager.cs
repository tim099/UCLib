using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL;
namespace AOC {
    public class AOC_GameManager : UCL.Core.Game.UCL_GameManager {
        protected override void Init() {
            if(f_Inited) return;



            base.Init();
            Debug.LogWarning("AOC_GameManager Init!!");
            Debug.LogWarning("Test4:" + m_GameConfig.GetString("Test4"));
            m_GameConfig.SetValue("Test4",System.DateTime.Now.ToString("HHmmss"));
        }
    }
}