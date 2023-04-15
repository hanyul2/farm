using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        var canva = FindObjectsOfType<InvetorySave>();
        if (canva.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
