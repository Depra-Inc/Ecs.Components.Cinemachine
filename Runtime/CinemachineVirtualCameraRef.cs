// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using Cinemachine;

namespace Depra.Ecs.Components.Cinemachine
{
	[Serializable]
	public struct CinemachineVirtualCameraRef
	{
		public CinemachineVirtualCamera Value;
	}
}