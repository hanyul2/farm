using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nunal_moving : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite Left;
    public Sprite Right;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x <= 5)
        {
            GetComponent<SpriteRenderer>().sprite = Left;
        }
        if (Input.mousePosition.x > 5)
        {
            GetComponent<SpriteRenderer>().sprite = Right;
        }
    }
}