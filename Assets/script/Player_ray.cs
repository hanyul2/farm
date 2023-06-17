using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_ray : MonoBehaviour
{
    // Start is called before the first frame update
    RaycastHit hit;
    public TextMeshProUGUI ojingeo;
    GameObject obj;
    GameObject abj;

    void Start()
    {
        obj = GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject;
        abj = GameObject.Find("seed").gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit,  5))
        {
            if (hit.collider.name == "seed")
            {
             if (Input.GetKeyDown(KeyCode.F))
                {
                    abj.SetActive(true);
                }
            }
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * hit.distance, Color.red);
            if (hit.collider.name == "NPC 1")
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
        }
        else
        {
            obj.SetActive(false);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position, this.transform.forward * 5);
    }

}