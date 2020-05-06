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
        }
    }
}