using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnpool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    private GameObject[] columns
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
