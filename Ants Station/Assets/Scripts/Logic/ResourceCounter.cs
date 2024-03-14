using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEditor;

public class ResourceCounter : MonoBehaviour
{
    [SerializeField] private Viewer _uiViewer;
    [Space, SerializeField] private int _stone = 0;

    public void AddResource()
    {
        _stone += 1;
        _uiViewer.SetText(_stone.ToString());
    }
}
