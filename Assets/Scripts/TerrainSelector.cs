﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TerrainSelector : MonoBehaviour
{
    //0 = ground, 1 = platform, 2 = breakable platform
    [SerializeField] private Button[] buttonArray;
    [SerializeField] private int selectedTerrain;


}