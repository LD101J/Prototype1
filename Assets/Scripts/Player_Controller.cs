using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Self_Learn_Prototype1
{
    public class Player_Controller : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        private void Update()
        {
            //move the player foward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}

