using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllGameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ReakTheTree = false;
    Scene S;
    public List<GameObject> objects;
    public bool IsShootingClear = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        var player = FindObjectsOfType<AllGameControl>();
        if (player.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnSceneLoaded(Scene S, LoadSceneMode mode)
    {
        if (S.name == "shooting")
        {
            foreach (GameObject i in objects)
            {
                i.SetActive(false);
            }
        }
        if (S.name == "SampleScene")
        {
            foreach (GameObject i in objects)
            {
                i.SetActive(true);
            }
        }
    }
}