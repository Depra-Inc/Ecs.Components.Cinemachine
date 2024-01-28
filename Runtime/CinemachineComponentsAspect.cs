// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Worlds;

namespace Depra.Ecs.Components.Cinemachine
{
	public sealed class CinemachineComponentsAspect : IComponentAspect
	{
		void IComponentAspect.Initialize(World world)
		{
			world.AddAspect(this);
			world.AddPool(new ComponentPool<CinemachineVirtualCameraRef>());
		}

		void IComponentAspect.PostInitialize() { }
	}
}