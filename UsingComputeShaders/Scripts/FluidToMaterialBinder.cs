﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chimera
{
    public class FluidToMaterialBinder : MonoBehaviour
    {
        public FluidController fluidController;
        public Material material;
        public string property;

        void OnEnable() {
            material.SetTexture(property, fluidController.GetOutputTexture());
        }
    }
}
