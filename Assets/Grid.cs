using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    [SerializeField] private Vector2Int _size;
    [SerializeField] private float _cellSize;
    private int[,] _gridArray;

    public Grid(Vector2Int size, float cellSize = 32.0f)
    {
        _size = size;
        _cellSize = cellSize;
        _gridArray = new int[_size.x, _size.y];
    }

    public Grid(int witdh, int height, float cellSize = 32.0f)
    {
        _cellSize = cellSize;
        _size = new Vector2Int(witdh, height);
    }
    private Vector3 GetWorldPosition(Vector2Int cellPos)
    {
        return new Vector3(cellPos.x, cellPos.y) * _cellSize;
    }

}
