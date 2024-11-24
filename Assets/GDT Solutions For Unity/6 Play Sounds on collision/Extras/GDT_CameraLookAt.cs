using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDTSolutions
{
    namespace PlaySoundOnCollision
    {
        public class GDT_CameraLookAt : MonoBehaviour
        {
            public Transform target;


            // Update is called once per frame
            void LateUpdate()
            {
                transform.LookAt(target);
            }
        }
    }
}

