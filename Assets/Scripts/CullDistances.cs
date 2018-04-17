using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullDistances : MonoBehaviour {

    public float[] LayerDistances = new float[32];

    void Start()
    {
        Camera camera = GetComponent<Camera>();
        for(int i=0;i<LayerDistances.Length; i++)
        {
            if (LayerDistances[i] == 0) LayerDistances[i] = camera.farClipPlane;
        }

        camera.layerCullDistances = LayerDistances;
    }
}
