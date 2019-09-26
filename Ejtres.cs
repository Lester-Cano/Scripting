using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejtres : MonoBehaviour
{
    Light mlight;
    
    // Start is called before the first frame update
    void Start()
    {
        mlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mlight.intensity >= 0.25 && mlight.intensity <= 0.5)
        {
            mlight.color = new Color(0, 0, 1);
        }
        if (mlight.intensity >= 0.5 && mlight.intensity <= 0.75)
        {
            mlight.color = new Color(1, 0, 0);
        }
        if (mlight.intensity >= 0.75)
        {
            mlight.color = new Color(1, 1, 1);
        }
    }
}
