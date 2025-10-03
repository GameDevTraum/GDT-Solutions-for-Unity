using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TiempoCooldown : MonoBehaviour
{
    public AudioSource miAudioSource;
    public AudioClip miAudioClip;

    public float contadorCooldown;
    public float tiempoCooldown = 2f;

    public TMP_Text miTexto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contadorCooldown > 0f)
        {
            contadorCooldown -= Time.deltaTime;

            //No podemos usar la accion, mostrar porcentaje en texto

            float porcentaje = 100f * (1 - contadorCooldown/tiempoCooldown);

            porcentaje = Mathf.Clamp(porcentaje, 0f, 100f);

            miTexto.text = porcentaje.ToString("F1") + "%";

        }
        else
        {
            //Podemos usar la accion, mostrar "Listo"
            miTexto.text = "Listo!";
        }


        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AplicarAccion();
        }

    }

    public void AplicarAccion()
    {

        if(contadorCooldown <= 0f)
        {
            contadorCooldown = tiempoCooldown;
            miAudioSource.PlayOneShot(miAudioClip);
        }

        

    }

}
