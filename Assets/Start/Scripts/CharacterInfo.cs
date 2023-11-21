using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    public OverlayTile standingOnTile;

    private void Update()
    {
        GetComponent<SpriteRenderer>().sortingOrder = 1;
    }
}
