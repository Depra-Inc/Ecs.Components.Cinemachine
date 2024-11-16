// SPDX-License-Identifier: Apache-2.0
// © 2024 Evgeniy Kraevskiy <e.craevsky@depra.org>

using System;
using Cinemachine;

namespace Depra.Ecs.Components.Cinemachine
{
	[Serializable]
    public struct CinemachineImpulseSourceRef
    {
        public CinemachineImpulseSource Value;
    }
}
