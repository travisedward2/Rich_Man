using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class paymoney_button : MonoBehaviour {

    // Use this for initialization
    public GameObject image;
    public GameObject text;
    public GameObject button;
    public GameObject money;
    
    int a;
    void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
        /*if (button.activeSelf == true) Debug.Log("aa");
        else Debug.Log("bb");
        */
	}

    /*public void OnPointerClick(PointerEventData eventData)
    {
        image.SetActive(false);
        text.SetActive(false);
        button.SetActive(false);
        
    }*/

    public void click()
    {
        image.SetActive(false);
        text.SetActive(false);
        button.SetActive(false);
        Debug.Log("ssss");
    }
}
