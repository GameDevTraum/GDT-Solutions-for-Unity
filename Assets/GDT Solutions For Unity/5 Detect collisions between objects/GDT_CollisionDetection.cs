using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDTSolutions
{
    namespace DetectCollisionsBetweenObjects
    {

        public class GDT_CollisionDetection : MonoBehaviour
        {

            public GameObject objectToEnableOnCollision;

            // Start is called before the first frame update
            void Start()
            {
                objectToEnableOnCollision.SetActive(false);
            }

            // Update is called once per frame
            void Update()
            {
                if (gameObject.name == "Greg (Sphere)")
                {
                    transform.position += 2f * Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
                }
            }

            private void OnCollisionEnter(Collision collision)
            {
                //An other object starts to collide with us

                Debug.Log("I am "+gameObject.name+", "+collision.gameObject.name + " starts colliding with me");
                objectToEnableOnCollision.SetActive(true);

            }

            private void OnCollisionStay(Collision collision)
            {
                //The other object is still colliding with us
                Debug.Log("I am " + gameObject.name + ", " + collision.gameObject.name + " is colliding with me");

            }

            private void OnCollisionExit(Collision collision)
            {
                //The other object has stopped colliding with us
                Debug.Log("I am " + gameObject.name + ", " + collision.gameObject.name + " has stopped colliding with me");
                objectToEnableOnCollision.SetActive(false);

            }

        }

    }

}
