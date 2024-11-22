using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDTSolutions
{
    namespace ObjectDetection
    {

        public class GDT_DetectObjectInsideCollider : MonoBehaviour
        {
            Material myMaterial;
            Color emissionColor;
            // Start is called before the first frame update
            void Start()
            {
                myMaterial = GetComponent<MeshRenderer>().material;
                emissionColor = myMaterial.GetColor("_EmissionColor");
                myMaterial.SetColor("_EmissionColor", Color.black);

            }

            private void OnTriggerEnter(Collider other)
            {
                //Other collider enter for the first time
                myMaterial.SetColor("_EmissionColor", emissionColor);
                Debug.Log("I'm " + gameObject.name + ". " + other.gameObject.name + " has enter");
            }
            private void OnTriggerStay(Collider other)
            {
                //Other collider is inside right now        
                Debug.Log("I'm " + gameObject.name + ". " + other.gameObject.name + " is inside");
            }

            private void OnTriggerExit(Collider other)
            {
                //Other collider exits
                myMaterial.SetColor("_EmissionColor", Color.black);

                Debug.Log("I'm " + gameObject.name + ". " + other.gameObject.name + " exits");

            }
        }

    }

}

