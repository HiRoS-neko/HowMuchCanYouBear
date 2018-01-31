using UnityEngine;

public class EnemySight : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene());
    }
}