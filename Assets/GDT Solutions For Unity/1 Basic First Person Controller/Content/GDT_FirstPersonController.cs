using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDTSolutions
{
    namespace FirstPersonController
    {
        [RequireComponent(typeof(CharacterController))]
        public class FirstPersonController : MonoBehaviour
        {

            [Header("Movement")]
            public bool canMove = true;
            [Range(0f, 10f)]
            public float walkingSpeed = 7.5f;
            [Range(0f, 10f)]
            public float runningSpeed = 11.5f;
            float playerCurrentSpeed;

            [Header("Look")]
            public bool canLook = true;
            [Range(0f, 10f)]
            public float lookSensitivity = 2f;
            float lookVerticalMaxAngle = 90f;
            float rotationX = 0;

            [Header("Jump")]
            public bool canJump = true;
            [Range(0f, 15f)]
            public float jumpForce = 6f;
            public float gravityMultiplier = 1f;
            bool isGrounded;

            Transform cameraContainer;
            CharacterController characterController;

            Vector3 moveDirection = Vector3.zero;
            Vector3 movementVector;
            Vector2 inputVectorMovement;
            Vector2 inputVectorLook;
            Vector3 forwardDirection;
            Vector3 rightDirection;

            void Start()
            {
                cameraContainer = transform.GetChild(0);
                characterController = GetComponent<CharacterController>();

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            void Update()
            {
                ReadInput();

                if (canMove)
                {
                    CharacterMovement();
                }
                if (canLook)
                {
                    CameraRotation();
                }
            }

            void ReadInput()
            {
                inputVectorMovement.x = Input.GetAxis("Horizontal");
                inputVectorMovement.y = Input.GetAxis("Vertical");
                inputVectorLook.x = Input.GetAxis("Mouse X");
                inputVectorLook.y = Input.GetAxis("Mouse Y");

                if (inputVectorMovement.magnitude > 1f)
                {
                    inputVectorMovement = inputVectorMovement.normalized;
                }
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    playerCurrentSpeed = runningSpeed;
                }
                else
                {
                    playerCurrentSpeed = walkingSpeed;
                }

                isGrounded = characterController.isGrounded;
            }

            void CharacterMovement()
            {
                forwardDirection = transform.forward;
                rightDirection = transform.right;

                float movementDirectionY = moveDirection.y;

                movementVector = inputVectorMovement * playerCurrentSpeed;

                moveDirection = (forwardDirection * movementVector.y) + (rightDirection * movementVector.x);

                moveDirection.y = movementDirectionY;

                if (isGrounded)
                {
                    if (Input.GetButton("Jump") && canJump && isGrounded)
                    {
                        moveDirection.y = jumpForce;
                    }
                }
                else
                {
                    moveDirection.y += gravityMultiplier * Physics.gravity.y * Time.deltaTime;
                }

                characterController.Move(moveDirection * Time.deltaTime);
            }


            void CameraRotation()
            {
                rotationX += -inputVectorLook.y * lookSensitivity;
                rotationX = Mathf.Clamp(rotationX, -lookVerticalMaxAngle, lookVerticalMaxAngle);
                cameraContainer.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                transform.rotation *= Quaternion.Euler(0, inputVectorLook.x * lookSensitivity, 0);
            }

            public void EnableMovement()
            {
                canMove = true;
            }

            public void DisableMovement()
            {
                canMove = false;
            }




        }



    }
}

