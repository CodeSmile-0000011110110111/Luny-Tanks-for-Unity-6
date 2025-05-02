using TMPro;
using UnityEngine;

namespace Tanks.Complete
{
    // This is used to quickly find the GameObject it is added to by using FindObjectOfType.
    // Used by the GameManager to find the text used to display game informations
    public class MessageTextReference : MonoBehaviour
    {
        public TextMeshProUGUI Text => GetComponent<TextMeshProUGUI>();
    }
}