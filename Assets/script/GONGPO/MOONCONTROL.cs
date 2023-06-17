using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOONCONTROL : MonoBehaviour
{
    // Start is called before the first frame update
    bool YL = false;
    bool DH = false;
    public GameObject sutja;
    public GameObject ojingu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && YL == true)
        {
            DH = !DH;
            sutja.SetActive(DH);
            ojingu.SetActive(DH);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        YL = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        YL = false;
    }
}
