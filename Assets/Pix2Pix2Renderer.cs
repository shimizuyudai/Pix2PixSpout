using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pix2Pix;

[RequireComponent(typeof(Renderer))]
public class Pix2Pix2Renderer : MonoBehaviour
{
    [SerializeField]
    Renderer renderer;
    [SerializeField]
    Pix2PixController pix2pixController;

    // Start is called before the first frame update
    void Reset()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTexture = pix2pixController._resultTexture;
    }
}
