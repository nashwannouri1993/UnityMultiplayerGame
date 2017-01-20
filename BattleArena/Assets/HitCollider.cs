using UnityEngine;
using System.Collections;

public class HitCollider : MonoBehaviour {

    public float m_rotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, m_rotationSpeed,0) * Time.deltaTime);
    }
}
