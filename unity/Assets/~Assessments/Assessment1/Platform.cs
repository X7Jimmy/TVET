using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("FallDown", 0.6f);
        }
    }

    private void FallDown()
    {
        this.GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(this.transform.parent.gameObject, 2f);

    }
}
