﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockTypeEnum { simple, condition, loop, operation, trigger, none }

public interface I_BE2_Block
{
    Transform Transform { get; }

    // v2.1 - "Type" property of the I_BE2_Block made settable to fix and facilitate build of custom blocks
    BlockTypeEnum Type { get; set; }
    I_BE2_BlockLayout Layout { get; }
    I_BE2_Instruction Instruction { get; }
    I_BE2_BlockSection ParentSection { get; }
    I_BE2_Drag Drag { get; }
    void SetShadowActive(bool value); 
}
