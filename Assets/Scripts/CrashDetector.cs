using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.7f;
    [SerializeField] ParticleSystem crashEffect;
void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Ground"){
    crashEffect.Play();
    GetComponent<AudioSource>().Play();
    Invoke("ReloadScene", loadDelay);
}
}
void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
