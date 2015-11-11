﻿using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
    public class GamePausedManager : MonoBehaviour
    {
        Text text;                      // Reference to the Text component.

        void Awake()
        {
            // Set up the reference.
            text = GetComponent<Text>();
        }


        void Update()
        {
            // If Paused show the Pause Text!
            if (Time.timeScale == 0) text.color = new Color(255, 255, 255, 255);
            else text.color = new Color(255, 255, 255, 0);
        }
    }
}