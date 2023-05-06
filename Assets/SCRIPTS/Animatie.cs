using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatie : MonoBehaviour
{
    // Start is called before the first frame update
    Animator USA;
    void Start()
    {
        USA=this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

   private void OnTriggerEnter(Collider other) {

     if(other.gameObject.tag=="Player" && gameObject.tag!="Friendly")
     {
     USA.SetBool("isOpening",true);
     }
    
  
   }

}
