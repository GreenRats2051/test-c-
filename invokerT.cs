using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invokerT
{
    private InputT _inputT;
    private PlayerT _playerT;
    private PlayerMovementT _payerMovementT;

    public invokerT(PlayerMovementT payerMovementT, PlayerT playerT, InputT inputT)
    {
        _payerMovementT = payerMovementT;
        _playerT = playerT;
        _inputT = inputT;
    }

    public void invokeMove()
    {
        _payerMovementT.Move(_playerT.rb, _inputT.inputAction, _playerT.speed);
    }

    public void invokeJump()
    {
        _payerMovementT.Jump(_playerT.rb, _inputT.jump, _playerT.force);
    }
}
