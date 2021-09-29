using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTest : MonoBehaviour
{
    private Grid grid;

    private void Awake()
    {
        grid = new Grid(20, 10, 10f);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
        }
    }
}
