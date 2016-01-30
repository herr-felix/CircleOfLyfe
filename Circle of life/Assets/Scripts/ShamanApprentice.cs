using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ShamanApprentice : MonoBehaviour
{
    private float _moveSpeed;
    //private Rigidbody _rb;
    private Rigidbody _rb;
    private Dictionary<CollectibleType, List<Collectible>> _ritualCollectibles;
    public ShamanSpiritualForm Form;

    //Collect items and store them foreach independant rituals
    public void CollectItem(CollectibleType ct, Collectible c)
    {
        if (_ritualCollectibles.ContainsKey(ct))
        {
            _ritualCollectibles[ct].Add(c);
        }
        else
        {
            _ritualCollectibles.Add(ct, new List<Collectible> { c });
        }
    }

    private void MoveSpiritualForm()
    {
        if (Form == ShamanSpiritualForm.Egg)
        {
            var horizontal = Input.GetAxis("Horizontal");
            //_rb.AddTorque(new Vector3(0, 0, horizontal*_moveSpeed), ForceMode.Force);
        }
        else if (Form == ShamanSpiritualForm.Horse)
        {
        }
        else if (Form == ShamanSpiritualForm.Eagle)
        {
            var moveDir = Vector3.zero;
            moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
            transform.position += moveDir * 55f * Time.deltaTime;
        }
        else if (Form == ShamanSpiritualForm.Shark)
        {
        }
        else if (Form == ShamanSpiritualForm.Phoenix)
        {
        }

    }

    public void MoveSpiritualForm(ShamanSpiritualForm sf)
    {
        if (sf == ShamanSpiritualForm.Egg)
        {
            var horizontal = Input.GetAxis("Horizontal");
            _rb.AddTorque(new Vector3(0, 0, horizontal*_moveSpeed), ForceMode.Force);
        }
        else if (sf == ShamanSpiritualForm.Horse)
        {
        }
        else if (sf == ShamanSpiritualForm.Eagle)
        {
        }
        else if (sf == ShamanSpiritualForm.Shark)
        {
        }
        else if (sf == ShamanSpiritualForm.Phoenix)
        {
        }
    }

    public void ElevateToSpiritual(string form)
    {
        switch (form)
        {
            case "Action 1":
                break;
        }
    }

    // Use this for initialization
    private void Start()
    {
       // _rb = GetComponent<Rigidbody>();
        Form = ShamanSpiritualForm.Eagle;
        _rb = GetComponent<Rigidbody>();
        Form = ShamanSpiritualForm.Egg;
    }

    // Update is called once per frame
    private void Update()
    {
        MoveSpiritualForm();
    }
}

public enum CollectibleType
{
    EarthCollectible,
    WindCollectible,
    FireCollectible,
    WaterCollectible
}
public enum ShamanSpiritualForm
{
    Egg,
    Horse,
    Phoenix,
    Shark,
    Eagle
}
