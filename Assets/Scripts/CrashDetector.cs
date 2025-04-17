using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
