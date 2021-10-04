using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class paymoney : MonoBehaviour {

    public GameObject image;
    public GameObject text;
    public GameObject button;
    public GameObject man;
    public GameObject woman;
    public GameObject house;
    public GameObject money_text;
    
    public int man_money = 0;
    public int woman_money = 0;
    public int who;
    public string house_name;
    private Transform building;
    public int [] buy_price = new int[167];
    public int[] pass_price = new int[167];
    
    // Use this for initialization
    void Start () {
        image.SetActive(false);
        text.SetActive(false);
        button.SetActive(false);
        for (int i = 0; i < 167; i++)
        {
            buy_price[i] = 0;
            pass_price[i] = 0;
        }
        setprice();
    }
	
	// Update is called once per frame
	void Update () {
        //money_text.GetComponent<Text>().text = man_money.ToString();
        if (man.GetComponent<move>().who == 1)
            house_name = "house" + man.GetComponent<move>().j;
        else
            house_name = "house" + woman.GetComponent<move_woman>().j;

        if (man.GetComponent<move>().who == 1)
        {
            money_text.GetComponent<Text>().text = (man.GetComponent<manpay>().manmoney).ToString();
        }
        else if (man.GetComponent<move>().who == 2)
        {
            money_text.GetComponent<Text>().text = (woman.GetComponent<womanpay>().womoney).ToString();
        }
    }

    void setprice()
    {
        for (int i = 0; i < 167; ++i)
        {
            if ((i >= 8 && i <= 14) || (i >= 22 && i <= 29) || (i >= 39 && i <= 41) || (i >= 46 && i <= 47)) {
                buy_price[i] = 300; pass_price[i] = 4000;
            }
            if ((i >= 57 && i <= 59) || (i >= 61 && i <= 63) || (i >= 74 && i <= 78))
            {
                buy_price[i] = 250; pass_price[i] = 3500;
            }
            if ((i >= 102 && i <= 104) || (i >= 106 && i <= 108) || (i >= 122 && i <= 124) || (i >= 129 && i <= 130))
            {
                buy_price[i] = 150; pass_price[i] = 3000;
            }
            if ((i >= 141 && i <= 143) || (i >= 145 && i <= 147) || (i >= 155 && i <= 157) || (i >= 159 && i <= 161))
            {
                buy_price[i] = 125; pass_price[i] = 2750;
            }
            if (i == 18)
            {
                buy_price[i] = 900; pass_price[i] = 5000;
            }
            if (i == 34 || i == 115||i==105)
            {
                buy_price[i] = 1500;pass_price[i] = 6000;
            }
            if (i == 50 || i == 70 || i == 93)
            {
                buy_price[i] = 1200;pass_price[i] =4800;
            }
            if (i == 60 || i == 132)
            {
                buy_price[i] = 2000;pass_price[i] = 7000;
            }
            if (i == 105 || i == 144 || i == 158)
            {
                buy_price[i] = 600;pass_price[i] = 4500;                
            }
        }
    }
    
}
