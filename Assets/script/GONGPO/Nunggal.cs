using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nunggal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Noonggal;
    bool Shock = false;
    bool OnBeokji = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && OnBeokji == true)
        {
            Shock = !Shock;
            Noonggal.SetActive(Shock);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnBeokji = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        OnBeokji = false;
    }
}
