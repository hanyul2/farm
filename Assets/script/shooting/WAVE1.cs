using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WAVE1 : MonoBehaviour
{
    public GameObject TITLE1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TITLE1.transform.position.x >= 1500)
        {
            Destroy(TITLE1.gameObject);
        }
        else
        {
            TITLE1.transform.Translate(new Vector2(1, 0));
        }
    }
}