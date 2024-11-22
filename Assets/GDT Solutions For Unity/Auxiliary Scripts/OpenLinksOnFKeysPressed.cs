using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GDTSolutions
{
    namespace Auxiliary{
        public class OpenLinksOnFKeysPressed : MonoBehaviour
        {
            public GameObject linksContainer;

            public string videoURL;

            void Start()
            {
                linksContainer.SetActive(true);
            }
            void Update()
            {
                if (Input.GetKeyDown(KeyCode.F1))
                {
                    Application.OpenURL("https://www.youtube.com/@GameDevTraumEN/");
                }
                if (Input.GetKeyDown(KeyCode.F2))
                {
                    Application.OpenURL("https://github.com/GameDevTraum");
                }
                if (Input.GetKeyDown(KeyCode.F3))
                {
                    if (videoURL != "")
                    {
                        Application.OpenURL(videoURL);
                    }
                }

            }

        }

    }


}

