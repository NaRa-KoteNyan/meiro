using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = GetComponent<Transform>().position -target.position;  
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = target.position + offset;  
    }
}
