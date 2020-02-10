using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettigSpecificheat : MonoBehaviour
{
    GameObject System;
    SceneTemperature script;
    Material[] materials;

    private List<float> gray_index = new List<float>();
    private float temperature;
    private bool status;

    // Start is called before the first frame update
    void Start()
    {
        System = GameObject.Find("System");
        script = System.GetComponent<SceneTemperature>();
        this.materials = GetComponent<Renderer>().materials;

        temperature = script.Temperature;
        for (int i = 0; i < materials.Length; i++)
        {
            gray_index.Add(materials[i].color.grayscale);
        }
    }

    // Update is called once per frame
    void Update()
    {
        status = this.GetComponent<TestChangeMaterial2>().status_IR;

        if (status)
        {
            this.materials = GetComponent<Renderer>().materials;

            for (int i = 0; i < materials.Length; i++)
            {
                gray_index[i] = this.GetComponent<TestChangeMaterial2>().initial_IRgray[i] + ((script.Temperature - temperature) / 100.0f);
                if (gray_index[i] > 1.0f)
                    gray_index[i] = 1.0f;
                else if (gray_index[i] < 0.0f)
                    gray_index[i] = 0.0f;

                this.materials[i].SetColor("_Color", new Color(gray_index[i], gray_index[i], gray_index[i], 1.0f));
            }
        }
    }
}
