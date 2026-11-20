using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Congratulations : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject winParticles;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>())
        {
            Instantiate(winParticles, transform.position, Quaternion.identity);

            StartCoroutine(WinRoutine());
            
            winScreen.SetActive(true);
        }
    }

    private IEnumerator WinRoutine()
    {
        yield return new WaitForSeconds(2f);
    }
}