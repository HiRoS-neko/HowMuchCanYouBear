using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySight : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RaycastHit hit;
            //Debug.DrawRay(transform.position, (transform.position - other.gameObject.transform.position).normalized*-1,Color.blue);
            if (Physics.Raycast(transform.position, (transform.position - other.gameObject.transform.position).normalized*-1, out hit, 100.0f))
                if (hit.transform.gameObject.Equals(other.gameObject))
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}