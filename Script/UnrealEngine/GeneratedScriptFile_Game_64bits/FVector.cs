#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVector
	{
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		
	}
	
}
#endif
#endif
