using UnityEngine;

public class EnemySight : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.position-other.gameobject.transfrom.position, out hit, 100.0f))
                if (out.gameobject == other.gameobject)
                    SceneManager.LoadScene(SceneManager.GetActiveScene());
        }
    }
}