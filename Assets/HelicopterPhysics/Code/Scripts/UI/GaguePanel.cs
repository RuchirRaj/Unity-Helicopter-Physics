using System.Globalization;
using HelicopterPhysics.Inputs;
using TMPro;
using UnityEngine;


public class GaguePanel : MonoBehaviour
{
    [Header("UI Properties")]
    public TextMeshProUGUI RawThrottle;
    public TextMeshProUGUI StickyThrottle;
    public TextMeshProUGUI Collective;
    public TextMeshProUGUI StickyCollective;
    public TextMeshProUGUI Cyclic;
    public TextMeshProUGUI Pedal;


    [Header("Other References")]
    public InputController Input;

    private void Update()
    {
        if(!Input)
            return;
        RawThrottle.text = Input.activeInput.ThrottleInput.ToString(CultureInfo.InvariantCulture);
        StickyThrottle.text = Input.activeInput.StickyThrottle.ToString(CultureInfo.InvariantCulture);
        Collective.text = Input.activeInput.CollectiveInput.ToString(CultureInfo.InvariantCulture);
        StickyCollective.text = Input.activeInput.StickyCollective.ToString(CultureInfo.InvariantCulture);
        Cyclic.text = "(" + Input.activeInput.CyclicInput.x + "," + Input.activeInput.CyclicInput.y + ")";
        Pedal.text = Input.activeInput.PedalInput.ToString(CultureInfo.InvariantCulture);
    }

}
