﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainObject : TerrainType
{
    
    [SerializeField] private Sprite terrainSprite;
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        terrainSprite = spriteRenderer.sprite;
    }
}
