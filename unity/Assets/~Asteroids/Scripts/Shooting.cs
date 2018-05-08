using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public float bulletSpeed = 20f;
        public float shootRate = 0.2f;

        private float shootTimer = 0f;



        // Use this for initialization
        void Start()
        {

        }
        void Shoot()
        {
            GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
            rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
        }

        // Update is called once per frame
        void Update()
        {


        }
    }
}