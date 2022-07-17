using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int band = 0;
    public float startScale = 1, scaleMultiplier = 10;

    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, (SpectrumData.freqBand[band] * scaleMultiplier) + startScale, transform.localScale.z);
    }
}