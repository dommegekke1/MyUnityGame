using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public int SizeX;
    public int SizeY;

    public GridTile Tile;

    public void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        for (int i = 0; i < SizeX; i++)
        {
            for (int j = 0; j < SizeY; j++)
            {
                GridTile clone = GridTile.Instantiate(Tile);
                clone.X = i;
                clone.Y = j;
                clone.name = "Tile (" + i.ToString() + ", " + j.ToString() + ")";
                clone.MoveTile();
            }
        }
    }
}
