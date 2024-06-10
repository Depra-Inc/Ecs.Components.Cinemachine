// SPDX-License-Identifier: Apache-2.0
// © 2024 Evgeniy Kraevskiy <e.craevsky@depra.org>

using Cinemachine;
using Depra.Ecs.QoL.Components;

namespace Depra.Ecs.Components.Cinemachine
{
    public struct CinemachineImpulseSourceRef : IComponent
    {
        public CinemachineImpulseSource Value;
    }
}
