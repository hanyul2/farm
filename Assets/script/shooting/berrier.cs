using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nabang")
        {
            GameObject.Find("Sanvas").transform.GetChild(0).gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
