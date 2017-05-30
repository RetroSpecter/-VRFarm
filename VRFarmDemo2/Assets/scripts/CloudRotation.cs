using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudRotation : MonoBehaviour {

    public float speed;

    void LateUpdate() {
        transform.Rotate(0,speed,0);
    }
}
