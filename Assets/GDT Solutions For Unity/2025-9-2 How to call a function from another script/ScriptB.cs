using UnityEngine;

public class ScriptB : MonoBehaviour
{

    public ScriptA theOtherScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theOtherScript.FunctionToCall();

    }
}
