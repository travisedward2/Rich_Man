using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class re : MonoBehaviour {

    // Use this for initialization
    public GameObject bakcgrd;
    public GameObject box;
    public GameObject sbt;
    public GameObject endbt;
	void Start () {

        box.SetActive(false);
        sbt.SetActive(false);
        gameObject.SetActive(false);
        //endbt.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
