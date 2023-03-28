using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_script : MonoBehaviour
{
    void Update()
    {
        Transform t=GetComponent<Transform>();
        t.Rotate(0,0,20*Time.deltaTime);
    }
}
