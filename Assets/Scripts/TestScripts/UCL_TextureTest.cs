using System.Collections;
using System.Collections.Generic;
using UCL.AudioLib;
using UnityEngine;
using UnityEngine.UI;

[UCL.Core.ATTR.EnableUCLEditor]
public class UCL_TextureTest : MonoBehaviour
{
    [SerializeField] Texture2D m_IsPlaying;
    [SerializeField] Image m_Img;
    [SerializeField] UCL_AudioSourceDebugGUI m_AudioSourceDebugGUI;
    UCL.Core.TextureLib.UCL_Texture2D m_PlayTexture;
    private void Awake() {

    }
    // Start is called before the first frame update
    void Start()
    {

    }
    [UCL.Core.ATTR.UCL_FunctionButton]
    public void Refresh() {
        /*
        m_PlayTexture = new UCL.Core.TextureLib.UCL_Texture2D(new Vector2Int(64, 64));
        for(int i = 0; i < m_PlayTexture.height; i++) {
            for(int j = 0; j < m_PlayTexture.width; j++) {
                m_PlayTexture.SetPixel(i, j, Color.Lerp(Color.blue, Color.yellow,(0.5f*i+0.5f*j)/ m_PlayTexture.height));
            }
        }
        for(int i = 0; i < m_PlayTexture.height; i++) {
            m_PlayTexture.SetPixel(32, i, Color.red);
            m_PlayTexture.SetPixel(i, 32, Color.green);
        }
        */
        m_PlayTexture = m_AudioSourceDebugGUI.m_PlayTexture;

        m_IsPlaying = m_PlayTexture.texture;//Instantiate(m_PlayTexture.texture);
        if(m_Img) m_Img.sprite = m_PlayTexture.sprite;//m_PlayTexture.sprite;
        GetComponent<MeshRenderer>().material.mainTexture = m_PlayTexture.texture;//m_PlayTexture.texture;
    }
    // Update is called once per frame
    float time = 0;
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
