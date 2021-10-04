using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class move_woman : MonoBehaviour
{

    private Transform maincameratrans;
    private Transform cameradir;
    private float sense_mouse = 5f;
    public int who = 0;
    private Animator animator;
    public float moving_speed = 6f;
    int i = 2;
    public int j = 1;
    int count = 0;
    public int d1num = 0;
    public int d2num = 0;
    public int total = 0;
    public int all = 0;
    public GameObject dicep1;
    public GameObject dice1;
    public GameObject dice2;
    public int turn = 0;
    public int fir = 0;
    public bool stop = false;
    public bool tr = false;
    public bool payed = false;

    // Use this for initialization
    void Start()
    {
        CameraDirectionObjectCreate();
        transform.Rotate(0, 90, 0);
        animator = GetComponent<Animator>();
        stop = false;
        tr = false;
    }

    // Update is called once per frame
    void automove()
    {
        animator.SetFloat("speed", 25f);

        moving_speed = 5f;

        transform.localPosition += Time.deltaTime * moving_speed * (cameradir.forward);
    }
    void CameraDirectionObjectCreate()
    {
        GameObject cameradir_object = new GameObject();
        cameradir_object.transform.parent = transform;
        cameradir_object.transform.localPosition = Vector3.zero;
        cameradir_object.name = "CameraDir";
        cameradir = cameradir_object.transform;
    }
    void GetCurrentYAngle()
    {
        if (maincameratrans)
        {
            cameradir.eulerAngles = new Vector3(0, maincameratrans.eulerAngles.y, 0);
        }
    }
    void CameraTurn()
    {
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            //   Debug.Log(Input.GetAxis("Mouse X"));
            transform.Rotate(0, Input.GetAxis("Mouse X") * (float)1.5 * sense_mouse, 0);
            maincameratrans.transform.Rotate(-Input.GetAxis("Mouse Y") * sense_mouse, 0, 0);
            //-Input.GetAxis("Mouse Y") * sense_mouse
        }

    }
    void Update()
    {
        GetCurrentYAngle();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("automove", 0.001f, 0.001f);
        }
        // CameraTurn();
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetFloat("speed", 0f);
            CancelInvoke("automove");
        }
        getdicenum();
        rolldice();
    }
    void rolldice()
    {
        if (dicep1.GetComponent<roll>().doornot == true && who == 2)
        {
            j += d1num + d2num;
            dicep1.GetComponent<roll>().doornot = false;
            if (j > 166)
                j = j - 166;

            CancelInvoke("automove");
            if (turn == 0)
            {
                InvokeRepeating("automove", 0.001f, 0.001f);
            }

        }
    }
    void cornerprocessor(Collision c)
    {
        if (c.gameObject.name == "m43")
        {
            if (transform.position.z.ToString("0.0") == c.gameObject.transform.position.z.ToString("0.0"))
            {
                animator.SetFloat("speed", 0f);
                CancelInvoke("automove");
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
            }
            if (transform.position.x.ToString("0.0") == c.gameObject.transform.position.x.ToString("0.0"))
            {
                // Debug.Log("cz: " + c.gameObject.transform.position.z.ToString("0.0"));
                //  Debug.Log("z: " + transform.position.z.ToString("0.0"));
                // Debug.Log("cx: " + c.gameObject.transform.position.x.ToString("0.0"));
                // Debug.Log("x: " + transform.position.x.ToString("0.0"));
                animator.SetFloat("speed", 0f);
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0.1f, 0, 0);
            }
            if (Mathf.Round(transform.eulerAngles.y) != 0)
            {
                CancelInvoke("automove");
                transform.Rotate(0, -3f, 0);
                turn = 1;
            }
            else
            {
                if ("m43" != ("m" + j))
                {
                    CancelInvoke("automove");
                    InvokeRepeating("automove", 0.001f, 0.001f);
                    turn = 0;
                }
            }


            //Debug.Log("fuck");
        }

        if (c.gameObject.name == "m1")
        {
            if (transform.position.z.ToString("0.0") == c.gameObject.transform.position.z.ToString("0.0"))
            {
                animator.SetFloat("speed", 0f);
                CancelInvoke("automove");
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
            }
            if (transform.position.x.ToString("0.0") == c.gameObject.transform.position.x.ToString("0.0"))
            {
                /* Debug.Log("cz: " + c.gameObject.transform.position.z.ToString("0.0"));
                 Debug.Log("z: " + transform.position.z.ToString("0.0"));
                 Debug.Log("cx: " + c.gameObject.transform.position.x.ToString("0.0"));
                 Debug.Log("x: " + transform.position.x.ToString("0.0"));*/
                animator.SetFloat("speed", 0f);
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0.1f, 0, 0);
            }
            if (Mathf.Round(transform.eulerAngles.y) != 90)
            {
                CancelInvoke("automove");
                transform.Rotate(0, -3f, 0);
                turn = 1;
            }
            else
            {
                if ("m1" != ("m" + j))
                {
                    CancelInvoke("automove");
                    InvokeRepeating("automove", 0.001f, 0.001f);
                    turn = 0;
                }
            }


            //Debug.Log("fuck");
        }
        if (c.gameObject.name == "m126")
        {
            if (transform.position.z.ToString("0.0") == c.gameObject.transform.position.z.ToString("0.0"))
            {
                animator.SetFloat("speed", 0f);
                CancelInvoke("automove");
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
            }
            if (transform.position.x.ToString("0.0") == c.gameObject.transform.position.x.ToString("0.0"))
            {

                animator.SetFloat("speed", 0f);
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0.1f, 0, 0);
            }
            if (Mathf.Round(transform.eulerAngles.y) != 180)
            {
                CancelInvoke("automove");

                transform.Rotate(0, -3f, 0);
                turn = 1;
            }
            else
            {
                if ("m126" != ("m" + j))
                {
                    CancelInvoke("automove");
                    InvokeRepeating("automove", 0.001f, 0.001f);
                    turn = 0;
                }
            }


            //Debug.Log("fuck");
        }




        if (c.gameObject.name == "m84")
        {
            if (transform.position.z.ToString("0.0") == c.gameObject.transform.position.z.ToString("0.0"))
            {
                animator.SetFloat("speed", 0f);
                CancelInvoke("automove");
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
            }
            if (transform.position.x.ToString("0.0") == c.gameObject.transform.position.x.ToString("0.0"))
            {

                animator.SetFloat("speed", 0f);
            }
            else
            {
                if (1 <= j && j < 43)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0.1f, 0, 0);
            }
            if (Mathf.Round(transform.eulerAngles.y) != 270)
            {
                CancelInvoke("automove");
                transform.Rotate(0, -3f, 0);
                turn = 1;
            }
            else
            {
                if ("m84" != ("m" + j))
                {
                    CancelInvoke("automove");
                    InvokeRepeating("automove", 0.001f, 0.001f);
                    turn = 0;
                }
            }


            //Debug.Log("fuck");
        }


    }
    void decide_stop(Collision c)
    {
        if (c.gameObject.name == ("m" + j))
        {
            CancelInvoke("automove");
            if(gameObject.GetComponent<women_buymenu>().tri == true)
            {
                stop = true;
            }


            //Debug.Log("im in");
            if (transform.position.z.ToString("0.0") == c.gameObject.transform.position.z.ToString("0.0"))
            {
                animator.SetFloat("speed", 0f);

            }
            else if (j != 43 && j != 1 && j != 84 && j != 126)
            {
                if (1 <= j && j < 43)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (84 <= j && j < 126)
                    transform.localPosition += new Vector3(0, 0, 0.1f);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0, 0, 0.1f);
            }
            if (transform.position.x.ToString("0.0") == c.gameObject.transform.position.x.ToString("0.0"))
            {

                animator.SetFloat("speed", 0f);
            }
            else if (j != 43 && j != 1 && j != 84 && j != 126)
            {

                if (1 <= j && j < 43)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (43 <= j && j < 84)
                    transform.localPosition += new Vector3(0.1f, 0, 0);
                if (84 <= j && j < 126)
                    transform.localPosition -= new Vector3(0.1f, 0, 0);
                if (j >= 126)
                    transform.localPosition -= new Vector3(0.1f, 0, 0);
            }
        }
    }
    void OnCollisionStay(Collision c)
    {
        cornerprocessor(c);
        decide_stop(c);
        /* if(Mathf.Round(transform.position.x) == Mathf.Round(c.gameObject.transform.position.x)&& Mathf.Round(transform.position.z) == Mathf.Round(c.gameObject.transform.position.z))
         {

           if (dicep1.GetComponent<roll>().doornot == true)
             {
                 j += d1num + d2num;
                 dicep1.GetComponent<roll>().doornot = false;
                 if (j >  166)
                     j = j - 166;

             }

         }
         if (c.collider.gameObject.name != "m" + j)
         {
             InvokeRepeating("automove", 0.001f, 0.001f);
         }*/
        // Debug.Log(j);


    }
    void OnCollisionEnter(Collision c)
    {
        //i += 4;
    }

    void getdicenum()
    {
        d1num = dicep1.GetComponent<roll>().d1num;
        d2num = dicep1.GetComponent<roll>().d2num;
        who = GameObject.Find("end_this_round").GetComponent<change_camera>().who;
    }
}
