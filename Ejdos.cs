using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejdos : MonoBehaviour
{
    Renderer mrender;
    float t;

    // Start is called before the first frame update
    void Start()
    {
        mrender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 0 && t <= 3)
        {
            mrender.material.color = new Color(1f, 0f, 0f);
        }
        else if (t >= 3 && t <= 6) 
        {
            mrender.material.color = new Color(0f, 0f, 1f);
        }
        else if (t >= 6)
        {
            mrender.material.color = new Color(0.85f, 0f, 0.85f);
        }
        Debug.Log(t);
    }
}
