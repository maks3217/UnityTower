using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SelectLvlMenu : MonoBehaviour {

    public GameObject prefabButton;
    public RectTransform ParentPanel;
    public Canvas background;

    public int lvlCount = 10;

    private Canvas thisMenu;

    void Start () {
        thisMenu = (Canvas)GetComponent<Canvas>();
        background = background.GetComponent<Canvas>();

        for (int i = 1; i <= lvlCount; i++)
        {
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            goButton.name = "Button lvl " + i;
            goButton.GetComponentInChildren<Text>().text = ""+i;
            goButton.transform.SetParent(ParentPanel, false);

            Button tempButton = goButton.GetComponent<Button>();
            int tempInt = i;

            tempButton.onClick.AddListener(() => ButtonClicked(tempInt));
        }

    }

    private void ButtonClicked(int id)
    {
        thisMenu.enabled = false;
        background.enabled = false;

        SceneManager.LoadScene(id);
    }

    void Update () {
		
	}
}
