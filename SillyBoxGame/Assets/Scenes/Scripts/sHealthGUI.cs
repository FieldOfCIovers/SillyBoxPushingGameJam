using UnityEngine;
using UnityEngine.UI;

public class sHealthGUI : MonoBehaviour
{
    public sPlayerMain playerMain;
    public Text moneyText;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + playerMain.playerMoney;
    }
}
