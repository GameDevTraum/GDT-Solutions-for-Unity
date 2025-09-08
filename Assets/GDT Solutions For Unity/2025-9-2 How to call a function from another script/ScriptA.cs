using UnityEngine;

public class ScriptA : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update!"+gameObject.name);

    }

    public void FunctionToCall()
    {
        Debug.Log("Function From Script A called, I'm "+gameObject.name);
    }




}
