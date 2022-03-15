using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amplifier : CollidableObject
{
    protected override void OnCollide(Collider2D coll)
    {
        Debug.Log("Grant Loot");
    }
}
