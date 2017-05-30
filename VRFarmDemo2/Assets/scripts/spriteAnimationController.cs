using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteAnimationController : MonoBehaviour {

    Animator anim;
    public string animationState;
    //public int animationlayer = 1;

	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
	}
	
}
