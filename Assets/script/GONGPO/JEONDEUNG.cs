using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class JEONDEUNG : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pos;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        Vector3 t = Camera.main.ViewportToWorldPoint(new Vector3(pos.x, pos.y, 0));
        transform.position = new Vector3(t.x, t.y, 0);
        Debug.Log(pos);
    }
}