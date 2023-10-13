using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfShrooms { get; private set; }

    public UnityEvent<PlayerInventory> OnShroomCollected;

    public void ShroomsCollected()
    {
        NumberOfShrooms++;
        OnShroomCollected.Invoke(this);
    }
}
