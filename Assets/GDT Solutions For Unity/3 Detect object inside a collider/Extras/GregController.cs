using UnityEngine;

namespace GDTSolutions
{
    namespace ObjectDetection
    {
        public class GregController : MonoBehaviour
        {

            public float speed = 3f;

            // Update is called once per frame
            void Update()
            {
                transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            }
        }

    }
}
