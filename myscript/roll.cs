using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;


public class roll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Sprite[] pic = new Sprite[6];
    public int d1num = 0;
    public int d2num = 0;
    public bool doornot = false;
    public bool trigger = false;
    public GameObject man;
    public GameObject woman;
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        int d1 = Random.Range(0, 6);
        int d2 = Random.Range(0, 6);
       //int d1 = 98;
       //int d2 = 1;
        d1num = d1 + 1;
        d2num = d2 + 1;

        Button b1 = GameObject.Find("dice1p1").GetComponent<Button>();
        Button b2 = GameObject.Find("dice2p1").GetComponent<Button>();
        switch (d1)
        {
            case 0:
                b1.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("1");
                break;
            case 1:
                b1.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("2");
                break;
            case 2:
                b1.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("3");
                break;
            case 3:
                b1.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("4");
                break;
            case 4:
                b1.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("5");
                break;
            case 5:
                b1.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("6");
                break;
        }
        switch (d2)
        {
            case 0:
                b2.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("1");
                break;
            case 1:
                b2.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("2");
                break;
            case 2:
                b2.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("3");
                break;
            case 3:
                b2.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("4");
                break;
            case 4:
                b2.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("5");
                break;
            case 5:
                b2.GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>("6");
                break;
        }
        doornot = true;
        trigger = true;
        if (man.GetComponent<move>().who == 1)
        {
            man.GetComponent<move>().tr = true;
            woman.GetComponent<move_woman>().tr = false;
            man.GetComponent<move>().stop = false;
            woman.GetComponent<move_woman>().stop = true;
            man.GetComponent<buymenu>().tri = true;
            woman.GetComponent<women_buymenu>().tri = false;
        }
        else if (man.GetComponent<move>().who == 2)
        {
            man.GetComponent<move>().tr = false;
            woman.GetComponent<move_woman>().tr = true;
            man.GetComponent<move>().stop = true;
            woman.GetComponent<move_woman>().stop = false;
            man.GetComponent<buymenu>().tri = false;
            woman.GetComponent<women_buymenu>().tri = true;
        }
        gameObject.SetActive(false);
        
    }

}
