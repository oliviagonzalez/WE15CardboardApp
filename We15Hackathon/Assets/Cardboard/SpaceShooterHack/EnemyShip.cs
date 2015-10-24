using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class EnemyShip : MonoBehaviour {

    public bool UpdatePosition;

    public float UpdatePositionDelay;
    public float FirstZPosition;
    public float MovementSpeed;

    public GameObject BasicEnemyShip;

    // Use this for initialization
	void Start () {

        var BasicEnemyShip = GameObject.FindWithTag("IncomingShip");
        UpdatePosition = true;
        UpdatePositionDelay = 1;
        FirstZPosition = 6;
        MovementSpeed = 1;
	}
	
    // Update is called once per frame
    void Update()
    {

        if (UpdatePosition == true && UpdatePositionDelay == 0)
        {
            BasicEnemyShip.transform.Translate(MovementSpeed, 20, 0, 0);
        }

        if (UpdatePositionDelay > 0)
        {
            UpdatePositionDelay -= Time.deltaTime;
        }

        if (UpdatePositionDelay < 0)
        {
            UpdatePositionDelay = 0;
        }
    }

    public void ToggleVRMode()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
    }

    public void SetGazedAt(bool gazedAt)
    {
        Update();
    }

    public void SetDestroy(bool click)
    {
        if(click == true)
        {
            Destroy(BasicEnemyShip);
        }
        else
        {
            Update();
        }
    }
}
