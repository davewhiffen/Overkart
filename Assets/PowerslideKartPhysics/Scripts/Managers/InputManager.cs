// Copyright (c) 2019 Justin Couch / JustInvoke
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PowerslideKartPhysics
{
    [DisallowMultipleComponent]
    //This class manages static input values fetched from Unity's input manager
    public class InputManager : MonoBehaviour
    {
        public string accelAxisName = "Accel";
        public static float accelInput = 0.0f;
        public string brakeAxisName = "Brake";
        public static float brakeInput = 0.0f;
        public string steerAxisName = "Horizontal";
        public static float steerInput = 0.0f;
        public string driftButtonName = "Drift";
        public static bool driftButton = false;
        public string boostButtonName = "Boost";
        public static bool boostButton = false;
        public static bool boostButtonDown;
        public string itemButtonName = "Item";
        public static bool itemButtonDown = false;
        public string cameraXAxisName = "Camera X";
        public string cameraYAxisName = "Camera Y";
        public static Vector2 camRotInput = Vector2.zero;
        public string lookBackButtonName = "Look Back";
        public static bool lookBackButton = false;
        public string restartButtonName = "Restart";

        void Update()
        {
            //Try/catch is used for fetching input in case the axes named do not exist
#if UNITY_EDITOR
            try
            {
#endif
                accelInput = Input.GetAxis(accelAxisName);
                brakeInput = Input.GetAxis(brakeAxisName);
                steerInput = Input.GetAxis(steerAxisName);
                driftButton = Input.GetButton(driftButtonName);
                boostButton = Input.GetButton(boostButtonName);
                boostButtonDown = Input.GetButtonDown(boostButtonName);
                itemButtonDown = Input.GetButtonDown(itemButtonName);
                camRotInput = new Vector2(Input.GetAxis(cameraXAxisName), Input.GetAxis(cameraYAxisName));
                lookBackButton = Input.GetButton(lookBackButtonName);

                if (!string.IsNullOrEmpty(restartButtonName))
                {
                    if (Input.GetButtonDown(restartButtonName))
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }
                }
#if UNITY_EDITOR
            }
            catch (System.Exception e)
            {
                Debug.LogWarning(e.Message);
            }
#endif
        }
    }
}
