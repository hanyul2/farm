using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simgi : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject obj;
    public GameObject Invetoryi1;
    public GameObject Invetory1;
    void Start()
    {
        obj = GameObject.Find("Grid").transform.GetChild(4).gameObject;    
    }

    // Update is called once per frame
    void Update()
    {
        if (obj == null)
        {
            obj = GameObject.Find("Grid").transform.GetChild(4).gameObject;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Invetoryi1.activeSelf == true)
        {
            if (collision.gameObject.tag == "ImNotABat")
            {
                collision.gameObject.SetActive(false);
                obj.SetActive(true);
                Invetory1.SetActive(false);
            }
        }
        if (collision.gameObject.tag == "success" && Invetoryi1.activeSelf == false && Invetory1.activeSelf == false)
        {
            GameObject.Find("Canvas").transform.GetChild(8).gameObject.SetActive(true);
        }
    }
}
