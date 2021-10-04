using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goback : MonoBehaviour {

    // Use this for initialization
    public GameObject fscsc;
    public GameObject contbt;
    public GameObject rulebt;
    public GameObject exitbt;
    public GameObject ruleima;
	void Start () {
        contbt.SetActive(false);
        ruleima.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            fscsc.SetActive(true);
            contbt.SetActive(true);
            rulebt.SetActive(true);
            exitbt.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.H))
            ruleima.SetActive(false);
	}
}
