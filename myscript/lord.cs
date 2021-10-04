using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;


public class lord : MonoBehaviour {

    public Sprite man_pic;
    public Sprite woman_pic;
    public Sprite ui;
    public GameObject man;
    public GameObject woman;
    public GameObject house;
	// Use this for initialization
   
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        picture_select();
	}
    void picture_select()
    {
        if (man.GetComponent<move>().who == 1)
        {
            string house_name = "house" + man.GetComponent<move>().j;
            Transform building = house.transform.Find(house_name);
            if (building != null)
            {
                if(building.tag=="man") transform.Find("pic").GetComponent<Image>().sprite = man_pic;
                else if(building.tag=="woman")transform.Find("pic").GetComponent<Image>().sprite = woman_pic;
                else this.transform.Find("pic").GetComponent<Image>().sprite = ui;
            }
            else
            {
                transform.Find("pic").GetComponent<Image>().sprite = ui;
            }
        }
        if (man.GetComponent<move>().who == 2)
        {
            string house_name = "house" + woman.GetComponent<move_woman>().j;
            Transform building = house.transform.Find(house_name);
            if (building != null)
            {
                if (building.tag == "man") this.transform.Find("pic").GetComponent<Image>().sprite = man_pic;
                else if (building.tag == "woman") this.transform.Find("pic").GetComponent<Image>().sprite = woman_pic;
                else this.transform.Find("pic").GetComponent<Image>().sprite = ui;
            }
            else
            {
                this.transform.Find("pic").GetComponent<Image>().sprite = ui;
            }
        }
    }
    void reset()
    {
        
    }
}
