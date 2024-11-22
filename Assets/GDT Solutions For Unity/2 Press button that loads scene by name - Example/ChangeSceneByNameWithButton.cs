using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GDTSolutions
{
    namespace LoadSceneByNameWhenPressingAButton
    {
        public class ChangeSceneByNameWithButton : MonoBehaviour
        {
            public void LoadScene(string sceneName)
            {
                SceneManager.LoadScene(sceneName);
            }

        }
    }
   
}

