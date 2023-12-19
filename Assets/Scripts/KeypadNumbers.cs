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
            if(code == m_Text.text){
                AccessGranted.Invoke();
            }
        }

        public void Clear(){
            m_Count = "";
            m_Text.text = m_Count.ToString();
        }
    }