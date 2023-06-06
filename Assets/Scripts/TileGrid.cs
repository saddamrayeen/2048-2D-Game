using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this script will be attached to tilegrid component and it will track all rows and cells under it
public class TileGrid : MonoBehaviour
{
    public TileRow[] rows { get; private set; }
    public TileCell[] cells { get; private set; }

    public int size => cells.Length;
    public int height => rows.Length;
    public int width => size / height;
    private void Awake()
    {
        rows = GetComponentsInChildren<TileRow>();
        cells = GetComponentsInChildren<TileCell>();
    }

    private void Start()
    {
        // looping through all rows and cells and setting its coordinates
        for (int y = 0; y < rows.Length; y++)
        {
            for (int x = 0; x < rows[y].cells.Length; x++)
            {
                rows[y].cells[x].coordinates = new Vector2Int(x, y);
            }
        }
    }
    // this method will return a random empty cell
    public TileCell GetRandomEmptyCell()
    {
        // a random index
        int index = Random.Range(0, cells.Length);

        // first random index will be the starting index
        int startingIndex = index;

        // if the cell that exist on that index is occupied
        while (cells[index].isOccupied)
        {
            // then check one index forward
            index++;
            // and if index is going bigger then the total cell length
            if (index >= cells.Length)
            {
                // then set index to zero
                index = 0;
            }
            // if after setting zero any of the cell is not empty till the starting index 
            if (index == startingIndex)
            {
                // return null
                return null;
            }
        }

        // if the cell is empty return its index
        return cells[index];
    }
}
