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
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Turn on playing mode
            if (editingModeObject && !playingModeObject)
            {
                editingModeObject.SetActive(false);
                playingModeObject.SetActive(true);
            }
            //Turn on editing mode
            if(!editingModeObject && playingModeObject)
            {
                editingModeObject.SetActive(true);
                playingModeObject.SetActive(false);
            }
        }
    }
}
