using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulka : MonoBehaviour
{
    gra mojaGra;
    void Start()
    {
        mojaGra = FindObjectOfType<gra>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3) {
            mojgaGra.DodajPunkt();
            Destroy(this.gameObject);
        };
    }
}