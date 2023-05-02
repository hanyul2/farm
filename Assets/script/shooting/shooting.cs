using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    bool cooltime = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(new Vector2(0, 3 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector2(-3 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(new Vector2(0, -3 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(new Vector2(3 * Time.deltaTime, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && cooltime == false)
        {
            Instantiate(bullet, transform.position,Quaternion.identity);
            cooltime = true;
            StartCoroutine(SetCooltime());
        }
    }
    IEnumerator SetCooltime()
    {
        yield return new WaitForSeconds(0.2f);
        cooltime = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "battery")
        {
            bullet.GetComponent<shoooting>().damage += 3;
            Destroy(collision.gameObject);
        }
    }
}
