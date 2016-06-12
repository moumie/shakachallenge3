﻿using UnityEngine;
using System.Collections;

public class fireBullet : MonoBehaviour {

    public float timeBetweenBullets = 0.15f;
    public GameObject projectile;
    float nextBullet;

	// Use this for initialization
	void Awake () {
        nextBullet = 0f;
	}

    // Update is called once per frame
    void Update() {
        playerController myPlayer = transform.root.GetComponent<playerController>();

        if (Input.GetAxisRaw("Fire1") > 0 && nextBullet < Time.time){
            nextBullet = Time.time + timeBetweenBullets;
            Vector3 rot;
            if (myPlayer.GetFacing() == -1f)
            {
                rot = new Vector3(0, -90, 0);
            }
            else rot = new Vector3(0, 90, 0);

            Instantiate(projectile, transform.position, Quaternion.Euler(rot));
        }
    }
}
