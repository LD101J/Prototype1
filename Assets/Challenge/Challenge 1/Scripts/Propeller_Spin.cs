using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller_Spin : MonoBehaviour
{
    [SerializeField] private float spinSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
