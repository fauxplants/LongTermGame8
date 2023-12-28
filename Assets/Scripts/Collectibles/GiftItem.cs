using System.Collections;
using System.Collections.Generic;
using Collectibles;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gift Item", menuName = "Inventory Gift Item", order = 1)]
public class GiftItem : InventoryCollectibleItem
{
    public float giftValue; // Idea for a gift var, though this can change
    
    public override InventoryCollectibleItem GetItem() { return this; }
    public override GiftItem GetGift() { return this; }
    public override CubeItem GetCube() { return null; }
    public override SphereItem GetSphere() { return null; }
    public override TableItem GetTable() { return null; }
    
}
