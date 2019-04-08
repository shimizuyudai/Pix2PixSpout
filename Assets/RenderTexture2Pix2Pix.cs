using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pix2Pix;

public class RenderTexture2Pix2Pix : MonoBehaviour
{
    [SerializeField]
    RenderTexture rt;
    [SerializeField]
    Pix2PixController pix2pixController;

    // Update is called once per frame
    void Update()
    {
        Graphics.Blit(rt, pix2pixController._sourceTexture);
    }
}
