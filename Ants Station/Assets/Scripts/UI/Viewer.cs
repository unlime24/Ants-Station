using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Viewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _stoneView;

    public void SetText(string text)
    {
        _stoneView.text = text;
    }
}
