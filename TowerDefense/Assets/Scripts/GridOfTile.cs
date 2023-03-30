using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridOfTile : MonoBehaviour
{
    [SerializeField] private Tile TilePrefab;
    [SerializeField] private int width;
    [SerializeField] private int depth;

    // This is called a "Two Dimensional Array"
    private Tile[][] Tiles;

    private void Awake()
    {
        Tiles = CreateGrid(width, depth);
    }

    // Creates a Grid of Tiles
    private Tile[][] CreateGrid(int width, int depth)
    {
        if (width < 0 && depth < 0)
        {
            Debug.Log($"On {gameObject.name} doesn't work the values > 0 in fields width and depth");
            return null;
        }

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                //Debug.Log($"{x} {z}");
                Instantiate(TilePrefab, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
        
        return null;
    }
}