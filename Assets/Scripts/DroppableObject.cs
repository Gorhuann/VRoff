using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DroppableObject : MonoBehaviour
{
    public string objectTag;
    public PuzzleManager puzzleManager;

    private bool isGrabbed = false;

    private void Update()
    {
        if (isGrabbed && !CheckGrabInput())
        {
            Debug.Log("Object released");
            if (puzzleManager != null)
            {
                puzzleManager.CheckObject(objectTag);
            }

            isGrabbed = false;
        }
    }

    private bool CheckGrabInput()
    {
        // Logique pour vérifier si l'objet est encore saisi (à compléter selon vos besoins)
        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CheckGrabInput())
        {
            isGrabbed = true;
            Debug.Log("Object grabbed");
        }
    }
}
