using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class change_camera : MonoBehaviour {

    public Camera camera1;
    public Camera camera2;
    public GameObject woman;
    public GameObject man;
    public int who=1;
    public GameObject bt;
    public GameObject backgrd;
    public GameObject bybox;
    public GameObject surebt;
    public GameObject cost_text;
    int count;
	// Use this for initialization
	void Start () {
        initialstate();
    }
	
    void initialstate()
    {
        who = 1;
        camera2.GetComponent<AudioListener>().enabled = false;
        camera2.GetComponent<Camera>().enabled = false;
        camera1.GetComponent<AudioListener>().enabled = true;
        camera1.GetComponent<Camera>().enabled = true;
        
    }
	// Update is called once per frame
	void Update () {
		
	}
    
    public void setfalse()
    {
       
    }
    public void change()
    {
        man.GetComponent<move>().stop = true;
        backgrd.SetActive(false);
        surebt.SetActive(false);
        bybox.SetActive(false);
        bt.GetComponent<roll>().trigger = false;
        man.GetComponent<buymenu>().buyed = false;
        woman.GetComponent<women_buymenu>().buyed = false;
        woman.GetComponent<move_woman>().tr = false;
        woman.GetComponent<move_woman>().stop = true;
        man.GetComponent<move>().tr = false;
        man.GetComponent<buymenu>().tri = false;
        woman.GetComponent<women_buymenu>().tri = false;
        cost_text.SetActive(false);
        who++;
        if (who == 3)
        {
            who = 1;
        }
        switch (who)
        {
            case 1:
                {
                    camera2.GetComponent<AudioListener>().enabled = false;
                    camera2.GetComponent<Camera>().enabled = false;
                    camera1.GetComponent<AudioListener>().enabled = true;
                    camera1.GetComponent<Camera>().enabled = true;
                    bt.SetActive(true);
                }
                break;
            case 2:
                {
                    camera2.GetComponent<AudioListener>().enabled = true;
                    camera2.GetComponent<Camera>().enabled = true;
                    camera1.GetComponent<AudioListener>().enabled = false;
                    camera1.GetComponent<Camera>().enabled = false;
                    bt.SetActive(true);
                }
                break;
        }
           
        
                
       


       
        
     
    

      }
        
    public void counts()
    {
        count++;
        Debug.Log(count);
    }
}
