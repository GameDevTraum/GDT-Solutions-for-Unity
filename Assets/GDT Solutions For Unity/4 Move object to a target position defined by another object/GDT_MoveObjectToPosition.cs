using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GDTSolutions
{
    namespace MoveObjectToTargetPosition
    {
        public class GDT_MoveObjectToPosition : MonoBehaviour
        {
            public enum UpdateLoopToUse
            {
                Update,
                FixedUpdate,
                LateUpdate,
            }

            public UpdateLoopToUse loopToUse;

            public GameObject sphereObject;
            public GameObject targetPosition;

            [Range(0f, 5f)]
            public float speed = 1f;

            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    int currentLoop = (int)loopToUse;
                    currentLoop++;
                    if (currentLoop == 3){
                        currentLoop = 0;
                    }
                    loopToUse = (UpdateLoopToUse)currentLoop;
                }

                if(loopToUse == UpdateLoopToUse.Update)
                {
                    sphereObject.transform.position = Vector3.MoveTowards(sphereObject.transform.position, targetPosition.transform.position, speed * Time.deltaTime);
                }
            }

            void FixedUpdate()
            {
                if (loopToUse == UpdateLoopToUse.FixedUpdate)
                {
                    sphereObject.transform.position = Vector3.MoveTowards(sphereObject.transform.position, targetPosition.transform.position, speed * Time.deltaTime);
                }

            }

            void LateUpdate()
            {
                if (loopToUse == UpdateLoopToUse.LateUpdate)
                {
                    sphereObject.transform.position = Vector3.MoveTowards(sphereObject.transform.position, targetPosition.transform.position, speed * Time.deltaTime);
                }
            }

        }


    }

}

