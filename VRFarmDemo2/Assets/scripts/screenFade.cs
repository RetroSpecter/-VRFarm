using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenFade : MonoBehaviour {

    SpriteRenderer spriteRend;
    public static screenFade instance;

    void Awake() {
        instance = this;
        spriteRend = GetComponent<SpriteRenderer>();

    }

    public IEnumerator fadeBetween(float time, Vector3 position) {
        yield return fade(Color.clear, Color.black, false, time * 2);
        transform.parent.transform.position = position;
        yield return fade(Color.black, Color.clear, true, time * 2);
    }

    public IEnumerator fade(Color start, Color end, bool fadeIn, float time) {
        float f = 0;
        spriteRend.color = start;

        while (f < 1) {
            f += Time.deltaTime * time;
            spriteRend.color = new Color(end.r, end.g, end.b, fadeIn ? 1 - f : f);
            yield return null;
        }
        spriteRend.color = new Color(end.r, end.g, end.b, end.a);
    }
}
