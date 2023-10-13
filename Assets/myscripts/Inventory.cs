using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    private TextMeshProUGUI shroomText;

    void Start()
    {
        shroomText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateShroomText(PlayerInventory playerInventory)
    {
        shroomText.text = playerInventory.NumberOfShrooms.ToString();

    }

}