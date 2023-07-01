using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class muving : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 4.0f;
    SpriteRenderer obj;
    public Sprite[] walking = new Sprite[3];
    void Start()
    {
        obj = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, speed*Time.deltaTime));
            obj.sprite = walking[2];
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-speed*Time.deltaTime, 0));
            obj.sprite = walking[1];
            obj.flipX = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -speed*Time.deltaTime));
            obj.sprite = walking[0];
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(speed*Time.deltaTime, 0));
            obj.sprite = walking[1];
            obj.flipX = true;
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            obj.sprite = walking[0];
        }
    }
}
