using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject youdie;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "MONSTER")
       {
            youdie.SetActive(true);
       }
    }
}
