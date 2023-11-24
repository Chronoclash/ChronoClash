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

    // The previous tile in the path
    public OverlayTile Previous;

    // The grid location of the tile
    public Vector3Int gridLocation;
    public Vector2Int grid2DLocation { get { return new Vector2Int(gridLocation.x, gridLocation.y); } }

    public List<Sprite> arrows;

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
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.6f);
    }

    public bool isWater()
    {
        if (transform.position.z == 1) { return true; }
        return false;
    }

    public void SetSprite(ArrowTranslator.ArrowDirection d)
    {
        SpriteRenderer[] sprite = GetComponentsInChildren<SpriteRenderer>();
        if (d == ArrowTranslator.ArrowDirection.None)
        {
            if (sprite.Length == 2)
            {
                sprite[1].color = new Color(1, 1, 1, 0);
            }
        }
        else
        {
            sprite[0].color = new Color(1, 1, 1, 1);
            sprite[0].sprite = arrows[(int)d];
            sprite[0].sortingOrder = gameObject.GetComponent<SpriteRenderer>().sortingOrder;
        }
    }
}
