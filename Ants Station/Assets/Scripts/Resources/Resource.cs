using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent<Ant>(out Ant ant))
        {
            transform.SetParent(ant.transform);
            transform.localPosition = ant.ResourcePoint.localPosition;
        }
    }
}
