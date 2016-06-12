using UnityEngine;
using System.Collections;

public class healthPickupController : MonoBehaviour {

    public float healthAmount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<playerHealth>().addHealth(healthAmount);
            Destroy(transform.root.gameObject);
        }
    }
}
