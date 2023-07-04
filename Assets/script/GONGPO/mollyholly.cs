using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mollyholly : MonoBehaviour
{
    // Start is called before the first frame update
    public Material frame1;
    public Material frame2;
    public Material frame3;
    public Material frame4;
    public Material frame5;
    MeshRenderer mesh;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material = frame1;
        StartCoroutine(changeframe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator changeframe()
    {
        yield return new WaitForSeconds(0.3f);
        mesh.material = frame1;
        yield return new WaitForSeconds(0.3f);
        mesh.material = frame2;
        yield return new WaitForSeconds(0.3f);
        mesh.material = frame3;
        yield return new WaitForSeconds(0.3f);
        mesh.material = frame4;
        yield return new WaitForSeconds(0.3f);
        mesh.material = frame5;
        StartCoroutine(changeframe());
    }
}
