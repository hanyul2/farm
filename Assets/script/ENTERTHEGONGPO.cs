using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENTERTHEGONGPO : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject qwer;
    public GameObject zxcv;
    public GameObject qaz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NAGA")
        {
            Destroy(gameObject);
            Destroy(qwer);
            Destroy(zxcv);
            Destroy(qaz);
            SceneManager.LoadScene("GONGPO");
        }
    }
}
