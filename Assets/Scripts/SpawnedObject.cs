using UnityEngine;
using UnityEngine.UI;

public class SpawnedObject : MonoBehaviour
{
    [SerializeField] private Event spawned;
    [SerializeField] private Event pickedUp;
    [SerializeField] public Image icon;
    // Start is called before the first frame update
    void Start()
    {
        spawned.Occured(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pickedUp.Occured(gameObject);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 1);
        }
    }
}
