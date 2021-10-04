using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class confirm_button_state : MonoBehaviour {
    public GameObject checkbutton;
    public GameObject confirm;
    public GameObject back;
    public GameObject man;
    public GameObject moneyima;
    public Transform house;
    public GameObject woman;
    public GameObject cost_text;
    private Transform building;
    private string house_name;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (man.GetComponent<move>().who == 1)
            house_name = "house" + man.GetComponent<move>().j;
        else if (man.GetComponent<move>().who == 2)
            house_name = "house" + woman.GetComponent<move_woman>().j;
    }
    public void confirm_buy()
    {
        if (checkbutton.GetComponent<list>().triggerornot == true)
        {
            building = house.transform.Find(house_name);
            building.gameObject.SetActive(true);
            if(man.GetComponent<move>().who == 1)
            {
                building.tag = "man";
                man.GetComponent<manpay>().manmoney = man.GetComponent<manpay>().manmoney - moneyima.GetComponent<paymoney>().buy_price[man.GetComponent<move>().j];
            }
            else if (man.GetComponent<move>().who == 2)
            {
                building.tag = "woman";
                woman.GetComponent<womanpay>().womoney = woman.GetComponent<womanpay>().womoney - moneyima.GetComponent<paymoney>().buy_price[woman.GetComponent<move_woman>().j];
            }

        }
        else
        {

        }
        Canvas_disappear();
    }
    public void Canvas_disappear()
    {
        if (man.GetComponent<move>().who == 1)
        {
            man.GetComponent<buymenu>().buyed = true;
        }
        else if(man.GetComponent<move>().who==2)
        {
            woman.GetComponent<women_buymenu>().buyed = true;   
        }
        cost_text.GetComponent<Text>().text = null;
        cost_text.SetActive(false);
        back.SetActive(false);
        checkbutton.SetActive(false);
        gameObject.SetActive(false);

    }

}

