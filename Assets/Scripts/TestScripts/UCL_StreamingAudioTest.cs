using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL.AudioLib;


public class UCL_StreamingAudioTest : MonoBehaviour
{
    public int m_BufferLen = 4096;
    public UCL_AudioClipStream m_UCL_AudioClipStream;
    UCL_StreamingAudioSource m_UCL_StreamingAudioSource;

    void Start() {
        m_UCL_StreamingAudioSource = UCL_StreamingAudioSource.Create(transform);
        
        m_UCL_StreamingAudioSource.GetClip()
            .SetFrequency(m_UCL_AudioClipStream.m_Clip.frequency)
            .SetLengthSamples(m_BufferLen)
            .SetChannels(m_UCL_AudioClipStream.m_Clip.channels);

        m_UCL_StreamingAudioSource.Init();
        m_UCL_StreamingAudioSource.Play();
    }
    void Update() {
        if(m_UCL_StreamingAudioSource.GetDataCount() < 2) {
            m_UCL_StreamingAudioSource.AddData(m_UCL_AudioClipStream.Load(m_BufferLen));
        }
    }
}
