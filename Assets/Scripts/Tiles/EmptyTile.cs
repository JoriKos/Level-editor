using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTile : BaseTile
{
    [SerializeField] private TerrainSelector terrainSelector;
    [SerializeField] private Grid grid;
    [SerializeField] private BaseTile baseTile;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(baseTile.GetTile(terrainSelector.GetSelectedTerrain()), this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
