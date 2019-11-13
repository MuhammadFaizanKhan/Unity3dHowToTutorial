using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectByTranlsate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move object towars its forwad
        //transform.Translate(Vector3.forward * Time.deltaTime);

        //move object upward
        //transform.Translate(Vector3.up * Time.deltaTime);

        //move towards right
        //transform.Translate(Vector3.left * -1 * Time.deltaTime);


        //move object downwards
        transform.Translate(Vector3.up * -1 * Time.deltaTime);

    }
}
