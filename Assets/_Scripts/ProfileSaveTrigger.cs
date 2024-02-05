using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileSaveTrigger : MonoBehaviour
{
    
    public void OnTriggerEnter3D(Collider other)
    {
        ProfileStorage.StoragePlayerProfile(other.gameObject);
    }
}
