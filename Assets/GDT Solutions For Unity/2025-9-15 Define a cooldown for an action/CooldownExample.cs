using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CooldownExample : MonoBehaviour
{

    public AudioSource myAudioSource;
    public AudioClip testSound;

    public float cooldownCounter;
    public float cooldownMaxTime = 2f;

    public TMP_Text textCooldown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(cooldownCounter > 0)
        {
            //We are waiting, cannot perform action
            //show loading percentage on text
            cooldownCounter -= Time.deltaTime;

            float percentage = 100f * (1 - cooldownCounter / cooldownMaxTime);

            percentage = Mathf.Clamp(percentage, 0f, 100f);


            textCooldown.text = percentage.ToString("F1") + "%";

        }
        else
        {
            //action can be performed
            //display "Ready" on text

            textCooldown.text = "Ready";

        }




        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            PerformAction();
        }
    }

    public void PerformAction()
    {
        if (cooldownCounter <= 0f)
        {
            cooldownCounter = cooldownMaxTime;
            myAudioSource.PlayOneShot(testSound);

        }

    }



}
