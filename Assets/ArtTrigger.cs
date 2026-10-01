using UnityEngine;

public class ArtTrigger : MonoBehaviour
{
    public GameObject information;
    
    private void Awake()
    {
        information.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
        information.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        information.SetActive(false);
    }
}