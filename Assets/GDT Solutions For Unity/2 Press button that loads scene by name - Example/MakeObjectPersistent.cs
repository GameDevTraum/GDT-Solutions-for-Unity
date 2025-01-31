using UnityEngine;

namespace GDTSolutions
{
    namespace MakeObjectPersistentBetweenScenes
    {

        public class MakeObjectPersistent : MonoBehaviour
        {
            public static MakeObjectPersistent uniqueInstance;

            void Awake()
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = this;
                    DontDestroyOnLoad(gameObject);
                }
                else
                {
                    Destroy(gameObject);
                }


            }
        }

    }
}