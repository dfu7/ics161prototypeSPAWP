using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumberUI : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private TextMeshProUGUI _text;
    private void Awake()
    {
        _text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.SetText(_slider.value.ToString());
    }
}
