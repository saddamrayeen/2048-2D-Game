using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this script will be assign to the row component and it will track all cells that will contains a row
public class TileRow : MonoBehaviour
{
    public TileCell[] cells { get; private set; }

    private void Awake()
    {
        cells = GetComponentsInChildren<TileCell>();
    }
}
