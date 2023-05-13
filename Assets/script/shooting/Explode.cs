using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite P1;
    public Sprite P2;
    public GameObject Redbox;
    SpriteRenderer Sp;
    bool Exploding = false;
    void Start()
    {
        Sp = GetComponent<SpriteRenderer>();
        StartCoroutine(Change());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Change()
    {
        yield return new WaitForSeconds(1);
        Sp.sprite = P1;
        yield return new WaitForSeconds(1);
        Sp.sprite = P2;
        Exploding = true;
        transform.localScale = new Vector2(2, 2);
        Redbox.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" && Exploding == true)
        {
            collision.gameObject.GetComponent<Attacked>().PH -= 10;
        }
    }
}