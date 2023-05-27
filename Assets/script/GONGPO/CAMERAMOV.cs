using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAMOV : MonoBehaviour
{
    // Start is called before the first frame update
    public JEONDEUNG j;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector2(1 * Time.deltaTime, 0));
            j.pos += new Vector3(1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector2(-1 * Time.deltaTime, 0));
            j.pos += new Vector3(-1 * Time.deltaTime, 0, 0);
        }
    }
}
