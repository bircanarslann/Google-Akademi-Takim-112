using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public float MaxLimit;
    public float MinLimit;
    public GameObject Character;

    private void Update()
    {
        var pos = transform.position;
        pos.x = Character.transform.position.x;
        transform.position = pos;
        if (transform.position.x > MaxLimit)
        {
            pos.x = MaxLimit;
        }
        if (transform.position.x < MinLimit)
        {
            pos.x = MinLimit;
        }
        transform.position = pos;
    }
}
