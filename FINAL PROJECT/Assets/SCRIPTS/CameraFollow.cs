using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float y0ffset = 1f;
    public float FollowSpeed = 2f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y +y0ffset,-10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed *Time.deltaTime);
    }
}
