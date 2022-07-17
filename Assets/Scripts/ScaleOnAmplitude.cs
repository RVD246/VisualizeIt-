using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnAmplitude : MonoBehaviour
{
    public float startScale = 1, maxScale = 10, rotationSpeed= 0.5f;
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
            transform.rotation = Quaternion.Euler((transform.rotation.eulerAngles + new Quaternion(0, 0, SpectrumData.amplitudeBuffer, 1).eulerAngles) * rotationSpeed);
            transform.localScale = new Vector3((SpectrumData.amplitudeBuffer * maxScale) + startScale, (SpectrumData.amplitudeBuffer * maxScale) + startScale, (SpectrumData.amplitudeBuffer * maxScale) + startScale);
            Color color = new Color(SpectrumData.amplitudeBuffer, SpectrumData.amplitudeBuffer, SpectrumData.amplitudeBuffer);
            material.SetColor("_EmissionColor", startColor * color);
        }
        else
        {
            transform.rotation = Quaternion.Euler((transform.rotation.eulerAngles + new Quaternion(0, 0, SpectrumData.amplitude, 1).eulerAngles) * rotationSpeed);
            transform.localScale = new Vector3((SpectrumData.amplitude * maxScale) + startScale, (SpectrumData.amplitude * maxScale) + startScale, (SpectrumData.amplitude * maxScale) + startScale);
            Color color = new Color(SpectrumData.amplitude, SpectrumData.amplitude, SpectrumData.amplitude);
            material.SetColor("_EmissionColor", startColor * color);
        }
    }
}