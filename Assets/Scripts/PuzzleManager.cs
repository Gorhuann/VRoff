using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    private bool trophy1Solved = false;
    private bool trophy2Solved = false;
    private bool trophy3Solved = false;

    public ExitDoorOpener exitDoorOpener; // Référence au script ExitDoorOpener

    void Start()
    {
        // Initialiser la référence à ExitDoorOpener
        exitDoorOpener = GetComponent<ExitDoorOpener>();

        // Vérifier si la référence est null et logguer une erreur si nécessaire
        if (exitDoorOpener == null)
        {
            Debug.LogError("ExitDoorOpener reference is null in PuzzleManager!");
        }
    }

    public void PuzzleSolved(string trophyTag)
    {
        switch (trophyTag)
        {
            case "Trophy1":
                trophy1Solved = true;
                break;
            case "Trophy2":
                trophy2Solved = true;
                break;
            case "Trophy3":
                trophy3Solved = true;
                break;
            default:
                Debug.LogWarning("Unknown trophy tag: " + trophyTag);
                return;
        }

        Debug.Log("Puzzle solved: " + trophyTag);

        // Vérifier si tous les trophées sont résolus
        if (trophy1Solved && trophy2Solved && trophy3Solved)
        {
            Debug.Log("All puzzles solved!");
            OpenExitDoors();
        }
    }

    public void CheckObject(string objectTag)
    {
        // Implémentez la logique pour vérifier l'objet ici
        Debug.Log("Checking object: " + objectTag);
    }

    private void OpenExitDoors()
    {
        // Ouvrir les portes de sortie lorsque tous les trophées sont résolus
        if (exitDoorOpener != null)
        {
            exitDoorOpener.ToggleExitDoorOpen();
        }
    }
}
