using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySight : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.position-other.gameObject.transform.position, out hit, 100.0f))
                if (hit.transform.gameObject.Equals(other.gameObject))
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}