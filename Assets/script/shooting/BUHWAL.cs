using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUHWAL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void revive()
    {
        SceneManager.LoadScene("shooting");
        Time.timeScale = 1;
        Debug.Log("∫Œ»∞");
        GameObject.Find("eareum").GetComponent<Attacked>().PH = 10;
    }
}