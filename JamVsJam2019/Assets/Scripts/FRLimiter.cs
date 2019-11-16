using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FRLimiter : MonoBehaviour
{
    public int fR;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = fR;
    }
}