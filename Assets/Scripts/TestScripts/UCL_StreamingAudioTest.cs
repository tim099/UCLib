using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL.AudioLib;


public class UCL_StreamingAudioTest : MonoBehaviour
{
    public int m_BufferLen = 4096;
    public UCL_AudioStream m_UCL_AudioStream;
    //public UCL_MicrophoneStream m_UCL_MicrophoneStream;
    UCL_StreamingAudioSource m_UCL_StreamingAudioSource;

    void Start() {
        m_UCL_AudioStream.Init(m_BufferLen);
        //m_UCL_MicrophoneStream?.Init(m_BufferLen);

        m_UCL_StreamingAudioSource = UCL_StreamingAudioSource.Create(transform);
        
        m_UCL_StreamingAudioSource.GetClip()
            .SetFrequency(m_UCL_AudioStream.m_Frequency)
            .SetLengthSamples(m_BufferLen)
            .SetChannels(m_UCL_AudioStream.m_Channels);

        m_UCL_StreamingAudioSource.Init();
        m_UCL_StreamingAudioSource.Play();

        //System.Buffers.ArrayPool<float>.Shared.Rent(3 * m_BufferLen);
    }
    public bool m_Pause = false;
    void Update() {
        if(m_Pause) return;
        if(m_UCL_StreamingAudioSource.GetDataCount() < 2) {
            //m_UCL_StreamingAudioSource.AddData(m_UCL_AudioClipStream.Load(m_BufferLen));
            var data = m_UCL_AudioStream.Load();
            if(data != null) {
                m_UCL_StreamingAudioSource.AddData(data, m_UCL_AudioStream.Return);
            }
            
        }
    }
}
