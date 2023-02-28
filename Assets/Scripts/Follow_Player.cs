using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Self_Learn_Prototype1
{
    
    public class Follow_Player : MonoBehaviour
    {
        [SerializeField] private GameObject vehicle;

        private void Update()
        {
            //vehicle.transform.position = transform.position;
             transform.position = vehicle.transform.position + new Vector3( 0, 5, -7);
        }
    }

}
