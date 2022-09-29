using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgitatorMove : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,20);
    }
}
