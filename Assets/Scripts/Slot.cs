using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Item item;
    private Image itemImage;
    private Image equip;

    private GameObject equipAlert;

    private void Awake() {
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
        equip = gameObject.transform.GetChild(1).GetComponent<Image>();
        equipAlert = GameObject.FindGameObjectWithTag("equipAlert");
    }
    private void Start() {
        UpdateSlot();
    }
    private void UpdateSlot() {
        if (item.equip) {
            equip.gameObject.SetActive(true);
        }
        if (item.image != null) {
            itemImage.sprite = item.image;
            itemImage.gameObject.SetActive(true);
        }
    }

    private void OnEquip() {
        item.equip = item.equip != true ? true : false;
        UpdateSlot();
    }
}
