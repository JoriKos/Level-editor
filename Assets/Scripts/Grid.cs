using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private EmptyTile tilePrefab;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private GameObject gridParent;


    private Dictionary<Vector3, EmptyTile> tiles;

    private void Awake()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        tiles = new Dictionary<Vector3, EmptyTile>();
        int x;
        int y;
        for (int i = 0; i < width; i++)
        {
            x = i;
            for (int j = 0; j < height; j++)
            {
                y = j;
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x, y, 1), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                spawnedTile.transform.parent = gridParent.transform;

                tiles[new Vector2(x, y)] = spawnedTile;
            }
        }
        cameraTransform.transform.position = new Vector3((float)width/ 2 -0.5f, (float)height / 2 -0.5f, 0);
    }

    public EmptyTile GetTileAtPosition(Vector3 pos)
    {
        if(tiles.TryGetValue(pos, out var tile))
        {
            return tile;
        }
        return null;
    }
}
