using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    // Start is called before the first frame update
    public Material colorInicial;
    void Start()
    {
        gameObject.GetComponent<Renderer>().material = colorInicial;
    }

    // Update is called once per frame
    void Update()
    {
        colorInicial.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
