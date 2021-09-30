using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TerrainSelector : MonoBehaviour
{   
    //1 = ground, 2 = platform, 3 = breakable platform
    [SerializeField] private Button[] buttonArray;
    [SerializeField] private Image selectedButtonImage;
    [SerializeField] private int selectedTerrain;
    
    private void Awake()
    {
        for (int i = 0; i < buttonArray.Length; i++)
        {
            buttonArray[i] = GameObject.Find("Ground" + i.ToString() + " Button").GetComponent<Button>();   
        }
    }
    public int GetSelectedTerrain()
    {
        return selectedTerrain;
    }

    //UI
    public void SetSelectedTerrain(int terrainNumber)
    {
        selectedTerrain = terrainNumber;
        selectedButtonImage.transform.position = buttonArray[terrainNumber - 1].transform.position;
    }
}
