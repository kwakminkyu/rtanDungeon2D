using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAlert : MonoBehaviour
{
    public void OnEquipAlert() {
        gameObject.SetActive(true);
    }

    public void ApplyEquip() {
        //OnEquip();
        gameObject.SetActive(false);
    }

    public void CancelEquip() {
        gameObject.SetActive(false);
    }
}
