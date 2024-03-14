using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntsColony : MonoBehaviour
{
    [SerializeField] private ResourceCounter _counter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent<Resource>(out Resource resource))
        {
            _counter.AddResource();
            Destroy(resource.gameObject);
        }
    }
}
