using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDTSolutions
{
    namespace PlaySoundOnCollision
    {
        public class GDT_PlaySoundOnCollision : MonoBehaviour
        {
            public AudioSource myAudioSource;
            public AudioClip myAudioClip;

            private void OnCollisionEnter(Collision collision)
            {
                myAudioSource.PlayOneShot(myAudioClip);
            }
        }
    }
}
