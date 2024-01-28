// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using Cinemachine;
using Depra.Ecs.QoL.Components;

namespace Depra.Ecs.Components.Cinemachine
{
	public struct CinemachineVirtualCameraRef : IComponent
	{
		public CinemachineVirtualCameraBase Value;
	}
}