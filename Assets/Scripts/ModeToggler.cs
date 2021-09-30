using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeToggler : MonoBehaviour
{
    [SerializeField] private bool isEditing;
    [SerializeField] private GameObject editingModeObject;
    [SerializeField] private GameObject playingModeObject;

    private void Awake()
    {
        isEditing = true;
        editingModeObject.SetActive(true);
        playingModeObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            //Turn on playing mode
            if (isEditing)
            {
                editingModeObject.SetActive(false);
                playingModeObject.SetActive(true);
                isEditing = false;
            }
            //Turn on editing mode
            else if (!isEditing)
            {
                editingModeObject.SetActive(true);
                playingModeObject.SetActive(false);
                isEditing = true;
            }
        }
    }

    public bool GetEditingCheck()
    {
        return isEditing;
    }
}
