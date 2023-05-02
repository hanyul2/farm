using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nabang : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector2(0,  -2 * Time.deltaTime));
        die();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            HP = HP - collision.gameObject.GetComponent<shoooting>().damage;
            Destroy(collision.gameObject);
        }
    }
    void die()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
