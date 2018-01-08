using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiction : MonoBehaviour {
    public Animator anim;
    public int action;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (action == 1)
        { 
        action = 1;
		anim.SetInteger("inputAct", action);
        }
        if (action == 2)
        {
            action = 2;
            anim.SetInteger("inputAct", action);
        }
        if (action == 3)
        {
            action = 3;
            anim.SetInteger("inputAct", action);
        }

    }
}
