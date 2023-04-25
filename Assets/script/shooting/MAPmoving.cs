using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAPmoving : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject background1;
    public GameObject background2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        background1.transform.Translate(new Vector2(0, -3 * Time.deltaTime));
        background2.transform.Translate(new Vector2(0, -3 * Time.deltaTime));
    }
}
