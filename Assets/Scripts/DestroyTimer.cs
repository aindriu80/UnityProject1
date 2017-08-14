﻿using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float timer;
    public GameObject particle;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (particle)
                Instantiate(particle, transform.position, transform.rotation);
            Destroy(gameObject);

        }

    }
}
