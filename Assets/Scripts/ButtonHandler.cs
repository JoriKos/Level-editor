using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private int terrainNumber;
    [SerializeField] private TerrainSelector terrainSelector;
    [SerializeField] private Button button;
    
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        terrainSelector.SetSelectedTerrain(terrainNumber);
    }
}
