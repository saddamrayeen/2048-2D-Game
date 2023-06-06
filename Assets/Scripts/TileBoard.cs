using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBoard : MonoBehaviour
{
    public Tile tilePrefab;
    public TileState[] tileState;
    private TileGrid grid;
    private List<Tile> tiles;

    private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
        tiles = new List<Tile>(16);
    }

    private void Start()
    {
        CreateTile();
        CreateTile();
    }
    //creating tiles
    private void CreateTile()
    {

        Tile tile = Instantiate(tilePrefab, grid.transform);

        // setting initial tile state 
        tile.SetState(tileState[0], 2);
        // setting the tile position to a random position
        tile.Spawn(grid.GetRandomEmptyCell());
        // adding spawned tile to the list of the tiles
        tiles.Add(tile);

    }


}
