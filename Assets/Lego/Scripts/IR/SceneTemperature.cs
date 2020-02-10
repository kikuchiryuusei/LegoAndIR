using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTemperature : MonoBehaviour
{
    [Range(0, 100)] public float Temperature = 20.0f;
    private float _slider;
    private Text temperature_UI;

    // Start is called before the first frame update
    void Start()
    {
        //_slider = Temperature;

       temperature_UI = GameObject.Find("Text").GetComponent<Text>();
       temperature_UI.text = Temperature + " ℃";
    }

    // Update is called once per frame
    void Update()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>().value;

        Temperature = Mathf.Floor(_slider);
        temperature_UI.text = Mathf.Floor(_slider) + " ℃";
    }
}