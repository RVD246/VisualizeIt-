using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCubeSpawner : MonoBehaviour
{
    public GameObject sampleCubePrefab;
    GameObject[] sampleCubes = new GameObject[512];
    public float maxScale;

    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject instancedCube = Instantiate(sampleCubePrefab);
            instancedCube.transform.position = transform.position;
            instancedCube.transform.parent = transform;
            instancedCube.transform.name = "SampleCube_" + (i + 1);
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            instancedCube.transform.position = Vector3.forward * 100;
            sampleCubes[i] = instancedCube;
        }
    }

    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (sampleCubes != null)
            {
                sampleCubes[i].transform.localScale = new Vector3(10, (SpectrumData.samples[i] * maxScale) + 2, 10);
            }
        }
    }
}