﻿using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Singleton
    public static InputManager instance;

    // Action
    public static event Action OnPause = delegate { };

    // Inputs Code
    [SerializeField] private KeyCode pauseCode = KeyCode.Escape;

    // Initialize Singleton
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(pauseCode))
            OnPause();
    }
}