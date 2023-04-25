using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvetoryController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Invetoryi1;
    public GameObject Invetoryi2;
    public GameObject Invetory1;
    public GameObject Invetory2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && Invetoryi1.activeSelf == true)
        {
            Invetory1.SetActive(true);
            Invetory2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && Invetoryi2.activeSelf == true)
        {
            Invetory2.SetActive(true);
            Invetory1.SetActive(false);
        }
    }
}
