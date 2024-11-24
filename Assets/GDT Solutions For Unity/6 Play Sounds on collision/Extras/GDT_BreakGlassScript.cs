using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDTSolutions
{
    namespace PlaySoundOnCollision
    {

        public class GDT_BreakGlassScript : MonoBehaviour
        {

            public GameObject normalGlass;
            public GameObject destroyedGlassParent;
            public AudioSource audioSource;
            public AudioClip audioClip;

            private void OnTriggerEnter(Collider other)
            {
                destroyedGlassParent.SetActive(true);
                normalGlass.SetActive(false);
                audioSource.PlayOneShot(audioClip);
            }

        }
    }
}

