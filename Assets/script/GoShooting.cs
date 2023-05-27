using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoShooting : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        var player = FindObjectsOfType<GoShooting>();
        if (player.Length == 1)
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
    public void tuechi()
    {
        SceneManager.LoadScene("shooting");
    }
}
