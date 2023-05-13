using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chinabluebug : MonoBehaviour
{
    // Start is called before the first frame update
    private int spaad = 1;
    public GameObject Player;
    int BugHP;
    public GameObject warn;
    bool coltime = true;
    GameObject[] Explodes;
    void Start()
    {
        BugHP = 2023;
        StartCoroutine(SetColtime2());
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector2(0, -spaad * Time.deltaTime));
        if (transform.position.y <= 2.5)
        {
            spaad = 0;
        }
        Attack();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            BugHP -= 11;
            Destroy(collision.gameObject);
        }
        if (BugHP <= 0)
        {
            Destroy(gameObject);
            Explodes = GameObject.FindGameObjectsWithTag("canation");
            foreach (GameObject e in Explodes)
            {
                Destroy(e);
            }
        }
    }
    void Attack()
    {
        if (coltime == false)
        {
            var TMP = Instantiate(warn, Player.transform.position, Quaternion.identity);
            coltime = true;
            StartCoroutine(SetColtime());
        }
    }
    IEnumerator SetColtime()
    {
        yield return new WaitForSeconds(5);
        coltime = false;
    }
    IEnumerator SetColtime2()
    {
        yield return new WaitForSeconds(30);
        coltime = false;
    }
}
