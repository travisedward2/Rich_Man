using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class payhowmuch : MonoBehaviour {
    public GameObject moneyimage;
    public GameObject man;
    public GameObject woman;
    public GameObject Text;
    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        set_text();
	}
    void set_text()
    {
        if (man.GetComponent<move>().who==1)
        {
            string text = "收取過路費 " + moneyimage.GetComponent<paymoney>().pass_price[man.GetComponent<move>().j]+" USD";
            Text.GetComponent<Text>().text = text;
        }
        if (man.GetComponent<move>().who == 2)
        {

            string text = "收取過路費 " + moneyimage.GetComponent<paymoney>().pass_price[woman.GetComponent<move_woman>().j] + " USD";
            Text.GetComponent<Text>().text = text;
            Debug.Log(text);
        }
    }

}
