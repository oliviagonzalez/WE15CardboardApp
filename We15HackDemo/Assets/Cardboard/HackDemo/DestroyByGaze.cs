using UnityEngine;
using System.Collections;

public class DestroyByGaze : MonoBehaviour {

    public GameObject Explosion;

    void OnTriggerEnter(Collider other)
    {
        string objectName = other.name;
        Debug.Log(objectName);
        SetGazedAt(true);
        Destroy(other.gameObject);
        Destroy(gameObject);
        Instantiate(Explosion, transform.position, transform.rotation);

    }

    public void SetGazedAt(bool gazedAt)
    {
        if (gazedAt == true)
        {
            Debug.Log(gameObject.name);
            Destroy(gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);
        }
        else
        {
            return;
        }
    }
}
