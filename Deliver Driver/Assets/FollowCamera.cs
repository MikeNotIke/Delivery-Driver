using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject thingToFollow; //add in unity
    // makes object attached to (camera) follow the thing (car)
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10); //need to make a new Vector3 to move the camera so it's not just showing the background
    }
}
