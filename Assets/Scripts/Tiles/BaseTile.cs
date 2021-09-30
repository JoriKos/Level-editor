using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTile : MonoBehaviour
{
    public GameObject[] TileTypes;

    private void Awake()
    {
        for (int i = 0; i < TileTypes.Length; i++)
        {
            TileTypes[i] = GameObject.Find("Tile" + i.ToString());
        }
    }

    public GameObject GetTile(int tileNumber)
    {
        return TileTypes[tileNumber];
    }
}
