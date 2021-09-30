using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : BaseTile
{
    [SerializeField] private TerrainSelector terrainSelector;
    [SerializeField] private Grid grid;
    [SerializeField] private BaseTile baseTile;

    private void OnMouseEnter()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(baseTile.GetTile(terrainSelector.GetSelectedTerrain()), this.transform.position, Quaternion.identity);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            Instantiate(baseTile.GetTile(0), this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
