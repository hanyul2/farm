using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAPmoving : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        background1.transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        background2.transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        background3.transform.Translate(new Vector2(0, -speed * Time.deltaTime));

        if (background2.transform.position.y <= -12)
        {
            background2.transform.position = new Vector2(0, 12);
        }
        if (background1.transform.position.y <= -12)
        {
            background1.transform.position = new Vector2(0, 12);
        }
        if (background3.transform.position.y <= -12)
        {
            background3.transform.position = new Vector2(0, 12);
        }
    }
}
