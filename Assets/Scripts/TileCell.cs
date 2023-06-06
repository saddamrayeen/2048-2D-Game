using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script will assign to the cells where moveble tiles will be placed
public class TileCell : MonoBehaviour
{
    public Vector2Int coordinates { get; set; }
    public Tile tile { get; set; }

    // if tile is null then this is empty
    public bool isEmpty => tile == null;
    
    //if tile is not null then this is not empty
    public bool isOccupied => tile != null;
}
