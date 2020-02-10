using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeAllMaterials : MonoBehaviour
{
    public Material[] _materials;
    private int material_index = 0;

    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material_index = Mathf.FloorToInt(Random.Range(0.0f, _materials.Length));
        //this.GetComponent<Renderer>().material = _materials[material_index];

        material = (Material)Resources.Load("Materials/IR_Materials/Road_IR");
        this.GetComponent<Renderer>().material = material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
