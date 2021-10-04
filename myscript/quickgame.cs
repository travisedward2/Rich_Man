using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickgame : MonoBehaviour {

    public int windowWidth = 100;
    public int windowHight = 50;
    Rect windowRect;
    int windowSwitch = 0;
    float alpha = 0;

    // Use this for initialization
    void GUIAlphaColor_0_To_1()
    {
        if (alpha < 1)
        {
            alpha += Time.deltaTime;
            GUI.color = new Color(1, 1, 1, alpha);
        }
    }
    void Start () {
        windowRect = new Rect(
            (Screen.width - windowWidth) / 2,
            (Screen.height - windowHight) / 2,
            windowWidth,
            windowHight);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void quit()
    {
        
            windowSwitch = 1;
            alpha = 0; // Init Window Alpha Color
    }
    void OnGUI()
    {
        if (windowSwitch == 1)
        {
            GUIAlphaColor_0_To_1();
            windowRect = GUI.Window(0, windowRect, QuitWindow, "Quit Window");
        }
    }
    void QuitWindow(int windowID)
    {
        GUI.Label(new Rect(100, 50, 600, 100), "Are you sure you want to quit game ?");

        if (GUI.Button(new Rect(80, 110, 100, 30), "Quit"))
        {
            Application.Quit();
        }
        if (GUI.Button(new Rect(220, 110, 100, 30), "Cancel"))
        {
            windowSwitch = 0;
        }

        GUI.DragWindow();
    }

}
