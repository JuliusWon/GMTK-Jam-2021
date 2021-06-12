using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "character")
        {
            SceneManager.LoadScene(0);
        }
    }
}
