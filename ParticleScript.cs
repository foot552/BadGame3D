using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript: MonoBehaviour
{
	public ParticleSystem part;
    // Start is called before the first frame update
    void Start()
    {
         part = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnCollisionEnter(Collision col)
    {
    	if (col.gameObject.name == "Player")
    	{
    		part.Play();
            Invoke("Destroy", 1f);
    	}
    }
    void Destroy()
    {
        Destroy(gameObject);
    }

 
}
