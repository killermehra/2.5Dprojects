using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
   private CinemachineVirtualCamera virtualCamera;
   private CinemachineBasicMultiChannelPerlin perlinenoice;
    private void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        perlinenoice = virtualCamera.GetComponent<CinemachineBasicMultiChannelPerlin>();
        ResetIntesty();
    }
    public void Shakecamera(float intesty ,float shaketime)
    {
        perlinenoice.m_AmplitudeGain = intesty;
        StartCoroutine(waitTime(shaketime));
    }
    IEnumerator waitTime(float shaketime)
    {
       yield return new WaitForSeconds(shaketime);
        ResetIntesty();
    }
    void ResetIntesty()
    {
        perlinenoice.m_AmplitudeGain = 0;
    }
}
