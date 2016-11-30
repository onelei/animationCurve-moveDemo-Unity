using UnityEngine;

public class MoveItem : MonoBehaviour
{
    [SerializeField]
    UILabel NameText;
    public void SetData(int i) {
        NameText.text = i.ToString();
    }
}
