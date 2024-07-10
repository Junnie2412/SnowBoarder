using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float delayTime = 2f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            var controller = player.GetComponent<PlayerController>();

            var oldScore = PlayerPrefs.GetFloat("highest");
            var newScore = controller.RotationTime;

            if (newScore > oldScore)
            {
                PlayerPrefs.SetFloat("highest", newScore);
            }

            Debug.Log("You Finished!");
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delayTime); // Invoke has to use a method that you are delaying
        }
    }

    void ReloadScene() //Created reload scene method in order to use invoke
    {
        SceneManager.LoadScene(3);
    }
}
