using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Billboard : MonoBehaviour
// keeps player sprite at the same rotation regardless of cam axis
{
    public Transform cam;
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
        
    }
}
