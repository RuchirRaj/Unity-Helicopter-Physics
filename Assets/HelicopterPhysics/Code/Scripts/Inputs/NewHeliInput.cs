using UnityEngine;
using UnityEngine.InputSystem;

// ReSharper disable once CheckNamespace
namespace HelicopterPhysics.Inputs
{
    public class NewHeliInput : BaseHeliInput
    {

        private float _collectiveInput;
        private float _pedalInput;
        private float _throttleInput;
        private Vector2 _cyclicInput;

        public void Update_Collective(InputAction.CallbackContext context)
        {
            _collectiveInput = context.ReadValue<float>();
        }
        
        public void Update_Cyclic(InputAction.CallbackContext context)
        {
            _cyclicInput = context.ReadValue<Vector2>();
        }
        public void Update_Pedal(InputAction.CallbackContext context)
        {
            _pedalInput = context.ReadValue<float>();
        }
        public void Update_Throttle(InputAction.CallbackContext context)
        {
            _throttleInput = context.ReadValue<float>();
        }
        
        protected override void HandleCollective()
        {
            CollectiveInput = _collectiveInput;
        }

        protected override void HandleCyclic()
        {
            
            CyclicInput = _cyclicInput;
        }

        protected override void HandlePedal()
        {
            PedalInput = _pedalInput;
        }

        protected override void HandleThrottle()
        {
            ThrottleInput = _throttleInput;
        }
    }
}
