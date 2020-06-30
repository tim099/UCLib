using System.Collections;
using System.Collections.Generic;
using UCL.AudioLib;
using UnityEngine;
using UnityEngine.UI;

[UCL.Core.ATTR.EnableUCLEditor]
public class UCL_TextureTest : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] Texture2D m_IsPlaying;
    [SerializeField] Image m_Img;
    [SerializeField] UCL_AudioDebugGUI m_AudioDebugGUI;
#pragma warning restore 0649
    [UCL.Core.PA.UCL_StrList(new string[] { "Hi","Hey"})] public string test;
    UCL.Core.TextureLib.UCL_Texture2D m_PlayTexture;
    private void Awake() {

    }
    // Start is called before the first frame update
    void Start()
    {

    }
    [UCL.Core.ATTR.UCL_FunctionButton]
    public void Refresh() {
        if(m_AudioDebugGUI == null) return;
        m_PlayTexture = m_AudioDebugGUI.m_Texture;
        if(m_PlayTexture == null) return;
        m_IsPlaying = m_PlayTexture.texture;//Instantiate(m_PlayTexture.texture);
        if(m_Img) m_Img.sprite = m_PlayTexture.sprite;//m_PlayTexture.sprite;
        GetComponent<MeshRenderer>().material.mainTexture = m_PlayTexture.texture;//m_PlayTexture.texture;
    }
    // Update is called once per frame
    //float time = 0;
    void Update()
    {
        if(m_PlayTexture == null) {
            Refresh();
        }
        /*
        time += 0.01f;
        if(time > 1) time = 0;

        for(int i = 0; i < m_PlayTexture.height; i++) {
            m_PlayTexture.SetPixel(32, i, Color.Lerp(Color.red,Color.green, time));
            m_PlayTexture.SetPixel(i, 32, Color.green);
        }
        m_PlayTexture.GetTexture();

        //if(m_IsPlaying != null) Destroy(m_IsPlaying);
        //m_IsPlaying = Instantiate(m_PlayTexture.texture);
        //GetComponent<MeshRenderer>().material.mainTexture = m_IsPlaying;
        //*/
    }
}
