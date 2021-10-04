using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manpay : MonoBehaviour {

    // Use this for initialization
    public GameObject paimage;
    public GameObject tex;
    public GameObject bt;
    public GameObject woman;
    public GameObject moneyimage;
    public Transform house;
    public GameObject money_text;
    private Transform building;
    private string house_name;
    private int who;
    public int manmoney;
	void Start () {
        manmoney = 30000;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<move>().who == 1)
            house_name = "house" + gameObject.GetComponent<move>().j;
	}
    void OnCollisionEnter(Collision c)
    {
        if (gameObject.GetComponent<move>().who == 1 && c.collider.name == "m"+ gameObject.GetComponent<move>().j)
        {
            show_image();
        }
    }
    void show_image()
    {
        who = gameObject.GetComponent<move>().who;
        if (who == 1)
        {
            house_name = "house" + gameObject.GetComponent<move>().j;
            building = house.transform.Find(house_name);
            if (building != null && building.gameObject.activeSelf == true)
            {
                if (building.tag != "man" && building.tag != "Untagged" && gameObject.GetComponent<buymenu>().tri == true)
                {
                    paimage.SetActive(true);
                    bt.SetActive(true);
                    tex.SetActive(true);
                    manmoney = manmoney - moneyimage.GetComponent<paymoney>().pass_price[gameObject.GetComponent<move>().j];
                    woman.GetComponent<womanpay>().womoney = woman.GetComponent<womanpay>().womoney + moneyimage.GetComponent<paymoney>().pass_price[gameObject.GetComponent<move>().j];
                }               
            }            
        }
        
    }
}
