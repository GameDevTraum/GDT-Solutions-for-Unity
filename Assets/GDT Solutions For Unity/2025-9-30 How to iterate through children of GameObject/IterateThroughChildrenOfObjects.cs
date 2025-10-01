using Unity.VisualScripting;
using UnityEngine;

public class IterateThroughChildrenOfObjects : MonoBehaviour
{
    public GameObject myParentObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        Debug.Log("Button was pressed!");
        IterateThroughChildren();
    }

    public int childCount;

    public float initialOffset = 5f;
    public float distanceBetweenObjects = 2f;

    void IterateThroughChildren()
    {
        childCount = myParentObject.transform.childCount;

        for(int i = 0; i < childCount; i++)
        {
            Transform specificChild = myParentObject.transform.GetChild(i);

            Debug.Log(specificChild.name);

            specificChild.name = "Child number " + (i + 1).ToString();

            specificChild.position = Vector3.left * i * distanceBetweenObjects + Vector3.left * initialOffset;

            specificChild.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

            Rigidbody specificRigidbody = specificChild.AddComponent<Rigidbody>();

            specificRigidbody.useGravity = false;


            if (i % 2 == 0)
            {
                //even
                specificChild.position += Vector3.up;

                specificRigidbody.linearVelocity = 0.1f * Vector3.down;

            }
            else
            {
                //odd
                specificChild.position += Vector3.down;

                specificRigidbody.linearVelocity =  0.1f * Vector3.up;


            }





        }


    }
    

}
