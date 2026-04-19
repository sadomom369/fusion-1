using Fusion;
using System;
using UnityEngine;

[Flags]  // 必须添加，因为 NetworkButtons 内部使用位运算
public enum InputButtons
{
    NONE = 0,
    JUMP = 1 << 0   // 第0位表示跳跃
    // 如果需要更多按钮，继续添加：
    // FIRE = 1 << 1,
    // DASH = 1 << 2
}

public struct NetworkInputData : INetworkInput
{
    public NetworkButtons buttons;
    public Vector3 movementInput;
}