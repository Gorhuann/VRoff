using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    // Add as many puzzles as needed
    private bool puzzle1Solved = false;
    private bool puzzle2Solved = false;

    // Called when a puzzle is solved
    public void PuzzleSolved()
    {
        // Update the state of the puzzle
        puzzle1Solved = true; // Adapted to your specific logic

        // Add necessary code for puzzle resolution here

        // Check if all puzzles are solved
        if (puzzle1Solved && puzzle2Solved /* Add other puzzles here if needed */)
        {
            // All puzzles are solved, unlock the final door or perform other actions
            Debug.Log("All puzzles solved!");
        }
    }

    // Check if the dropped object is correct
    public void CheckObject(string objectTag)
    {
        // Implement logic to check if the object is correct
        // For example, compare it to the current puzzles and call PuzzleSolved() if it is
        if (objectTag == "Key")
        {
            PuzzleSolved();
        }
    }
}
