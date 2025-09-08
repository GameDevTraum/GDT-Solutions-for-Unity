using TMPro;
using UnityEngine;

public class Button_AlternateState : MonoBehaviour
{

    public GameObject gameObjectToAlternate;

    public bool currentState=false;

    public TMP_Text buttonText;

    public string textWhenDisabled = "Switch On";

    public string textWhenEnabled = "Switch Off";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        

        buttonText = transform.GetChild(0).GetComponent<TMP_Text>();

        UpdateElements();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        Debug.Log("Button Click");

        currentState = !currentState;

        UpdateElements();


    }

    void UpdateElements()
    {
        gameObjectToAlternate.SetActive(currentState);

        if (currentState)
        {
            buttonText.text = textWhenEnabled;
        }
        else
        {
            buttonText.text = textWhenDisabled;


        }

    }


}
