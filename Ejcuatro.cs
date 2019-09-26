using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejcuatro : MonoBehaviour
{
    Transform mtransform;
    Light mlight;

    // Start is called before the first frame update
    void Start()
    {
        mtransform = GetComponent<Transform>();
        mlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        mlight.intensity = (0.5f * mtransform.localScale.magnitude);
    }
}
