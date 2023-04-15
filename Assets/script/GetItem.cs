using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GetItem : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject text1;
    GameObject button1;
    GameObject button2;
    public bool HaveItem = false;
    void Start()
    {
        text1 = GameObject.Find("Canvas").transform.GetChild(1).gameObject;
        button1 = GameObject.Find("Canvas").transform.GetChild(2).gameObject;
        button2 = GameObject.Find("Canvas").transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            text1.GetComponent<TextMeshProUGUI>().text = "Àü¼³¼ÓÀÇ ¾öÃ»³ª°í ±²ÀåÇÏ°í °æÀÌ·Î¿î µµ³¢¿Í ¾¾¾ÑÀ» È¹µæÇß´Ù!";
            text1.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            text1.SetActive(false);
            Destroy(collision.gameObject);
            HaveItem = true;
        }
    }
}
