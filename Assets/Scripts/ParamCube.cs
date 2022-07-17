using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int band = 0;
    public float startScale = 1, scaleMultiplier = 10;
    public bool useBuffer;
    Material material;
    public Color startColor;

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        if (useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (SpectrumData.bandBuffer[band] * scaleMultiplier) + startScale, transform.localScale.z);
            Color color = new Color(SpectrumData.audioBandBuffer[band], SpectrumData.audioBandBuffer[band], SpectrumData.audioBandBuffer[band]);
            material.SetColor("_EmissionColor", startColor * color);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x, (SpectrumData.freqBand[band] * scaleMultiplier) + startScale, transform.localScale.z);
            Color color = new Color(SpectrumData.audioBand[band], SpectrumData.audioBand[band], SpectrumData.audioBand[band]);
            material.SetColor("_EmissionColor", startColor * color);
        }
    }
}