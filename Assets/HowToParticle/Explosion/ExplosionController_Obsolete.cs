using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController_Obsolete : MonoBehaviour {
    [Tooltip("Object to destroy at explosion")]
    public GameObject ObjectToDestroyAtExplosion;

    [Tooltip("Explosion")]
    public GameObject ExplosionObject;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
    }

    public void Explode()
    {
        if (ExplosionObject != null)
        {
            //var exp = ExplosionObject.GetComponent<ParticleSystem>();
            //exp.Play();
            //Destroy(ExplosionObject, exp.main.duration);

            ExplosionObject.SetActive(true);
            if (ObjectToDestroyAtExplosion != null) { Destroy(ObjectToDestroyAtExplosion); }
        }
    }
}
