using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ReakTheTree = false;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
