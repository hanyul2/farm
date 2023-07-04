using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talak : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MeongCheong2;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MONSTER")
        {
            gameObject.transform.position = new Vector3(7, 22, 9);
            StartCoroutine(wasd());
        }
       
    }
    IEnumerator wasd()
    {
        yield return new WaitForSeconds(3f);
        gameObject.transform.position = new Vector3(130.7f, 3.14f, 7);
        MeongCheong2.transform.position = new Vector3(148, 3, 7);
    }
}
