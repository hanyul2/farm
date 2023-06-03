using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class JEONDEUNG : MonoBehaviour
{
    // Start is called before the first frame update
    public float CS = 10f;
    public Vector3 pos;
    public bool isgamestart = false;
    Transform cameraPos;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        StartCoroutine(gameStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector2(1 * Time.deltaTime, 0));
            //j.pos += new Vector3(1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector2(-1 * Time.deltaTime, 0));
            //j.pos += new Vector3(-1 * Time.deltaTime, 0, 0);
        }
        /*
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        Vector3 t = Camera.main.ViewportToWorldPoint(new Vector3(pos.x, pos.y, 0));
        transform.position = new Vector3(t.x, t.y, 0);
        Debug.Log(pos);
        */
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        if (isgamestart)
        transform.position += new Vector3(x * Time.deltaTime * CS, y * Time.deltaTime * CS, 0);
        
        cameraPos = Camera.main.gameObject.transform;
        if (transform.position.x < -2 + cameraPos.position.x)
            transform.position = new Vector2(-2 + cameraPos.position.x, transform.position.y);
        if (transform.position.x > 2 + cameraPos.position.x)
            transform.position = new Vector2(2 + cameraPos.position.x, transform.position.y);
        if (transform.position.y < -1 + cameraPos.position.y)
            transform.position = new Vector2(transform.position.x, -1 + cameraPos.position.y);
        if (transform.position.y > 1 + cameraPos.position.y)
            transform.position = new Vector2(transform.position.x, 1 + cameraPos.position.y);
    }
    IEnumerator gameStart()
    {
        yield return new WaitForSeconds(0.5f);
        isgamestart = true;
    }
}