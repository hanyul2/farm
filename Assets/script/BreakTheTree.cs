using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakTheTree : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject qwerty;
    AllGameControl GM;
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<AllGameControl>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "weakest tree")
        {
            qwerty.SetActive(true);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (collision.gameObject.tag == "weakest tree")
            {
                GameObject[] werty = GameObject.FindGameObjectsWithTag("weakest tree");
                for (int i = 0; i<werty.Length; i++)
                {
                    Destroy(werty[i]);
                }
                GM.ReakTheTree = true;
            }
        }
    }
}
