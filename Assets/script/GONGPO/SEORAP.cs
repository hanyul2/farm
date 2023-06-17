using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEORAP : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SY;
    public GameObject AIKJIA;
    bool Y = false;
    bool D = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && D == true)
        {
            Y = !Y;
            SY.SetActive(Y);
            AIKJIA.SetActive(Y);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        D = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        D = false;
    }
}
