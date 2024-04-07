// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

namespace Depra.Ecs.Components.Cinemachine
{
	public sealed class CinemachineComponentsAspect : IComponentAspect
	{
		void IComponentAspect.Initialize(AspectGroup aspects, ComponentPoolGroup pools)
		{
			aspects.Add(this);
			pools.Add(new ComponentPool<CinemachineVirtualCameraRef>());
			pools.Add(new ComponentPool<CinemachineVirtualCameraBaseRef>());
		}
	}
}