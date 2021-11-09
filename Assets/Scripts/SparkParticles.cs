using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkParticles : MonoBehaviour
{
    public ParticleSystem spark;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            spark.Play();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            spark.Emit(Random.Range(3, 10));
        }
    }
}
