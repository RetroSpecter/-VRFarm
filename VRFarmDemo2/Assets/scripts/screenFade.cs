using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class screenFade : MonoBehaviour {


    public static screenFade instance;

    [Range(0, 1.1f)] public float opacity;

    void Awake() {
        instance = this;
    }

    public Material TransitionMaterial;

    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        TransitionMaterial.SetFloat("_opacity", opacity);
        Graphics.Blit(source, destination, TransitionMaterial);
    }
    public IEnumerator fadeBetween(float time, Vector3 position) {
        yield return fade(false, time * 2);
        transform.position = position;
        yield return fade(true, time * 2);
    }

    public IEnumerator fade(bool fadeIn, float time) {
        float f = 0;
        while (f < 1) {
            f += Time.deltaTime * time;
            opacity = fadeIn ? f : 1 - f;
            yield return null;
        }
        opacity = fadeIn ? 1 : 0;
    }
}
