using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script will assign to the cells where moveble tiles will be placed
public class TileCell : MonoBehaviour
{
    public Vector2Int coordinates { get; set; }
    public Tile tile { get; set; }

    bool isEmpty => tile == null;
    bool isOccupied => tile != null;
}
