using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuebt : MonoBehaviour {

	// Use this for initialization
    public GameObject fsece;
    public GameObject contibt;
    public GameObject rulebt;
    public GameObject exitbt;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void conti()
    {
        fsece.SetActive(false);
        rulebt.SetActive(false);
        exitbt.SetActive(false);
        contibt.SetActive(false);
    }
}
