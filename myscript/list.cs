using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class list : MonoBehaviour{

    public bool triggerornot = true;
	// Use this for initialization
	void Start () {
        triggerornot = true;
	}
	
	// Update is called once per frame
	void Update () {
       

    }
    public void valuechange()
    {
        Toggle t1 = GameObject.Find("Checkbox").GetComponent<Toggle>();
        if (t1.isOn)
            triggerornot = true;
        else
            triggerornot = false;
    }
}
