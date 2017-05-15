using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeFloor : MonoBehaviour {

    public Sprite floor1;
    public Sprite floor2;
    public Sprite floor3;
    public Button f1;
    public Button f2;
    public Button f3;

    private Vector3 back = new Vector3(0, 0, 11);
    private Vector3 main = new Vector3(0, 0, 10);

    private Image img;

    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();
        Button btn1 = f1.GetComponent<Button>();
        btn1.onClick.AddListener(OnClickFirstFloor);

        Button btn2 = f2.GetComponent<Button>();
        btn2.onClick.AddListener(OnClickSecondFloor);

        Button btn3 = f3.GetComponent<Button>();
        btn3.onClick.AddListener(OnClickThirdFloor);
    }

    void OnClickFirstFloor()
    {
        img.sprite = floor1;

        Debug.Log("You have clicked 1st floor button!");
    }

    void OnClickSecondFloor()
    {
        img.sprite = floor2;

        Debug.Log("You have clicked 2nd floor button!");
    }

    void OnClickThirdFloor()
    {
        img.sprite = floor3;

        Debug.Log("You have clicked 3rd floor button!");
    }
    // Update is called once per frame
}
