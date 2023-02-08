using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Tiempo : MonoBehaviour
{
    public TMP_Text textoTiempo;
    public float cambio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cambio= cambio + Time.deltaTime;
        textoTiempo.text = (cambio).ToString();
    }
}
