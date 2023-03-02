using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Self_Learn_Prototype1
{
    public class Player_Controller : MonoBehaviour
    {
        #region Variables
        [SerializeField] private float moveSpeed;
        [SerializeField] private float turnSpeed;
        //vehicle movement
        [SerializeField] private float horizontalInput;
        [SerializeField] private float verticalInput;
        #endregion
        private void Update()
        {
            #region PlayerMovement
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            //move the player foward
            transform.Translate(Vector3.forward * moveSpeed * verticalInput * Time.deltaTime);
            transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
            //transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);
            #endregion
        }
    }
}

