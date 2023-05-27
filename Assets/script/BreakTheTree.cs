using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BreakTheTree : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject qwerty;
    AllGameControl GM;
    InvetoryController MG;
    GameObject GG;
    public GameObject daesa;
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<AllGameControl>();
        MG = GameObject.Find("GoSoy").GetComponent<InvetoryController>();
        GG = GameObject.Find("Canvas").transform.GetChild(7).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameManager").gameObject.GetComponent<AllGameControl>().IsShootingClear == true)
        {
            daesa.GetComponent<TextMeshProUGUI>().text = "아니 자네, 작물까지 없애면 어떡하나!";
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "weakest tree" && MG.Invetory2.activeSelf == true)
        {
            qwerty.SetActive(true);
        }
        if (MG.Invetory2.activeSelf == true)
        {
            if (collision.gameObject.tag == "fish")
            {
                GG.SetActive(true);
            }
        }
        if (collision.gameObject.tag == "chonjang")
        {
            daesa.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "weakest tree")
        {
            qwerty.SetActive(false);
        }
        if (collision.gameObject.tag == "fish")
        {
            GG.SetActive(false);
        }
        if (collision.gameObject.tag == "chonjang")
        {
            daesa.SetActive(false);
        }
    }
        private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && MG.Invetory2.activeSelf == true)
        {
            if (collision.gameObject.tag == "weakest tree")
            {
                GameObject[] werty = GameObject.FindGameObjectsWithTag("weakest tree");
                for (int i = 0; i<werty.Length; i++)
                {
                    Destroy(werty[i]);
                    qwerty.SetActive(false);
                }
                GM.ReakTheTree = true;
            }
        }
    }
}