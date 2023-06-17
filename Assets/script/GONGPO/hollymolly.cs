using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class hollymolly : MonoBehaviour
{
    string T;
    public GameObject _1;
    public GameObject _2;
    public GameObject _3;
    public GameObject _4;
    public GameObject _5;
    public GameObject _6;
    public GameObject _7;
    public GameObject _8;
    public GameObject _9;
    public GameObject _0123456789;
    TextMeshProUGUI ojingeo;
    // Start is called before the first frame update
    void Start()
    {
        ojingeo = GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ojingeo == true)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                T += "1";
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                T += "2";
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                T += "3";
            }
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                T += "4";
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                T += "5";
            }
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                T += "6";
            }
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                T += "7";
            }
            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                T += "8";
            }
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                T += "9";
            }
            if (T.Length > 4)
            {
                T = "";
            }
            ojingeo.text = T;
            if (T == "3456")
            {
                T = "suc";
            }
        }
    }
}