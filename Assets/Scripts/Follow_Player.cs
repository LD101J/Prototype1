using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Self_Learn_Prototype1
{
    
    public class Follow_Player : MonoBehaviour
    {
        #region Variables
        [SerializeField] private GameObject vehicle;
        [SerializeField] private Vector3 offset = new Vector3(0, 10, -2);
        [SerializeField] private float turnSpeed;
        #endregion
        private void LateUpdate()
        {
            //vehicle.transform.position = transform.position;
             transform.position = vehicle.transform.position + new Vector3( 0, 10, -2); //camera movement
             
        }
    }

}
