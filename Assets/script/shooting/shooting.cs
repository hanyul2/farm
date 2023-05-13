using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    bool cooltime = false;
    public List<GameObject> Bullets = new List<GameObject>();
    int PowerLevel;
    void Start()
    {
        PowerLevel = 0;
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
            Instantiate(Bullets[PowerLevel], transform.position,Quaternion.identity);
            cooltime = true;
            StartCoroutine(SetCooltime());
        }
    }
    IEnumerator SetCooltime()
    {
        yield return new WaitForSeconds(0.1f);
        cooltime = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "battery")
        {
            if (Bullets.Count > PowerLevel)
            {
                PowerLevel += 1;
            }
            Destroy(collision.gameObject);
        }
    }
}
