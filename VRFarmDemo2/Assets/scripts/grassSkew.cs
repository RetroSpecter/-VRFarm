using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassSkew : BillBoardGo {
    void Start() {
        MyTransform = this.transform;
        MyCameraTransform = Camera.main.transform;
        randomStart = Random.Range(0,4);

        if (alignNotLook)
            MyTransform.forward = MyCameraTransform.forward;
        else
            MyTransform.LookAt(MyCameraTransform, Vector3.up);
    }

    float randomStart;
    void LateUpdate() {
        MyCameraTransform = Camera.main.transform;
        float rotate =  Mathf.Sin(randomStart + Time.time * 4) * 6 - 3;

        Quaternion lookAtCamera = Quaternion.LookRotation(MyCameraTransform.position);

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, rotate);
    }
}
