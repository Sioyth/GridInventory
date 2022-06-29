using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [Header("Grid Settings")]
    [SerializeField] private static float _cellSize = 64.0f;
    [SerializeField] private Vector2Int _gridSize;
    [SerializeField] private Transform _inventoryGridUI; // Better name
    [SerializeField] private GameObject _inventoryTile;

    private Grid _inventory;

    public static float CellSize { get => _cellSize; set => _cellSize = value; }

    private void Start()
    {
        _inventory = new Grid(_gridSize, CellSize);
        _inventoryGridUI.GetComponent<GridLayoutGroup>().cellSize = new Vector2(CellSize, CellSize);
        Draw();
    }

    private void Draw()
    {
        for (int x = 0; x < _gridSize.x; x++)
            for (int y = 0; y < _gridSize.y; y++)
                Instantiate(_inventoryTile, _inventoryGridUI.transform);
    }
}
