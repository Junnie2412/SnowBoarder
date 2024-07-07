using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        // Start the coroutine to switch the scene after 10 seconds
        StartCoroutine(SwitchSceneAfterDelay(17f));
    }

    private IEnumerator SwitchSceneAfterDelay(float delay)
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delay);

        // Load the specified scene
        SceneManager.LoadScene(2);
    }
}