using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw : MonoBehaviour
{
    void FixedUpdate()
    {
        //transform.eulerAngles += Vector3.forward;
        transform.Rotate(new Vector3(0,0,1),3,Space.Self);
    }
}
