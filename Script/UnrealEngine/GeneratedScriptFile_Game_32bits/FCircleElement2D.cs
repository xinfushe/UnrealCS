#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FCircleElement2D
	{
		[FieldOffset(0)]
		public FVector2D Center;
		[FieldOffset(8)]
		public float Radius;
		
	}
	
}
#endif
#endif
