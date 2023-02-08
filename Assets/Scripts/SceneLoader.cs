using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CharlieHarrop.SimpleLevelLoader
{
    public class SceneLoader : MonoBehaviour
    {
        // Need a feature that loads x scene when trigger is collided with
        [SerializeField] private int sceneToLoad;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                // LOAD THE SPECIFIED SCENE
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}

