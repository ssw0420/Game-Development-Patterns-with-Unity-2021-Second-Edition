using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SSW {
    public class GameManager : Singleton<GameManager> {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;

        void Start() {
            _sessionStartTime = DateTime.Now;
            Debug.Log("Session start time: " + _sessionStartTime);
        }

        void OnApplicationQuit() {
            _sessionEndTime = DateTime.Now;
            TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);

            Debug.Log("Game session ended: " + DateTime.Now);
            Debug.Log("Game session lasted: " + timeDifference);
        }

        private void OnGUI() {
            if (GUILayout.Button("Next Scene")) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}