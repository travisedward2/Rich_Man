using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbt : MonoBehaviour {

    // Use this for initialization
    public GameObject startbtt;
    public GameObject rulebt;
    public GameObject exitbt;
    public GameObject fstsc;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void startt()
    {
        rulebt.SetActive(false);
        exitbt.SetActive(false);
        fstsc.SetActive(false);
        startbtt.SetActive(false);
    }
}
