using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GetItem GI = GameObject.Find("GoSoy").transform.GetComponent<GetItem>();
        if (GI.HaveItem == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
