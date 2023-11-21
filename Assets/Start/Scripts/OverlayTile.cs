using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayTile : MonoBehaviour
{
    // G = distance from start node
    public int G;
    // H = distance from end node
    public int H;
    // F = G + H (total cost)
    public int F { get { return G + H; } }

    public bool isBlocked = false;

    // The previous tile in the path
    public OverlayTile Previous;

    // The grid location of the tile
    public Vector3Int gridLocation;
    public Vector2Int grid2DLocation { get { return new Vector2Int(gridLocation.x, gridLocation.y); } }

    private void Update()
    {
        // Hide tile when clicked
        if (Input.GetMouseButtonDown(0))
        {
            HideTile();
        }
    }

    public void HideTile()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

    public void ShowTile()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
    }
}
