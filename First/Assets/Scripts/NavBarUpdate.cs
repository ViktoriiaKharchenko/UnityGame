
using UnityEngine;
using UnityEngine.UI;

public class NavBarUpdate : MonoBehaviour
{
    public Text nameText;
    public UserState user;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = user.GetName();
    }

}
