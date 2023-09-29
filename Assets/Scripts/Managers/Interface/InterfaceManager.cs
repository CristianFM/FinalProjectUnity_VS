using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager staticInterfaceManager;
    [Space]
    [Header("Interfaz In Game")]
    [SerializeField] public GameObject inGameInterfazContainer;
    [SerializeField] public Slider hpSlider, xpSlider;
    [SerializeField] public TextMeshProUGUI txtHp, txtMaxHp, txtMin, txtSec;
    [Space]
    [Header("Time OPtions")]
    [SerializeField] public float timer, min;
    [SerializeField] public string[] splitTimer;
    [Space]
    [Header("LvUp Menu")]
    [SerializeField] public GameObject lvUpInterfazContainer;
    [SerializeField] public TextMeshProUGUI lvText;
    [SerializeField] public TextMeshProUGUI titulo1,titulo2,titulo3,titulo4;
    [SerializeField] public TextMeshProUGUI body1, body2, body3, body4;
    [SerializeField] public bool lvMenuIsOpen;

    private void Awake()
    {
        if(staticInterfaceManager == null)
        {
            staticInterfaceManager = this;
        }
        inicializateVariables();
    }

    public void inicializateVariables()
    {
        // Menu In Game
        lvText = inGameInterfazContainer.transform.Find("ActualLv/LvValue").GetComponent<TextMeshProUGUI>();
        hpSlider = inGameInterfazContainer.transform.Find("hpPanel/hpMeter").GetComponent<Slider>();
        xpSlider = inGameInterfazContainer.transform.Find("xpMeter").GetComponent<Slider>();
        txtHp = inGameInterfazContainer.transform.Find("hpPanel/hpCurrentTxt").GetComponent<TextMeshProUGUI>();
        txtMaxHp = inGameInterfazContainer.transform.Find("hpPanel/hpMaxTxt").GetComponent<TextMeshProUGUI>();
        txtMin = inGameInterfazContainer.transform.Find("Time/Min").GetComponent<TextMeshProUGUI>();
        txtSec = inGameInterfazContainer.transform.Find("Time/Sec").GetComponent<TextMeshProUGUI>();
        // Menu LvUP
        titulo1 = lvUpInterfazContainer.transform.Find("Buff_1/Title").GetComponent<TextMeshProUGUI>();
        titulo2 = lvUpInterfazContainer.transform.Find("Buff_2/Title").GetComponent<TextMeshProUGUI>();
        titulo3 = lvUpInterfazContainer.transform.Find("Buff_3/Title").GetComponent<TextMeshProUGUI>();
        titulo4 = lvUpInterfazContainer.transform.Find("Buff_4/Title").GetComponent<TextMeshProUGUI>();
        body1 = lvUpInterfazContainer.transform.Find("Buff_1/Description").GetComponent<TextMeshProUGUI>();
        body2 = lvUpInterfazContainer.transform.Find("Buff_2/Description").GetComponent<TextMeshProUGUI>();
        body3 = lvUpInterfazContainer.transform.Find("Buff_3/Description").GetComponent<TextMeshProUGUI>();
        body4 = lvUpInterfazContainer.transform.Find("Buff_4/Description").GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        timer = 0;
        min = 0;
        txtMin.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        setUIGameTimer();   
    }

    //Interfaz InGame
    #region
    public void setLvText(int _lv)
    {
        lvText.text = _lv.ToString();
    }
    public void setUIHpVariable(float hp, float maxHp)
    {
        txtHp.text = hp.ToString();
        txtMaxHp.text = maxHp.ToString();
        hpSlider.maxValue = maxHp;
        hpSlider.value = hp;
    }
    public void setUIXpVariable(int xp, int xpCap)
    {
        xpSlider.maxValue = xpCap;
        xpSlider.value = xp;
    }
    public void setUIGameTimer() 
    {
        string aux = timer.ToString();
        splitTimer = aux.Split(",");
        txtSec.text = splitTimer[0];

        if(timer >= 60)
        {
            min++;
            timer = 0;
            txtMin.text = min.ToString(); 
        }
    }
    #endregion

    //Interdaz LvUp
    #region
    public void interactLvUpMenu()
    {
        if (!lvMenuIsOpen)
        {
            Time.timeScale = 0;
            lvUpInterfazContainer.SetActive(true);
            lvMenuIsOpen = true;
        }else if (lvMenuIsOpen)
        {
            Time.timeScale = 1;
            lvUpInterfazContainer.SetActive(false);
            lvMenuIsOpen = false;
        }
    }
    #endregion
}
