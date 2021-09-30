using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePlatformTile : BaseTile
{
    [SerializeField] private TerrainSelector terrainSelector;
    [SerializeField] private Grid grid;
    [SerializeField] private BaseTile baseTile;
    [SerializeField] private bool startDestroy;
    [SerializeField] private bool isDestroyed;
    [SerializeField] private BoxCollider2D collider;
    private float timer;
    private float reset;

    private void Awake()
    {
        collider = this.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (startDestroy)
        {
            timer += Time.deltaTime;
        }

        if (isDestroyed)
        {
            reset += Time.deltaTime;
        }

        if (reset > 2.5f)
        {
            collider.enabled = true;
        }

        if (timer > 1.5f)
        {
            collider.enabled = false;
            timer = 0;
            startDestroy = false;
            isDestroyed = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            startDestroy = true;
        }
    }

    private void OnMouseEnter()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(baseTile.GetTile(terrainSelector.GetSelectedTerrain()), this.transform.position, Quaternion.identity);
        }
        if (Input.GetMouseButtonUp(1))
        {
            Instantiate(baseTile.GetTile(0), this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
