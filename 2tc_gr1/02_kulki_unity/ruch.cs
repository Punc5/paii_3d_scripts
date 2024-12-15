using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
    private float a = 0; 
    float przyciskRuch = 0;
    public int b = 6; //zmienna typu całkowitego
    [Range(-1,1000)] public float c = 0;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        a = Input.GetAxis("Vertical");
        przyciskRuch = Input.GetAxis("Horizontal");
        /*
        transform.Translate(Vector3.forward * c * a);
        transform.Translate(Vector3.right * c * przyciskRuch);
        */
        rb.AddForce(Vector3.forward * c * a);

    }
}