

using UnityEngine;
using UnityEngine.UI;

public class DropD : MonoBehaviour
{
    Dropdown m_Dropdown;
    static public string playerColor;
    public Text m_Text;
    int m_DropdownValue;

    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();
    }

    void Update()
    {
        m_DropdownValue = m_Dropdown.value;
        playerColor = m_Dropdown.options[m_DropdownValue].text;
    }
}