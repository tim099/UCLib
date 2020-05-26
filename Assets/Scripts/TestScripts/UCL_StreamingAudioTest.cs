using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCL.AudioLib;
using System.Runtime.InteropServices;
using UCL.Core.MarshalLib;
public class UCL_StreamingAudioTest : MonoBehaviour
{
    public int m_BufferLen = 4096;
    protected int m_DataSize;
    public UCL_AudioStream m_UCL_AudioStream;
    
    UCL_IntPtr m_Ptr;

    UCL_StreamingAudioSource m_UCL_StreamingAudioSource;
    UCL_PCMConverter m_UCL_PCMConverter;
    UCL.Core.Container.UCL_ArrayPoolFixed<float> m_Pool;

    [UCL.Core.PA.UCL_Button("Test")] public bool m_Test;
    public void Test() {
        PlayerPrefs.SetString("Test", "QAQ");
        PlayerPrefs.Save();
    }
    void Start() {
        

        m_UCL_AudioStream.Init(m_BufferLen);
        //m_UCL_MicrophoneStream?.Init(m_BufferLen);
        m_DataSize = m_UCL_AudioStream.m_Channels * m_BufferLen;
        m_UCL_StreamingAudioSource = UCL_StreamingAudioSource.Create(transform);
        
        m_UCL_StreamingAudioSource.GetClip()
            .SetFrequency(m_UCL_AudioStream.m_Frequency)
            .SetLengthSamples(m_BufferLen)
            .SetChannels(m_UCL_AudioStream.m_Channels);

        m_UCL_StreamingAudioSource.Init();
        m_UCL_StreamingAudioSource.Play();
        m_UCL_PCMConverter = new UCL_PCMConverter(m_DataSize);
        m_Ptr = new UCL_IntPtr(sizeof(short) * m_DataSize);//sizeof(short) * 
        //m_Ptr.Alloc(m_BufferLen * 2);
        //src = new float[m_BufferLen];
        m_Pool = new UCL.Core.Container.UCL_ArrayPoolFixed<float>(m_DataSize);
        //UCL.AudioLib.Lib.PCM_FloatToShort
        /*
        unsafe {
            int[] array = new int[256];
            int at = 128;
            int* pArray = (int*)Marshal.UnsafeAddrOfPinnedArrayElement(array, at);
            int len = array.Length - at;
            for(int i = 0 ; i < len; i++) {
                (pArray[i]) = i;
            }
            //int[] n_Arr = new int[128](pArray);
            foreach(var v in array) {
                Debug.LogWarning(v);
            }
        }
        */

        //System.Buffers.ArrayPool<float>.Shared.Rent(3 * m_BufferLen);
    }
    public bool m_Pause = false;
    void Update() {
        if(m_Pause) return;
        if(m_UCL_StreamingAudioSource.CanAddData()) {
            //m_UCL_StreamingAudioSource.AddData(m_UCL_AudioClipStream.Load(m_BufferLen));
            var data = m_UCL_AudioStream.Load();
            if(data != null) {
                /*
                var src = m_Pool.Rent();
                var ptr = m_UCL_PCMConverter.ToPtr(data);
                m_UCL_PCMConverter.ToPCM(ptr, src);
                
                m_UCL_StreamingAudioSource.AddData(src, m_Pool.Return);
                */
                m_UCL_StreamingAudioSource.AddData(data, m_UCL_AudioStream.Return);
            }
            
        }
    }
}
