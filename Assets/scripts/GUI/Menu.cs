using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    public  Button startButton;
    public  Canvas menuSelectLvl;
    private Canvas menuUI;

    public Canvas background;

    void Start () {
        menuUI = (Canvas)GetComponent<Canvas>();
        menuSelectLvl = (Canvas)menuSelectLvl.GetComponent<Canvas>();

        background = background.GetComponent<Canvas>();

        startButton = startButton.GetComponent<Button>();
        startButton.onClick.AddListener(SelectLevelMenu);
        background.enabled = true;
        menuUI.enabled = true;
        menuSelectLvl.enabled = false;

    }

    void Update () {
	}

    public void SelectLevelMenu()
    {
        menuUI.enabled = false;
        menuSelectLvl.enabled = true;
    }

}
