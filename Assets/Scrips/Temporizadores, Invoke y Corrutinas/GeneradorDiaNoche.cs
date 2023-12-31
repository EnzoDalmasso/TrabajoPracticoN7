using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDiaNoche : MonoBehaviour
{
    [SerializeField] private Camera camara;
    [SerializeField] private Color nocheColor;
    [SerializeField] private float segundos;

    private Color diaColor;

    void Start()
    {
        diaColor = camara.backgroundColor;
        StartCoroutine(CambiarColor(segundos)); ;
    }

    IEnumerator CambiarColor(float tiempo)
    {
        Color colorDestino = camara.backgroundColor == diaColor ? nocheColor : diaColor;
        float duracionCiclo = tiempo * 0.6f;
        float duracionCambio = tiempo * 0.4f;

      
        while (true)
        {
            yield return new WaitForSeconds(tiempo);
            camara.backgroundColor = camara.backgroundColor == diaColor ?
                                        camara.backgroundColor = nocheColor :
                                        camara.backgroundColor = diaColor;
        }
    }
}