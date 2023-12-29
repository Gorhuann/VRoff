using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.Events;

public class KeypadNumbers : MonoBehaviour
{
    [SerializeField]
    Text m_Text;

    public string code;
    public Text text
    {
        get => m_Text;
        set => m_Text = value;
    }

    string m_Count;
    public UnityEvent AccessGranted;

    public OpenDoorLock doorLock; // Reference to the OpenDoorLock script

    // Define color for correct and incorrect codes
    public Color correctColor = Color.green;
    public Color incorrectColor = Color.red;

    protected void Awake()
    {
        if (m_Text == null)
            Debug.LogWarning("Missing required Text component reference. Use the Inspector window to assign which Text component to increment.", this);
    }

    public void IncrementText(int button_value)
    {
        m_Count += button_value;
        if (m_Text != null)
            m_Text.text = m_Count.ToString();
    }

public void Check()
{
    Debug.Log("Checking code: " + m_Text.text);

    // Check if the entered code is correct
    bool isCodeCorrect = (m_Text.text == code);

    // Change text color based on correctness
    m_Text.color = isCodeCorrect ? correctColor : incorrectColor;

    // If the code is correct, perform further actions
    if (isCodeCorrect)
    {
        Debug.Log("Code is correct!");
        AccessGranted.Invoke();

        //Open the door when the code is right
        if (doorLock != null)
        {
            Debug.Log("Calling ToggleDoorOpen");
            doorLock.ToggleDoorOpen(m_Text.text, code); // Pass entered code and correct code
        }
    }
}

    public void Clear()
    {
        m_Count = "";
        m_Text.text = m_Count.ToString();
        // Reset text color when clearing the input
        m_Text.color = Color.white;
    }
}