using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class women_buymenu : MonoBehaviour {

    // Use this for initialization
    public GameObject background;
    public GameObject buybox;
    public GameObject surebt;
    public GameObject endthisturnbt;
    public GameObject dice;
    public bool tri = false;
    public bool buyed = false;
    public GameObject man;
    public Transform house;
    private string house_name;
    public GameObject cost;
    public GameObject cost_text;
    void Start () {
        buyed = false;
        tri = false;
    }
	
	// Update is called once per frame
	void Update () {
        house_name = "house" + gameObject.GetComponent<move_woman>().j;
        if (tri == true && gameObject.GetComponent<move_woman>().stop == true && buyed == false && gameObject.GetComponent<move_woman>().tr == true && man.GetComponent<move>().j == gameObject.GetComponent<move_woman>().j && house.Find(house_name) != null)
        {
            if (house.Find(house_name).tag == "Untagged")
            {
                background.SetActive(true);
                buybox.SetActive(true);
                surebt.SetActive(true);
                cost_text.SetActive(true);
            }
        }
    }

    void OnCollisionStay(Collision c)
    {
        buildevent(c);
    }

    void buildevent(Collision c)
    {
        if (gameObject.GetComponent<move_woman>().stop == true && buyed == false && gameObject.GetComponent<move_woman>().tr == true)
        {
            Transform t = house.Find(house_name);
            if (t != null && t.tag == "Untagged")
            {
                string text = "房價: " + cost.GetComponent<paymoney>().buy_price[gameObject.GetComponent<move_woman>().j];
                cost_text.GetComponent<Text>().text = text;
                if (c.gameObject.name == "m8" || c.gameObject.name == "m9" || c.gameObject.name == "m10" || c.gameObject.name == "m11" || c.gameObject.name == "m12" || c.gameObject.name == "m13" || c.gameObject.name == "m14"|| c.gameObject.name == "m18")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true);
                    cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m22" || c.gameObject.name == "m23" || c.gameObject.name == "m24" || c.gameObject.name == "m25" || c.gameObject.name == "m26" || c.gameObject.name == "m27" || c.gameObject.name == "m28" || c.gameObject.name == "m29")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true);
                    cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m34" || c.gameObject.name == "m39" || c.gameObject.name == "m40" || c.gameObject.name == "m41"  || c.gameObject.name == "m46" || c.gameObject.name == "m47")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m50" || c.gameObject.name == "m57" || c.gameObject.name == "m58" || c.gameObject.name == "m59" || c.gameObject.name == "m60" || c.gameObject.name == "m61" || c.gameObject.name == "m62" || c.gameObject.name == "m63")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m70" || c.gameObject.name == "m74" || c.gameObject.name == "m75" || c.gameObject.name == "m76" || c.gameObject.name == "m77" || c.gameObject.name == "m78")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m93" || c.gameObject.name == "m102" || c.gameObject.name == "m103" || c.gameObject.name == "m104" || c.gameObject.name == "m105" || c.gameObject.name == "m106" || c.gameObject.name == "m107" || c.gameObject.name == "m108")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m115" || c.gameObject.name == "m122" || c.gameObject.name == "m123" || c.gameObject.name == "m124" ||  c.gameObject.name == "m129" || c.gameObject.name == "m130")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m132" || c.gameObject.name == "m141" || c.gameObject.name == "m142" || c.gameObject.name == "m143" || c.gameObject.name == "m144" || c.gameObject.name == "m145" || c.gameObject.name == "m146" || c.gameObject.name == "m147")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                else if (c.gameObject.name == "m155" || c.gameObject.name == "m156" || c.gameObject.name == "m157" || c.gameObject.name == "m158" || c.gameObject.name == "m159" || c.gameObject.name == "m160" || c.gameObject.name == "m161")
                {
                    background.SetActive(true);
                    buybox.SetActive(true);
                    surebt.SetActive(true); cost_text.SetActive(true);
                }
                /* else
                 {
                     background.SetActive(false);
                     buybox.SetActive(false);
                     surebt.SetActive(false);
                 }*/
            }
        }
    }
}
