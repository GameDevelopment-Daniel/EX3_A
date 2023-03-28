using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class totalt_line : MonoBehaviour
{
    public float speed = 0.75f;   // Speed of the pendulum swing
    public float max_rotauin_z = 90;  // Maximum swing angle in degrees
    
    void Update()
    {
        float angle =  Mathf.Sin(Time.time * speed) * max_rotauin_z/1.5f;
        Debug.Log("angel=" + angle + ", time=" + Time.time);

        transform.rotation = Quaternion.Euler(0, 0, angle);
        
    }
}
