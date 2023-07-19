using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    [SerializeField] private GameObject Car;
    [SerializeField] private Vector3 offset;
    


    void Update() 
    {
        transform.position = Car.transform.position + offset;
    }
}
