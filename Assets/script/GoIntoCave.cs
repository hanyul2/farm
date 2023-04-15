using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoIntoCave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cave")
        {
            SceneManager.LoadScene("cave");
        }
        if (collision.gameObject.tag == "ojingeo")
        {
            SceneManager.LoadScene("SampleScene");
            transform.position = new Vector2(7.5f, -3);
        }
    }
}
