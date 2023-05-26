using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float timeUntilDestroy = 2f;
    public int shellDamage = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timeUntilDestroy);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<TankController>().TakeDamage(shellDamage);
            Destroy(this.gameObject);
        }
    }

}
