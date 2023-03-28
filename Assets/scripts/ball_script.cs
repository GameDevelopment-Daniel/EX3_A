using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball_script : MonoBehaviour
{
    const int Phase0 = 0;
    const int Phase1 = 1;
    const int Phase2 = 2;
    const int Phase3 = 3;

    int scalePhase = 0;
    float scaleChange = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        Transform t = GetComponent<Transform>();
        t.localScale=new Vector3(0.33f,0.33f,0.2f);

    }

    // Update is called once per frame
    void Update() //עליה גדולה,ירידה קטנה,עליה קטנה ,ירידה עד הסוף
    {
        Transform t =GetComponent<Transform>();
        if (scalePhase == Phase0 && t.localScale[0] >= 0.395)//move to 1 phase
        {
            scalePhase = Phase1;
            scaleChange = -0.15f;
        }
        if (scalePhase == Phase1 && t.localScale[0] <= 0.36)//from phase 1->2
        {
            scalePhase= Phase2;
            scaleChange = 0.2f;
        }
        
        if (scalePhase == Phase2 && t.localScale[0] >= 0.44)//from phase 2->3
        {
            scalePhase= Phase3;
            scaleChange = -0.1f;
        }
        if (scalePhase == Phase3 && t.localScale[0] <= 0.33)//from phase 3->0
        {
            scalePhase= Phase0;
            scaleChange= 0.15f;
        }

        t.localScale += new Vector3(scaleChange,scaleChange,scaleChange) * Time.deltaTime;
    }
}
