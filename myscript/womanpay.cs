using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class womanpay : MonoBehaviour {

    // Use this for initialization
    public GameObject paimage;
    public GameObject tex;
    public GameObject bt;
    public GameObject man;
    public GameObject moneyimage;
    public Transform house;
    public GameObject money_text;
    private Transform building;
    private string house_name;
    private int who;
    public int womoney;
    void Start () {
        womoney = 30000;
    }
    

    // Update is called once per frame
    void Update () {
        if (gameObject.GetComponent<move_woman>().who == 2)
            house_name = "house" + gameObject.GetComponent<move_woman>().j;
    }
    void OnCollisionEnter(Collision c)
    {
        if (gameObject.GetComponent<move_woman>().who == 2 && c.collider.name == "m" + gameObject.GetComponent<move_woman>().j)
        {
            show_image();
        }
    }
    void show_image()
    {
        who = gameObject.GetComponent<move_woman>().who;
        if (who == 2)
        {
            house_name = "house" + gameObject.GetComponent<move_woman>().j;
            building = house.transform.Find(house_name);
            if (building != null && building.gameObject.activeSelf == true)
            {
                if (building.tag != "woman" && building.tag != "Untagged" && gameObject.GetComponent<women_buymenu>().tri == true)
                {
                    paimage.SetActive(true);
                    bt.SetActive(true);
                    tex.SetActive(true);
                    womoney = womoney - moneyimage.GetComponent<paymoney>().pass_price[gameObject.GetComponent<move_woman>().j];
                    man.GetComponent<manpay>().manmoney = man.GetComponent<manpay>().manmoney + moneyimage.GetComponent<paymoney>().pass_price[gameObject.GetComponent<move_woman>().j];
                }
            }
        }

    }
}
