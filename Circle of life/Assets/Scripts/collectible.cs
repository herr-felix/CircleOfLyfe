using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour
{
    public CollectibleType Type;
    
	void Update ()
    {
        transform.Rotate(Vector3.up, 10f * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != "Player") return;
        var apprentice = col.gameObject.GetComponent<ShamanApprentice>();
        apprentice.CollectItem(Type, this);
        Destroy(gameObject);
    }
}