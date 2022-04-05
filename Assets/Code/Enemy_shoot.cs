using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shoot : MonoBehaviour
{
    [SerializeField] private float cooldown = 3;
    private float cooldownTimer;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer > 0) return;

        cooldownTimer = cooldown;
        GameObject gb = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
        Rigidbody rb = gb.GetComponent<Rigidbody>();
        rb.AddForce(transform.right * 120f);
        Destroy(gb, 0.2f);
    }
}
