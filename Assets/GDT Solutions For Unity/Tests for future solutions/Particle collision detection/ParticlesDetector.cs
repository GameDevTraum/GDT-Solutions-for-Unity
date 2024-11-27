using UnityEngine;
using TMPro;

namespace GDTSolutions
{
    namespace TestForFutureSolutions
    {

        public class ParticlesDetector : MonoBehaviour
        {

            public TMP_Text text_CollisionCount;
            public int collisionCount;
            
            void Start()
            {

            }


            private void OnParticleCollision(GameObject other)
            {
                //This works
                Debug.Log("Particle collision detected");
                collisionCount++;
                text_CollisionCount.text = collisionCount.ToString();
            }


            private void OnCollisionEnter(Collision collision)
            {
                //This doesn't work
                Debug.Log("Collision detected");
            }

            private void OnTriggerEnter(Collider other)
            {
                //This doesn't work
                Debug.Log("Particle collision detected on trigger");
            }


        }

    }
}
