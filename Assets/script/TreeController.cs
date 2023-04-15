using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    // Start is called before the first frame update
    AllGameControl GM;
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent < AllGameControl>();
        if (GM.ReakTheTree == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
