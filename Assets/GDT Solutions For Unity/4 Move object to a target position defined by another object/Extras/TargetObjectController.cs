using UnityEngine;

namespace GDTSolutions
{
    namespace MoveObjectToTargetPosition
    {
        public class TargetObjectController : MonoBehaviour
        {

            public float speed = 2f;

            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
                transform.position += Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;

            }
        }

    }
}

