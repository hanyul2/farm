using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoooting : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector2(0, 2 * Time.deltaTime));
    }
}