using UnityEngine;
using System.Collections;

public class PlayerShootingController : MonoBehaviour {

    public Rigidbody m_Bullet;                   // Prefab of the shell
    public Transform m_FireTransform;           // A child of the tank where the shells are spawned.
    public float shootSpeed;


    private string m_FireButton;                // The input axis that is used for launching shells.


    // Use this for initialization
    void Start () {

        m_FireButton = "Fire1";
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonUp(m_FireButton)) {
            Fire();
        }
	}

    private void Fire()
    {


        // Get mouse Position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Get player Location
        Vector3 curLocation= transform.position;

        // Get direction of mouse in relation to object
        Vector3 dir = new Vector3(mousePosition.x - curLocation.x, 0, mousePosition.z - curLocation.z).normalized;

        //

        // Create an instance of the bullet and store a reference to it's rigidbody.
        Rigidbody BulletInstance =
            Instantiate(m_Bullet, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

        BulletInstance.transform.Translate(dir);
        // Set the shell's velocity to the launch force in the fire position's forward direction.
        BulletInstance.AddForce(shootSpeed* dir);

    }


}
