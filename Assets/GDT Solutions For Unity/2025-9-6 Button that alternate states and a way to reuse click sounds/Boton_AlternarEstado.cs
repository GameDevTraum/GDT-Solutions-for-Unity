using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Boton_AlternarEstado : MonoBehaviour
{

    public GameObject objetoAAlternar;

    public bool estadoActual = true;

    public TMP_Text textoBoton;

    public string texto_Verdadero;
    public string texto_Falso;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textoBoton = transform.GetChild(0).GetComponent<TMP_Text>();

        ActualizarElementos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Boton_Click()
    {
        Debug.Log("Boton cliqueado!");

        estadoActual = !estadoActual;

        ActualizarElementos();

        

    }

    void ActualizarElementos()
    {
        //objetoAAlternar.SetActive(!objetoAAlternar.activeInHierarchy);

        //objetoAAlternar.SetActive(estadoActual);


        if (estadoActual)
        {
            //lo que haya que hacer si la variable es verdadera
            AlternarObjeto(true);
            textoBoton.text = texto_Verdadero;

        }
        else
        {
            //lo que haya que hacer si la variable es false
            AlternarObjeto(false);
            textoBoton.text = texto_Falso;

        }

    }

    void AlternarObjeto(bool estado)
    {
        objetoAAlternar.SetActive(estado);


    }


}
