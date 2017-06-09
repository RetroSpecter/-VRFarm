using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeImageEffect : MonoBehaviour {

    public Material TransitionMaterial;

    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        Graphics.Blit(source, destination, TransitionMaterial);
    }
}
