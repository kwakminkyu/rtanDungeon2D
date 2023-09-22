using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerInfo playerInfo;
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private TextMeshProUGUI playerLevel;
    [SerializeField] private TextMeshProUGUI playerExplain;
    [SerializeField] private TextMeshProUGUI currentGold;

    [SerializeField] private GameObject statusBtn;
    [SerializeField] private GameObject inventoryBtn;
    
    [SerializeField] private GameObject statusCanvas;
    [SerializeField] private TextMeshProUGUI playerAtk;
    [SerializeField] private TextMeshProUGUI playerDef;
    [SerializeField] private TextMeshProUGUI playerHp;

    [SerializeField] private GameObject InventoryCanvas;

    private void Awake() {
        playerInfo = player.GetComponent<PlayerInfo>();
        statusCanvas.SetActive(false);
        InventoryCanvas.SetActive(false);
    }
    private void Start() {
        SetPlayer();
    }

    private void SetPlayer() {
        playerName.text = playerInfo.userName;
        playerLevel.text = $"LV. {playerInfo.level.ToString()}";
        playerExplain.text = playerInfo.explain;
        currentGold.text = playerInfo.gold.ToString();
    }

    public void MainDisplay() {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);

        statusCanvas.SetActive(false);
        InventoryCanvas.SetActive(false);
    }

    public void StatusDisplay() {
        statusCanvas.SetActive(true);
        playerAtk.text = $"공격력 : {playerInfo.atk.ToString()}";
        playerDef.text = $"방어력 : {playerInfo.def.ToString()}";
        playerHp.text = $"체력 : {playerInfo.hp.ToString()}";

        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
    }
    
    public void InventoryDisplay() {
        InventoryCanvas.SetActive(true);

        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
    }
}
