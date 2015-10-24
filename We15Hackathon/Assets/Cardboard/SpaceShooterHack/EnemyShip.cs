using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class EnemyShip : MonoBehaviour {

    public bool UpdatePosition;

    public float UpdatePositionDelay;
    public float FirstZPosition;
    public float MovementSpeed;

    public GameObject Explosion;
    public GameObject BasicEnemyShip;

    // Use this for initialization
	void Start () {

        //var BasicEnemyShip = gameObject.GetComponent<gameObject>;
        //UpdatePosition = true;
        //UpdatePositionDelay = 1;
        //FirstZPosition = 6;
        //MovementSpeed = 1;
        SetGazedAt(false);
	}
	
    // Update is called once per frame
    void Update()
    {

        //if (UpdatePosition == true && UpdatePositionDelay == 0)
        //{
            Debug.Log(gameObject.name);
            //gameObject.transform.Translate(MovementSpeed, 0, 0, 0);
        //}

        //if (UpdatePositionDelay > 0)
        //{
        //    UpdatePositionDelay -= Time.deltaTime;
        //}

        //if (UpdatePositionDelay < 0)
        //{
        //    UpdatePositionDelay = 0;
        //}
    }

    public void ToggleVRMode()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
    }

    public void SetGazedAt(bool gazedAt)
    {
        if(gazedAt == true)
        {
            Debug.Log(gameObject.name);
            Destroy(gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);
        }

        if(gazedAt == false)
        {
            Update();
        }
    }

    //public void SetDestroy(bool click)
    //{
    //    if(click == true)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        Update();
    //    }
    //}
}
