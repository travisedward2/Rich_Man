using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class whowin : MonoBehaviour {

    public GameObject man;
    public GameObject woman;
    public Sprite m;
    public Sprite w;
    public GameObject ima;
    public GameObject text;
    public GameObject a;
    bool end=false;
	// Use this for initialization
	void Start () {
        ima.SetActive(false);
        text.SetActive(false);
        a.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ima.SetActive(false);
            text.SetActive(false);
            a.SetActive(false);
            end = true;
        }
        if (end == false)
        {
            if (man.GetComponent<manpay>().manmoney >= 35000)
            {
                ima.SetActive(true);
                text.SetActive(true);
                a.SetActive(true);
                a.GetComponent<Image>().sprite = m;
                text.GetComponent<Text>().text = "This guy win! ";
            }
            else if (woman.GetComponent<womanpay>().womoney >= 35000)
            {
                ima.SetActive(true);
                text.SetActive(true);
                a.SetActive(true);
                a.GetComponent<Image>().sprite = w;
                text.GetComponent<Text>().text = "This girl win!";
            }
            else if (man.GetComponent<manpay>().manmoney <= 0)
            {
                ima.SetActive(true);
                text.SetActive(true);
                a.SetActive(true);
                a.GetComponent<Image>().sprite = w;
                text.GetComponent<Text>().text = "This girl win!";

            }
            else if (woman.GetComponent<womanpay>().womoney <= 0)
            {
                ima.SetActive(true);
                text.SetActive(true);
                a.SetActive(true);
                a.GetComponent<Image>().sprite = m;
                text.GetComponent<Text>().text = "This guy win!";
            }
        }
       
    }
}
