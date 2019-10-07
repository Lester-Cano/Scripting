using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores : MonoBehaviour
{

    Renderer mrenderer;
    Color azul = new Color (0f, 0f, 0.85f);
    Color morado = new Color(0.85f, 0f, 0.85f);
    Color rojo = new Color(0.85f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        mrenderer = GetComponent<Renderer>();
        mrenderer.material.color = azul;
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        mrenderer.material.color = morado;
    }

    private void OnCollisionExit(Collision collision)
    {
        mrenderer.material.color = rojo;
    }

}
