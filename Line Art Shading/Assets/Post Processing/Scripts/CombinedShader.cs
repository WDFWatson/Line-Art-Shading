using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedShader : MonoBehaviour
{
    public Shader shader;
    public Texture noise;
    private Material mat;

    void OnEnable()
    {
        mat = new Material(shader);
        mat.hideFlags = HideFlags.HideAndDontSave;
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        mat.SetTexture("_Noise",noise);
        mat.SetMatrix("");
        Graphics.Blit(src,dest,mat);
    }
}
