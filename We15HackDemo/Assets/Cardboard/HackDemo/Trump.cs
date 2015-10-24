using UnityEngine;
using System.Collections;

public class Trump : MonoBehaviour {

    public GameObject Explosion;

    // Use this for initialization
    void Start()
    {
        SetGazedAt(false);
        Debug.Log("TrumpStartGazeFalse");
    }

    public void ToggleVRMode()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (gazedAt == true)
        {
            Debug.Log(gameObject.name);
            Destroy(gameObject);
            Debug.Log("Destroy" + gameObject.name);
            Instantiate(Explosion, transform.position, transform.rotation);
        }
    }
}
