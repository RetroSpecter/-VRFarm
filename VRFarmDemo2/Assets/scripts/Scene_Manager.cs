using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Manager : MonoBehaviour {

    public AudioClip[] test;
    public GameObject currentScene;
    public GameObject[] scenes;

    void Start() {
        //playNarration(test[0]);
        StartCoroutine(screenFade.instance.fade(Color.black, Color.clear, true, 0.5f));
        //StartCoroutine(fadeBetweenScenesCor(0.5f, 1));
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Animator>().SetTrigger("skip");
        }
    }

    public void fadeBetweenPositions(Vector3 newPosition) {
        StartCoroutine(screenFade.instance.fadeBetween(1, newPosition));
    }

    public void fadeBetweenScenes(int sceneIndex) {
        StartCoroutine(fadeBetweenScenesCor(0.5f, sceneIndex));
    }

    public IEnumerator fadeBetweenScenesCor(float time, int sceneIndex) {
        yield return screenFade.instance.fade(Color.clear, Color.black, false, time * 2);
        currentScene.SetActive(false);
        currentScene = scenes[sceneIndex];
        currentScene.SetActive(true);
        yield return screenFade.instance.fade(Color.black, Color.clear, true, time * 2);

    }

    public void playNarration(AudioClip narration) {
        audioManager.instance.Play(narration);
    }
}
