using UnityEngine;
namespace HelicopterPhysics.Inputs
{

    public class XboxHeliInput : BaseHeliInput
    {

        protected override void HandleCollective()
        {
            CollectiveInput = Input.GetAxis("XboxCollective");
        }

        protected override void HandleCyclic()
        {
            Vector2 temp = new Vector2(
                Input.GetAxis("XboxCyclicHorizontal")
                , Input.GetAxis("XboxCyclicVertical"));

            CyclicInput = temp;
        }

        protected override void HandlePedal()
        {
            PedalInput = Input.GetAxis("XboxPedal");
        }

        protected override void HandleThrottle()
        {
            ThrottleInput = Input.GetAxis("XboxThrottleUp") +
                Input.GetAxis("XboxThrottleDown");
        }

    }
}
