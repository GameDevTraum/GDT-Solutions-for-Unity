using Unity.VisualScripting;
using UnityEngine;

public class IterarSobreLosChildsDeUnGameObject : MonoBehaviour
{

    public GameObject objetoPadre;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int cantidadHijos;

    public void ButtonClick()
    {
        Debug.Log("Button was pressed!");
        IterarSobreHijos();
    }


    public float distanciaEntreObjetos = 2f;
    public float offsetInicial = 5f;
    public float altura = 2f;
    void IterarSobreHijos()
    {

        cantidadHijos = objetoPadre.transform.childCount;

        for (int i = 0; i < cantidadHijos; i++)
        {

            Transform unHijo = objetoPadre.transform.GetChild(i);

            Debug.Log(unHijo.name);

            unHijo.name = "Hijo número " + (i + 1).ToString();

            unHijo.position = Vector3.right * i * distanciaEntreObjetos + Vector3.left * offsetInicial;


            Rigidbody elRigidbodyDelHijo = unHijo.AddComponent<Rigidbody>();
            elRigidbodyDelHijo.useGravity = false;

            if ( i % 2 == 0)
            {
                //Par
                unHijo.position += Vector3.up * altura;

                elRigidbodyDelHijo.linearVelocity = Vector3.down * 0.1f;

            }
            else
            {
                //impar
                unHijo.position += Vector3.down * altura;

                elRigidbodyDelHijo.linearVelocity = Vector3.up * 0.1f;


            }

            unHijo.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

            

        }
    }

}
