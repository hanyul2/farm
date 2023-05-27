using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacked : MonoBehaviour
{
    // Start is called before the first frame update
    public int PH;
    GameObject SLYJ;
    void Start()
    {
        PH = 10;
        SLYJ = GameObject.Find("Sanvas").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (PH <= 0)
        {
            Time.timeScale = 0;
            SLYJ.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nabang")
        {
            PH -= 7;
        }
    }
}