using System.Runtime.InteropServices;

[global::Cpp2ILInjected.Token(Token = "0x200008E")]
public class FluidSolver : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x200008F")]
	private struct PowerUpMergeData
	{
		[global::Cpp2ILInjected.Token(Token = "0x400032C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int partner;

		[global::Cpp2ILInjected.Token(Token = "0x400032D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float startTime;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000090")]
	private sealed class _003C_003Ec__DisplayClass140_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x400032E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool createPowerup;

		[global::Cpp2ILInjected.Token(Token = "0x400032F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public global::System.Collections.Generic.HashSet<int> fresh;

		[global::Cpp2ILInjected.Token(Token = "0x4000330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::UnityEngine.Vector2 touchPos;

		[global::Cpp2ILInjected.Token(Token = "0x4000332")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int touchId;

		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x10074F8", Offset = "0x10074F8", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass140_0()
		{
		}

		internal void _003CUserRemoveRegion_003Eb__0(global::System.Collections.Generic.HashSet<int> toRemove)
		{
			if (createPowerup)
			{
				global::System.Collections.Generic.HashSet<int> hashSet = fresh;
				FluidSolver fluidSolver = _003C_003E4__this;
				int num = hashSet.Count - fluidSolver.bigPowerUpThreshold;
				bool flag = num < 0;
				bool flag2 = num == 0;
				int num2 = hashSet.Count ^ fluidSolver.bigPowerUpThreshold;
				int num3 = hashSet.Count ^ num;
				int num4 = num2 & num3;
				bool flag3 = num4 < 0;
				bool flag4 = flag == flag3;
				bool flag5 = !flag2;
				bool isBig = flag4 && flag5;
				global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
				vector.x = touchPos.x;
				vector.y = touchPos.y;
				global::Unity.Mathematics.float2 pos = vector;
				float y = pos.y;
				PowerUp powerUp = fluidSolver.AddPowerUp(pos, 0, isBig);
			}
			FluidSolver fluidSolver2 = _003C_003E4__this;
			global::System.Action<global::System.Collections.Generic.HashSet<int>, int> onRemoveRegionComplete = fluidSolver2.OnRemoveRegionComplete;
			if (fluidSolver2.OnRemoveRegionComplete != null)
			{
				int num5 = touchId;
				onRemoveRegionComplete(toRemove, num5);
			}
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000091")]
	private sealed class _003C_003Ec__DisplayClass146_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int octId;

		[global::Cpp2ILInjected.Token(Token = "0x4000335")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public global::System.Collections.Generic.HashSet<int> headIds;

		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x10075C8", Offset = "0x10075C8", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass146_0()
		{
		}

		internal void _003CAddOctopus_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.octopusIds[ctx.Index] = octId;
			if (fluidSolver.octopusHeadParticleCount > 0)
			{
				fluidSolver.inOctopusHead[ctx.Index] = true;
				headIds.Add(ctx.Id);
			}
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000092")]
	private sealed class _003C_003Ec__DisplayClass150_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000336")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000337")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int id;

		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x100767C", Offset = "0x100767C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass150_0()
		{
		}

		internal void _003CAddCaterpillar_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.caterpillarIds[ctx.Index] = id;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000093")]
	private sealed class _003C_003Ec__DisplayClass151_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000338")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000339")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int id;

		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x10076B0", Offset = "0x10076B0", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass151_0()
		{
		}

		internal void _003CAddBee_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.isHoneyCoated[ctx.Index] = true;
			fluidSolver.beeIds[ctx.Index] = id;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			((Honey)null).AddSolverParticle(ctx);
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000094")]
	private sealed class _003C_003Ec__DisplayClass153_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x400033A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400033B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int spongeId;

		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x100790C", Offset = "0x100790C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass153_0()
		{
		}

		internal void _003CAddSponge_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.spongeIds[ctx.Index] = spongeId;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000095")]
	private sealed class _003C_003Ec__DisplayClass155_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x400033C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400033D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int clumpId;

		[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007940", Offset = "0x1007940", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass155_0()
		{
		}

		internal void _003CAddClump_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.clumpIds[ctx.Index] = clumpId;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	private sealed class _003C_003Ec__DisplayClass161_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x400033E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400033F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int fishId;

		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007974", Offset = "0x1007974", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass161_0()
		{
		}

		internal void _003CAddFish_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.fishIds[ctx.Index] = fishId;
			fluidSolver.gravities[ctx.Index] = fluidSolver.fishGravity;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	private sealed class _003C_003Ec__DisplayClass162_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000340")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000341")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int puId;

		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x10079B8", Offset = "0x10079B8", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass162_0()
		{
		}

		internal void _003CAddPowerUp_003Eb__0(ParticleInitData ctx)
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			fluidSolver.powerUpIds[ctx.Index] = puId;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000098")]
	private sealed class _003C_003Ec__DisplayClass169_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000342")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000343")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public PowerUp pu;

		[global::Cpp2ILInjected.Token(Token = "0x4000344")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int puId;

		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x10079EC", Offset = "0x10079EC", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass169_0()
		{
		}

		internal void _003CRemovePowerUp_003Eb__0(global::System.Collections.Generic.HashSet<int> toRemove)
		{
			//IL_0047: Expected O, but got I
			FluidSolver fluidSolver = _003C_003E4__this;
			PowerUp powerUp = pu;
			bool flag = fluidSolver.usedFluidTypes.Remove(powerUp.fluidType);
			bool flag2 = fluidSolver.powerUpMidpoints.Remove(puId);
		}
	}

	[StructLayout((LayoutKind)3)]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000099")]
	private struct _003C_003Ec__DisplayClass183_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000345")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::Unity.Mathematics.float2 origin;

		[global::Cpp2ILInjected.Token(Token = "0x4000346")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float prevR;

		[global::Cpp2ILInjected.Token(Token = "0x4000347")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000348")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int bandType;

		[global::Cpp2ILInjected.Token(Token = "0x4000349")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float halfThickness;
	}

	[StructLayout((LayoutKind)3)]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200009A")]
	private struct _003C_003Ec__DisplayClass190_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x400034A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.Collections.Generic.HashSet<int> ids;

		[global::Cpp2ILInjected.Token(Token = "0x400034B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public FluidSolver _003C_003E4__this;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200009B")]
	private sealed class _003CHandleRejectFlash_003Ed__190 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400034C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400034D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400034E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public global::System.Collections.Generic.HashSet<int> ids;

		[global::Cpp2ILInjected.Token(Token = "0x400034F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000350")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private FluidSolver._003C_003Ec__DisplayClass190_0 _003C_003E8__1;

		[global::Cpp2ILInjected.Token(Token = "0x4000351")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _003CstartTime_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x4000352")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _003Cduration_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1007BF0", Offset = "0x1007BF0", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1007C38", Offset = "0x1007C38", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007A88", Offset = "0x1007A88", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleRejectFlash_003Ed__190(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007AB4", Offset = "0x1007AB4", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007AB8", Offset = "0x1007AB8", Length = "0x138")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = this.<>1__state == 1;\n\tif (v22) goto L_005B;\n\tv27 = this.<>1__state == 0;\n\tv28 = ~v27;\n\tif (v28) goto L_007B;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv35 = this + 0x30;\n\tthis.<>8__1.ids = this.ids;\n\tv36 = 0xF3F1B4(v35, this.ids, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv110 = this + 0x38;\n\tthis.<>8__1.<>4__this = this.<>4__this;\n\tv112 = 0xF3F1B4(v110, this.<>4__this, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv206 = UnityEngine.Time::get_time();\n\tthis.<startTime>5__2 = v206;\n\tthis.<duration>5__3 = 0.5f;\n\tv181 = UnityEngine.Time::get_time();\n\tv179 = this.<startTime>5__2 + this.<duration>5__3;\n\tv176 = v181 >= v179;\n\tif (v176) goto L_006D;\nL_003B:\n\tv204 = UnityEngine.Time::get_time();\n\tv211 = v204 - this.<startTime>5__2;\n\tv212 = v211 / this.<duration>5__3;\n\tv208 = EasingFunction::EaseOutCubic(v212);\n\tv215 = this + 0x30;\n\tv126 = 1f - v208;\n\tFluidSolver::<HandleRejectFlash>g__SetEmissionValues|190_0(this.<>4__this, 1f, v126, v215);\n\tv218 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv220 = 0xF3F1B4(v218, 0, 0, v38, v39, v40, v41, v42, 1f, v126, this.<duration>5__3, v46, v47, v48, v49, v50);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_005B:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv31 = UnityEngine.Time::get_time();\n\tv98 = this.<startTime>5__2 + this.<duration>5__3;\n\tv102 = v31 < v98;\n\tif (v102) goto L_003B;\nL_006D:\n\tv67 = this + 0x30;\n\tFluidSolver::<HandleRejectFlash>g__SetEmissionValues|190_0(this.<>4__this, 0f, 0f, v67);\nL_007B:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 85 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private unsafe bool MoveNext()
		{
			//IL_0184: Expected O, but got I
			//IL_0060: Expected O, but got I
			//IL_0087: Expected O, but got I
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 0)
				{
					goto IL_021a;
				}
				_003C_003E1__state = -1;
				_003C_003E8__1.ids = ids;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				float time = global::UnityEngine.Time.time;
				_003CstartTime_003E5__2 = time;
				_003Cduration_003E5__3 = 0.5f;
				float time2 = global::UnityEngine.Time.time;
				float num = _003CstartTime_003E5__2 + _003Cduration_003E5__3;
				if (time2 < num)
				{
					goto IL_0107;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				float time3 = global::UnityEngine.Time.time;
				float num2 = _003CstartTime_003E5__2 + _003Cduration_003E5__3;
				if (time3 < num2)
				{
					goto IL_0107;
				}
			}
			_003C_003E4__this._003CHandleRejectFlash_003Eg__SetEmissionValues_007C190_0(0f, 0f, ref _003C_003E8__1);
			goto IL_021a;
			IL_021a:
			return false;
			IL_0107:
			float time4 = global::UnityEngine.Time.time;
			float num3 = time4 - _003CstartTime_003E5__2;
			float t = num3 / _003Cduration_003E5__3;
			float num4 = EasingFunction.EaseOutCubic(t);
			float a = 1f - num4;
			_003C_003E4__this._003CHandleRejectFlash_003Eg__SetEmissionValues_007C190_0(1f, a, ref _003C_003E8__1);
			_003C_003E2__current = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = 1;
			return true;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007BF8", Offset = "0x1007BF8", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xD80;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			throw new global::System.NotSupportedException();
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200009C")]
	private sealed class _003CHandleRemove_003Ed__141 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000353")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x4000354")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x4000355")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000356")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::System.Collections.Generic.HashSet<int> ids;

		[global::Cpp2ILInjected.Token(Token = "0x4000357")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool explode;

		[global::Cpp2ILInjected.Token(Token = "0x4000358")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float delay;

		[global::Cpp2ILInjected.Token(Token = "0x4000359")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public global::System.Action<global::System.Collections.Generic.HashSet<int>> onRemove;

		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1007F88", Offset = "0x1007F88", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1007FD0", Offset = "0x1007FD0", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007C40", Offset = "0x1007C40", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleRemove_003Ed__141(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007C6C", Offset = "0x1007C6C", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007C70", Offset = "0x1007C70", Length = "0x318")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x968;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv58 = Il2CppMethodInfo;\n\tv59 = v58 + 0x970;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv73 = Il2CppMethodInfo;\n\tv74 = v73 + 0x978;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv217 = Il2CppMethodInfo;\n\tv218 = v217 + 0x998;\n\tv219 = \"il2cpp_codegen_initialize_runtime_metadata\"(v218, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv259 = Il2CppMethodInfo;\n\tv260 = v259 + 0x9A0;\n\tv261 = \"il2cpp_codegen_initialize_runtime_metadata\"(v260, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv270 = Il2CppMethodInfo;\n\tv271 = v270 + 0xC28;\n\tv272 = \"il2cpp_codegen_initialize_runtime_metadata\"(v271, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv291 = System.Xml.ValidateNames;\n\tv292 = v291 + 0x258;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v292, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AA3D]) = v50;\nL_002A:\n\tv51 = 0;\n\tv56 = this.<>4__this;\n\tv57 = this.<>1__state == 0;\n\tif (v57) goto L_0063;\n\tv70 = this.<>1__state != 1;\n\tif (v70) goto L_00B3;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv77 = this.<>4__this == 0;\n\tif (v77) goto L_00C7;\n\tv191 = this.ids;\n\tFluidSolver::RemoveParticles(this.<>4__this, this.ids, this.onRemove);\n\tv210 = this.ids == 0;\n\tif (v210) goto L_00C7;\n\tv277 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.ids);\n\tv293 = Il2CppMethodInfo;\nL_0057:\n\tv305 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v51 @ stack_-68_v1, *([v293 @ X19_v9 (Il2CppMethodInfo)+970]));\n\tv324 = v305 & 1;\n\tv150 = v324 == 0;\n\tif (v150) goto L_00AA;\n\tv302 = System.Collections.Generic.HashSet`1<System.Int32>::Remove(v56._pendingRemovalIds, 0);\n\tgoto L_0057;\nL_0063:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv72 = this.<>4__this == 0;\n\tif (v72) goto L_00C7;\n\tv184 = this.<>4__this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v184);\n\tv214 = v56.OnStartRemoveParticles;\n\tv258 = v56.OnStartRemoveParticles == 0;\n\tif (v258) goto L_0073;\n\tv116 = this.explode;\n\tv108 = v214.method;\n\tv214.invoke_impl(v267, v214.method_code, this.ids, this.explode, v214.method, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0073:\n\tv211 = this.ids == 0;\n\tif (v211) goto L_00C7;\n\tv283 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.ids);\n\tv94 = this.<>4__this + 0x1F8;\n\tv295 = Il2CppMethodInfo;\n\tv296 = Il2CppMethodInfo;\nL_0084:\n\tv320 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v51 @ stack_-68_v1, *([v295 @ X23_v3 (Il2CppMethodInfo)+970]));\n\tv325 = v320 & 1;\n\tv151 = v325 == 0;\n\tif (v151) goto L_0094;\n\tv108 = *([v296 @ X24_v3 (Il2CppMethodInfo)+C28]);\n\tv313 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v94, 0, &v306 @ stack_-6C_v4, *([v296 @ X24_v3 (Il2CppMethodInfo)+C28]));\n\tv334 = v313 & 1;\n\tv315 = v334 == 0;\n\tif (v315) goto L_0084;\n\tv307 = v56.scales;\n\t*([v307 @ X9_v5 (Unity.Collections.NativeArray`1<System.Single>)+v306 @ stack_-6C_v4*4]) = 0;\n\tgoto L_0084;\nL_0094:\n\tv329 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v51 @ stack_-68_v1, *([v329 @ X8_v14 (Il2CppMethodInfo)+968]));\nL_0099:\n\t;\n\tv335 = System.Xml.ValidateNames;\n\tv338 = new *([v335 @ X8_v16 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v338, this.delay);\n\tv162 = this + 0x18;\n\tthis.<>2__current = v338;\n\tv147 = 0xF3F1B4(v162, v338, v116, v108, v35, v36, v37, v38, this.delay, v40, v41, v42, v43, v44, v45, v46);\n\tthis.<>1__state = 1;\n\tgoto L_00B3;\nL_00AA:\n\tv327 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v51 @ stack_-68_v1, *([v327 @ X8_v24 (Il2CppMethodInfo)+968]));\nL_00B3:\n\tv168 = this.<>1__state == 0;\n\treturn v168;\n\tv205 = new System.NullReferenceException();\nL_00C7:\n\tv216 = new System.NullReferenceException();\n\tgoto L_00D4;\n\tgoto L_00D4;\nL_00D4:\n\tv120 = v191 != 1;\n\tif (v120) goto L_00E6;\n\tv285 = 0x274A080(v216, v191, v117, v109, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv297 = 0x274A098(v285, v191, v117, v109, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv321 = Il2CppMethodInfo;\n\tv191 = *([v321 @ X8_v5 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v100, *([v321 @ X8_v5 (Il2CppMethodInfo)+968]));\n\tv152 = *([v285 @ X0_v11]) == 0;\n\tif (v152) goto L_00B3;\n\tv287 = new System.OutOfMemoryException();\nL_00E6:\n\tv290 = 0xBF092C(&v103 @ stack_-80 (System.Int32), v191, v117, v109, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_0107;\n\tgoto L_00E9;\nL_00E9:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0104;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = *([X0]);\n\tstack[0] = X20;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = stack[8];\n\tX8 = X8 + 0x968;\n\tX1 = *([X8]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(X0, X1);\n\tif (TEMP) goto L_0099;\n\tX0 = X20;\n\tX0 = OutOfMemoryException /* throw helper */(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\nL_0104:\n\tX0 = &stack[0];\n\tX0 = 0xBF092C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0107:\n\tv323 = 0x27498DC(v254, v191, v117, v109, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturnVal2 = 0xD6F8(v323, v191, v117, v109, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn returnVal2;\n// 131 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			FluidSolver fluidSolver = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_02ef;
				}
				_003C_003E1__state = -1;
				if (fluidSolver != null)
				{
					fluidSolver.RemoveParticles(ids, onRemove);
					if (ids != null)
					{
						foreach (int item in ids)
						{
							fluidSolver._pendingRemovalIds.Remove(item);
						}
						goto IL_02ef;
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (fluidSolver != null)
				{
					fluidSolver._lastJob.Complete();
					global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> onStartRemoveParticles = fluidSolver.OnStartRemoveParticles;
					if (onStartRemoveParticles != null)
					{
						onStartRemoveParticles(ids, explode);
					}
					if (ids != null)
					{
						foreach (int item2 in ids)
						{
							if (fluidSolver.idToIndex.TryGetValue(item2, out int index))
							{
								fluidSolver.scales[index] = 0f;
							}
						}
						global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(delay);
						_003C_003E2__current = waitForSeconds;
						_003C_003E1__state = 1;
						goto IL_02ef;
					}
				}
			}
			throw new global::System.NullReferenceException();
			IL_02ef:
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007F90", Offset = "0x1007F90", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xD88;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			throw new global::System.NotSupportedException();
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200009D")]
	private sealed class _003CProcessExplosionQueue_003Ed__182 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400035A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400035B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400035C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x100817C", Offset = "0x100817C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x10081C4", Offset = "0x10081C4", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1007FD8", Offset = "0x1007FD8", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CProcessExplosionQueue_003Ed__182(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1008004", Offset = "0x1008004", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1008008", Offset = "0x1008008", Length = "0x174")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x870;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0x880;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv68 = System.Xml.ValidateNames;\n\tv69 = v68 + 0x258;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AA3E]) = v42;\nL_001B:\n\tv44 = this.<>4__this;\n\tv49 = this.<>1__state == 2;\n\tif (v49) goto L_003B;\n\tv61 = this.<>1__state == 1;\n\tif (v61) goto L_0067;\n\tv70 = this.<>1__state == 0;\n\tv71 = ~v70;\n\tif (v71) goto L_008B;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv44.isProcessing = 1;\n\tgoto L_003E;\nL_003B:\n\tthis.<>1__state = 0xFFFFFFFF;\nL_003E:\n\tv86 = v44.explosionQueue;\n\tv125 = v86._size <= 0;\n\tif (v125) goto L_008D;\n\tv179 = System.Collections.Generic.Queue`1<System.Int32>::Dequeue(v86);\n\tv185 = FluidSolver::RadialDestroyRoutine(v44, v179);\n\tv186 = this + 0x18;\n\tthis.<>2__current = v185;\n\tv188 = 0xF3F1B4(v186, v185, 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_0067:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv109 = System.Xml.ValidateNames;\n\tv112 = new *([v109 @ X8_v11 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v112, v44.chainDelay);\n\tv180 = this + 0x18;\n\tthis.<>2__current = v112;\n\tv182 = 0xF3F1B4(v180, v112, v25, v26, v27, v28, v29, v30, v44.chainDelay, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 2;\n\treturn 1;\nL_008B:\n\treturn 0;\nL_008D:\n\tv44.isProcessing = 0;\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 104 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_012b: Expected I, but got O
			//IL_014f: Expected O, but got I
			//IL_00e8: Expected O, but got I
			FluidSolver fluidSolver = _003C_003E4__this;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(fluidSolver.chainDelay);
					_003C_003E2__current = waitForSeconds;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					_003C_003E1__state = 2;
					return true;
				}
				if (_003C_003E1__state != 0)
				{
					return false;
				}
				_003C_003E1__state = -1;
				fluidSolver.isProcessing = true;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			global::System.Collections.Generic.Queue<int> explosionQueue = fluidSolver.explosionQueue;
			if (explosionQueue.Count > 0)
			{
				int rootId = explosionQueue.Dequeue();
				global::System.Collections.IEnumerator enumerator = fluidSolver.RadialDestroyRoutine(rootId);
				_003C_003E2__current = enumerator;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				_003C_003E1__state = 1;
				return true;
			}
			fluidSolver.isProcessing = false;
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1008184", Offset = "0x1008184", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xD90;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			throw new global::System.NotSupportedException();
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200009E")]
	private sealed class _003CRadialDestroyRoutine_003Ed__183 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400035D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400035E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400035F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x4000360")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int rootId;

		[global::Cpp2ILInjected.Token(Token = "0x4000361")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private FluidSolver._003C_003Ec__DisplayClass183_0 _003C_003E8__1;

		[global::Cpp2ILInjected.Token(Token = "0x4000362")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private PowerUp _003Croot_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x4000363")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.Collections.Generic.HashSet<int> _003Ccohort_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x4000364")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private float _003CstartTime_003E5__4;

		[global::Cpp2ILInjected.Token(Token = "0x4000365")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.Collections.Generic.HashSet<int> _003CprevFrame_003E5__5;

		[global::Cpp2ILInjected.Token(Token = "0x4000366")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.Collections.Generic.HashSet<int> _003Cfading_003E5__6;

		[global::Cpp2ILInjected.Token(Token = "0x4000367")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.Collections.Generic.HashSet<int> _003CdehoneyedBeeIds_003E5__7;

		[global::Cpp2ILInjected.Token(Token = "0x4000368")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private global::System.Collections.Generic.HashSet<int> _003Cprocessed_003E5__8;

		[global::Cpp2ILInjected.Token(Token = "0x4000369")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private global::System.Collections.Generic.HashSet<int> _003Ctriggered_003E5__9;

		[global::Cpp2ILInjected.Token(Token = "0x400036A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private float _003CstartDet_003E5__10;

		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1009580", Offset = "0x1009580", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x10095C8", Offset = "0x10095C8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x10081CC", Offset = "0x10081CC", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CRadialDestroyRoutine_003Ed__183(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x10081F8", Offset = "0x10081F8", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x10081FC", Offset = "0x10081FC", Length = "0x1384")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0090;\n\tv49 = CollectParticleData[];\n\tv50 = v49 + 0xCF8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv92 = Il2CppMethodInfo;\n\tv93 = v92 + 0x980;\n\tv94 = \"il2cpp_codegen_initialize_runtime_metadata\"(v93, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv107 = Il2CppMethodInfo;\n\tv108 = v107 + 0x968;\n\tv109 = \"il2cpp_codegen_initialize_runtime_metadata\"(v108, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv117 = Il2CppMethodInfo;\n\tv118 = v117 + 0x970;\n\tv119 = \"il2cpp_codegen_initialize_runtime_metadata\"(v118, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv972 = Il2CppMethodInfo;\n\tv973 = v972 + 0x988;\n\tv974 = \"il2cpp_codegen_initialize_runtime_metadata\"(v973, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1236 = Il2CppMethodInfo;\n\tv1237 = v1236 + 0x978;\n\tv1238 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1237, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1264 = Il2CppMethodInfo;\n\tv1265 = v1264 + 0x990;\n\tv1266 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1265, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1279 = Il2CppMethodInfo;\n\tv1280 = v1279 + 0x980;\n\tv1281 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1280, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1297 = Il2CppMethodInfo;\n\tv1298 = v1297 + 0x990;\n\tv1299 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1298, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1320 = Il2CppMethodInfo;\n\tv1321 = v1320 + 0x998;\n\tv1322 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1321, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1353 = Il2CppMethodInfo;\n\tv1354 = v1353 + 0x9A0;\n\tv1355 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1354, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1447 = Il2CppMethodInfo;\n\tv1448 = v1447 + 0x968;\n\tv1449 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1448, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1483 = Il2CppMethodInfo;\n\tv1484 = v1483 + 0x978;\n\tv1485 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1484, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1508 = Il2CppMethodInfo;\n\tv1509 = v1508 + 0x9B0;\n\tv1510 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1509, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1550 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv1551 = v1550 + 0x5D8;\n\tv1552 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1551, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1758 = Il2CppMethodInfo;\n\tv1759 = v1758 + 0x410;\n\tv1760 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1759, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1784 = Il2CppMethodInfo;\n\tv1785 = v1784 + 0x438;\n\tv1786 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1785, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1863 = Il2CppMethodInfo;\n\tv1864 = v1863 + 0x3F8;\n\tv1865 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1864, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1887 = Il2CppMethodInfo;\n\tv1888 = v1887 + 0x948;\n\tv1889 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1888, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1905 = Il2CppMethodInfo;\n\tv1906 = v1905 + 0xA08;\n\tv1907 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1906, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1915 = Il2CppMethodInfo;\n\tv1916 = v1915 + 0x820;\n\tv1917 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1916, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1951 = Il2CppMethodInfo;\n\tv1952 = v1951 + 0xA10;\n\tv1953 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1952, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1982 = Il2CppMethodInfo;\n\tv1983 = v1982 + 0x828;\n\tv1984 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1983, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2115 = Il2CppMethodInfo;\n\tv2116 = v2115 + 0x950;\n\tv2117 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2116, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2138 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv2139 = v2138 + 0x110;\n\tv2140 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2139, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2175 = Il2CppMethodInfo;\n\tv2176 = v2175 + 0xC28;\n\tv2177 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2176, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2187 = Il2CppMethodInfo;\n\tv2188 = v2187 + 0xC68;\n\tv2189 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2188, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2216 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv2217 = v2216 + 0xFD8;\n\tv2218 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2217, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2243 = Il2CppMethodInfo;\n\tv2244 = v2243 + 0xC90;\n\tv2245 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2244, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2272 = Il2CppMethodInfo;\n\tv2273 = v2272 + 0xC80;\n\tv2274 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2273, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2284 = Il2CppMethodInfo;\n\tv2285 = v2284 + 0xC70;\n\tv2286 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2285, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2300 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv2301 = v2300 + 0xA38;\n\tv2302 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2301, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2322 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv2323 = v2322 + 0xA48;\n\tv2324 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2323, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2338 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv2339 = v2338 + 0xA40;\n\tv2340 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2339, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2345 = \"cp420\";\n\tv2346 = v2345 + 0xCC8;\n\tv2347 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2346, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv2361 = \"papayawhip\";\n\tv2362 = v2361 + 0xA28;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v2362, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302AA3F]) = v70;\nL_0090:\n\tv76 = 0;\n\tv82 = this.<>4__this;\n\tv87 = this.<>1__state == 2;\n\tif (v87) goto L_022D;\n\tv99 = this.<>1__state == 1;\n\tif (v99) goto L_0116;\n\tv111 = this.<>1__state == 0;\n\tv112 = ~v111;\n\tif (v112) goto L_0663;\n\tv121 = this + 0x40;\n\tthis.<>8__1.<>4__this = v82;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv124 = 0xF3F1B4(v121, v82, v254, v54, v351, v348, v57, v58, v59, v525, v61, v427, v63, v64, v65, v66);\n\tv255 = this + 0x50;\n\treturnVal1 = FluidSolver::TryGetPowerUp(v82, this.rootId, v255);\n\tv291 = ~returnVal1;\n\tif (v291) goto L_0663;\n\tv1283 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv1285 = new *([v1283 @ X23_v33 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tv1301 = Il2CppMethodInfo;\n\t\n// ... truncated")]
		private unsafe bool MoveNext()
		{
			//IL_0a13: Expected I, but got O
			//IL_0063: Expected O, but got I
			//IL_033f: Expected I, but got O
			//IL_0a88: Expected O, but got I
			//IL_0a97: Expected O, but got I
			//IL_0b15: Expected O, but got I
			//IL_00d6: Expected I, but got O
			//IL_038d: Expected O, but got I
			//IL_0110: Expected O, but got I
			//IL_1cdc: Expected O, but got I
			//IL_1cf1: Expected O, but got I
			//IL_0216: Expected O, but got I
			//IL_0cf6: Expected I, but got O
			//IL_0f6e: Expected I, but got O
			//IL_0f9e: Expected O, but got I
			//IL_024a: Expected O, but got I
			//IL_2422: Expected O, but got I
			//IL_1d53: Expected I, but got O
			//IL_1576: Unknown result type (might be due to invalid IL or missing references)
			//IL_157b: Expected O, but got Unknown
			//IL_1583: Expected F4, but got O
			//IL_1593: Expected F4, but got I
			//IL_15a0: Expected F4, but got O
			//IL_15b5: Expected F4, but got I
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Expected O, but got Unknown
			//IL_1e03: Expected O, but got I
			//IL_0d5b: Expected O, but got I
			//IL_1399: Expected O, but got I
			//IL_0dbc: Expected O, but got I
			//IL_2317: Expected I, but got O
			//IL_12a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a8: Expected O, but got Unknown
			//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ea: Expected O, but got Unknown
			//IL_0e07: Expected O, but got I
			//IL_2083: Expected O, but got I4
			//IL_1068: Unknown result type (might be due to invalid IL or missing references)
			//IL_106d: Expected O, but got Unknown
			//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_10af: Expected O, but got Unknown
			//IL_06b8: Expected O, but got F4
			//IL_06cc: Expected O, but got F4
			//IL_1449: Expected O, but got I
			//IL_2014: Expected O, but got F4
			//IL_236d: Expected O, but got F4
			//IL_134a: Expected O, but got F8
			//IL_0e3b: Expected O, but got I
			//IL_110b: Expected O, but got I4
			//IL_1121: Expected O, but got I
			//IL_19d7: Expected O, but got I
			//IL_0769: Expected O, but got F4
			//IL_077d: Expected O, but got F4
			//IL_18ce: Expected O, but got I4
			//IL_0e88: Expected O, but got I
			//IL_212c: Expected I4, but got O
			//IL_1b47: Expected O, but got I
			//IL_11fb: Expected O, but got I
			//IL_120b: Expected O, but got I
			//IL_0848: Unknown result type (might be due to invalid IL or missing references)
			//IL_084d: Expected O, but got Unknown
			//IL_08be: Expected O, but got F4
			//IL_08cb: Expected O, but got F4
			//IL_21e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_21e7: Expected O, but got Unknown
			//IL_21f4: Expected O, but got F8
			//IL_1be1: Expected O, but got I
			global::System.Collections.Generic.List<int>.Enumerator enumerator = default(global::System.Collections.Generic.List<int>.Enumerator);
			FluidSolver fluidSolver = _003C_003E4__this;
			bool flag3;
			int num3;
			float time2;
			bool flag5;
			bool flag6 = default(bool);
			int num6 = default(int);
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					bool flag2 = !flag;
					flag3 = false;
					if (!flag2)
					{
						_003C_003E8__1._003C_003E4__this = fluidSolver;
						_003C_003E1__state = -1;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
						flag3 = fluidSolver.TryGetPowerUp(rootId, out *(PowerUp*)((nint)this + 80));
						if (flag3)
						{
							global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>(fluidSolver.ActiveCount);
							nint num2 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1301 @ X8_v180 (Il2CppMethodInfo)+978]");
							num3 = 0;
							_003Ccohort_003E5__3 = hashSet;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
							if (fluidSolver.ActiveCount >= 1)
							{
								nint num4 = 0;
								int num5 = 0;
								do
								{
									global::Unity.Collections.NativeArray<int> particleIds = fluidSolver.particleIds;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X24_v29 (Il2CppMethodInfo)+980]");
									num3 = 0;
									global::System.Collections.Generic.HashSet<int> hashSet2 = _003Ccohort_003E5__3;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ X8_v185 (Unity.Collections.NativeArray`1<System.Int32>)+v590 @ X22_v35 (System.Int32)*4]");
									bool flag4 = hashSet2.Add(0);
									num5++;
								}
								while (num5 < fluidSolver.ActiveCount);
							}
							float halfThickness = fluidSolver.destroyBandThickness * 0.5f;
							_003C_003E8__1.halfThickness = halfThickness;
							float time = global::UnityEngine.Time.time;
							_003CstartTime_003E5__4 = time;
							global::System.Collections.Generic.HashSet<int> hashSet3 = new global::System.Collections.Generic.HashSet<int>();
							_003CprevFrame_003E5__5 = hashSet3;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
							global::System.Collections.Generic.HashSet<int> hashSet4 = new global::System.Collections.Generic.HashSet<int>();
							_003Cfading_003E5__6 = hashSet4;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
							time2 = global::UnityEngine.Time.time;
							flag5 = false;
							goto IL_02a3;
						}
					}
					goto IL_218a;
				}
				_003C_003E1__state = -1;
				time2 = global::UnityEngine.Time.time;
				flag5 = flag6;
				num3 = num6;
				goto IL_02a3;
			}
			_003C_003E1__state = -1;
			float time3 = global::UnityEngine.Time.time;
			float num7 = time3 - _003CstartDet_003E5__10;
			bool flag7 = !(num7 < fluidSolver.destroyDuration);
			bool flag8 = flag6;
			if (!flag7)
			{
				goto IL_09b6;
			}
			goto IL_0f0f;
			IL_0f60:
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator2 = _003Cfading_003E5__6.GetEnumerator();
			FluidSolver fluidSolver2 = default(FluidSolver);
			float num13 = default(float);
			int num15;
			object obj8 = default(object);
			int num18 = default(int);
			object obj17;
			float num12;
			if (list != null)
			{
				nint num9 = 0;
				nint num10 = 0;
				nint num11 = 0;
				num12 = num13;
				object obj6 = default(object);
				object obj7 = default(object);
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					if ((int)((nint)obj6 & 1) == 0)
					{
						break;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1958 @ X27_v18 (Il2CppMethodInfo)+C28]");
					flag8 = false;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num14 = (int)((nint)obj7 & 1);
					bool flag9 = num14 == 0;
					num15 = (int)(nint)obj8;
					if (flag9)
					{
						continue;
					}
					int num16 = (int)((nint)obj8 << 4);
					object obj9 = fluidSolver2.emissionColors + num16;
					float deltaTime = global::UnityEngine.Time.deltaTime;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v140+C]");
					num12 = 0f - deltaTime;
					int num17 = (int)((nint)obj8 << 4);
					object obj10 = fluidSolver2.emissionColors + num17;
					bool flag10 = num12 < 0f;
					bool flag11 = !flag10;
					bool flag12 = num12 == 0f;
					bool flag13 = !flag12;
					if (flag11 && flag13)
					{
						_ = 5.263544247E-315;
						_ = 0;
						num15 = (int)(nint)obj8;
						continue;
					}
					obj10 = 0;
					_ = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1962 @ X28_v15 (Il2CppMethodInfo)+410]");
					object obj11 = 0;
					int version = list._version + 1;
					list._version = version;
					int[] items = list._items;
					if (list._items != null)
					{
						int count = list.Count;
						if (list.Count < items.Length)
						{
							int size = list.Count + 1;
							list._size = size;
							items[count] = num18;
							num15 = (int)(nint)obj8;
						}
						else
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2248 @ X8_v143+20]");
							object obj12 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2290 @ X8_v144+C0]");
							object obj13 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2057 @ X8_v145+70]");
							num15 = 0;
							list.Add(num18);
						}
						continue;
					}
					goto IL_235c;
				}
			}
			else
			{
				nint num19 = 0;
				nint num20 = 0;
				num12 = num13;
				object obj14 = default(object);
				object obj15 = default(object);
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					if (obj14 == null)
					{
						break;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1966 @ X26_v23 (Il2CppMethodInfo)+C28]");
					flag8 = false;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					bool flag14 = obj15 == null;
					num15 = (int)(nint)obj8;
					if (flag14)
					{
						continue;
					}
					int num21 = (int)((nint)obj8 << 4);
					object obj16 = fluidSolver2.emissionColors + num21;
					float deltaTime2 = global::UnityEngine.Time.deltaTime;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X8_v134+C]");
					num12 = 0f - deltaTime2;
					int num22 = (int)((nint)obj8 << 4);
					obj17 = fluidSolver2.emissionColors + num22;
					bool flag15 = num12 < 0f;
					bool flag16 = !flag15;
					bool flag17 = num12 == 0f;
					bool flag18 = !flag16;
					if (!(flag18 || flag17))
					{
						obj17 = 5.263544247E-315;
						_ = 0;
						num15 = (int)(nint)obj8;
						continue;
					}
					goto IL_207a;
				}
			}
			nint num23 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			global::System.Collections.Generic.List<int>.Enumerator enumerator3 = list.GetEnumerator();
			nint num24 = 0;
			fluidSolver2 = (FluidSolver)((nint)0 + (nint)2440);
			nint num25 = 0;
			num6 = num15;
			int num26 = default(int);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X20_v12 (Il2CppMethodInfo)+988]");
				num26 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				if (_003Cfading_003E5__6 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2236 @ X23_v26 (Il2CppMethodInfo)+9A0]");
					num6 = 0;
					bool flag19 = _003Cfading_003E5__6.Remove(0);
					continue;
				}
				goto IL_2003;
			}
			enumerator.Dispose();
			global::System.Collections.Generic.HashSet<int> hashSet5;
			_003CprevFrame_003E5__5 = hashSet5;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			int num27 = 1;
			goto IL_2416;
			IL_207a:
			obj17 = 0;
			_ = 0;
			goto IL_235c;
			IL_1fe0:
			throw new global::System.NullReferenceException();
			IL_09b6:
			float time4 = global::UnityEngine.Time.time;
			float num28 = time4 - _003CstartDet_003E5__10;
			float num29 = fluidSolver.destroyRadius;
			float num30 = num28 / fluidSolver.destroyDuration;
			float num31 = fluidSolver.destroyRadius * num30;
			global::System.Collections.Generic.HashSet<int> hashSet6 = new global::System.Collections.Generic.HashSet<int>();
			global::System.Collections.Generic.HashSet<int> hashSet7 = new global::System.Collections.Generic.HashSet<int>();
			bool flag20 = fluidSolver.ActiveCount < 1;
			float num33 = 0f;
			num12 = num31;
			global::System.Collections.Generic.HashSet<int> particleIds2 = hashSet7;
			ref global::System.Collections.Generic.HashSet<int> reference3;
			ref global::System.Collections.Generic.HashSet<int> reference4 = default(ref global::System.Collections.Generic.HashSet<int>);
			if (!flag20)
			{
				ref FluidSolver._003C_003Ec__DisplayClass183_0 reference = ref *(FluidSolver._003C_003Ec__DisplayClass183_0*)((nint)this + 48);
				global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = fluidSolver.octopusHeadMidpoints;
				ref global::System.Collections.Generic.HashSet<int> reference2 = ref *(global::System.Collections.Generic.HashSet<int>*)((nint)this + 120);
				object obj20 = default(object);
				object obj19 = obj20;
				reference3 = ref reference4;
				global::System.Collections.Generic.HashSet<int> dehoneyedParticleIds = hashSet7;
				int num34 = 0;
				num33 = 0f;
				num12 = num31;
				global::Unity.Mathematics.float2 pos = default(global::Unity.Mathematics.float2);
				object obj22 = default(object);
				int num38 = default(int);
				CollectionManager collectionManager = default(CollectionManager);
				while (true)
				{
					global::Unity.Collections.NativeArray<int> particleIds3 = fluidSolver.particleIds;
					global::System.Collections.Generic.HashSet<int> hashSet8 = _003Ccohort_003E5__3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v26 (Unity.Collections.NativeArray`1<System.Int32>)+v470 @ X28_v8 (System.Int32)*4]");
					global::System.Collections.Generic.HashSet<int> hashSet12;
					int num40;
					if (hashSet8.Contains(0))
					{
						global::System.Collections.Generic.HashSet<int> hashSet9 = _003Cprocessed_003E5__8;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v26 (Unity.Collections.NativeArray`1<System.Int32>)+v470 @ X28_v8 (System.Int32)*4]");
						if (!hashSet9.Contains(0))
						{
							global::Unity.Collections.NativeArray<int> powerUpIds = fluidSolver.powerUpIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1885 @ X8_v27 (Unity.Collections.NativeArray`1<System.Int32>)+v470 @ X28_v8 (System.Int32)*4]");
							if ((nint)0 != rootId)
							{
								int num35 = num34 << 3;
								object obj21 = fluidSolver.positions + num35;
								num12 = (float)obj21;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v30+4]");
								num33 = 0f;
								pos.x = (float)obj21;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v30+4]");
								pos.y = 0f;
								bool flag21 = fluidSolver._003CRadialDestroyRoutine_003Eg__ShouldHitAtPosition_007C183_0(pos, num31, ref reference);
								bool flag22 = !flag21;
								num29 = num31;
								if (!flag22)
								{
									global::System.Collections.Generic.HashSet<int> hashSet10 = _003Cprocessed_003E5__8;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v26 (Unity.Collections.NativeArray`1<System.Int32>)+v470 @ X28_v8 (System.Int32)*4]");
									bool flag23 = hashSet10.Add(0);
									nint num36 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2108 @ X8_v33 (Il2CppMethodInfo)+C28]");
									flag8 = false;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
									bool flag24 = obj22 == null;
									num29 = num31;
									if (!flag24)
									{
										global::Unity.Collections.NativeArray<int> powerUpIds2 = fluidSolver.powerUpIds;
										int num37 = num38 << 2;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X9_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
										if ((uint)((nuint)0u + (nuint)1u) != 0)
										{
											global::System.Collections.Generic.HashSet<int> hashSet11 = _003Ctriggered_003E5__9;
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X9_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
											bool flag25 = hashSet11.Add(0);
											bool flag26 = !flag25;
											num29 = num31;
											if (!flag26)
											{
												global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X9_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
												fluidSolver.RadialDestroy(0);
												num29 = num31;
											}
										}
										else
										{
											global::Unity.Collections.NativeArray<int> octopusIds = fluidSolver.octopusIds;
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X9_v12 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
											if ((int)((nint)0 + (nint)1) == 0)
											{
												global::Unity.Collections.NativeArray<int> caterpillarIds = fluidSolver.caterpillarIds;
												global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ X9_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
												object obj23 = (nint)0 + (nint)1;
												bool flag27 = obj23 == null;
												num29 = num31;
												if (flag27)
												{
													global::Unity.Collections.NativeArray<int> beeIds = fluidSolver.beeIds;
													global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X9_v15 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
													if ((uint)((nuint)0u + (nuint)1u) != 0)
													{
														global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X9_v15 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
														fluidSolver.OnHitBeeParticle(num38, 0, ref dehoneyedParticleIds, ref reference2);
														obj19 = 0;
														reference3 = ref reference2;
														num29 = num31;
														flag8 = dehoneyedParticleIds != null;
													}
													else
													{
														global::Unity.Collections.NativeArray<int> clumpIds = fluidSolver.clumpIds;
														global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v16 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
														object obj24 = (nint)0 + (nint)1;
														if (obj24 != null)
														{
															global::System.Collections.Generic.List<Clump> clumps = fluidSolver.clumps;
															int num39 = 0;
															while (true)
															{
																bool flag28 = num39 >= clumps.Count;
																num29 = num31;
																if (flag28)
																{
																	break;
																}
																Clump clump = clumps[num39];
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v16 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
																if (0 != (nint)clump)
																{
																	num39++;
																	clumps = fluidSolver.clumps;
																	if (fluidSolver.clumps != null)
																	{
																		continue;
																	}
																	goto IL_1a93;
																}
																Clump clump2 = fluidSolver.clumps[num39];
																fluidSolver.RemoveClump(clump2);
																num29 = num31;
																flag8 = false;
																break;
															}
														}
														else
														{
															global::Unity.Collections.NativeArray<bool> isHoneyCoated = fluidSolver.isHoneyCoated;
															global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2280 @ X8_v47 (Unity.Collections.NativeArray`1<System.Boolean>)+v358 @ stack_-FC_v8 (System.Int32)]");
															if ((nint)0 != 0)
															{
																hashSet12 = hashSet7;
																goto IL_24a3;
															}
															global::Unity.Collections.NativeArray<int> fishIds = fluidSolver.fishIds;
															global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2296 @ X8_v50 (Unity.Collections.NativeArray`1<System.Int32>)+v358 @ stack_-FC_v8 (System.Int32)*4]");
															object obj25 = (nint)0 + (nint)1;
															bool flag29 = obj25 == null;
															bool flag30 = !flag29;
															num29 = num31;
															if (!flag30)
															{
																global::Unity.Collections.NativeArray<bool> isWater = fluidSolver.isWater;
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2319 @ X8_v52 (Unity.Collections.NativeArray`1<System.Boolean>)+v358 @ stack_-FC_v8 (System.Int32)]");
																bool flag31 = (nint)0 == 0;
																bool flag32 = !flag31;
																num29 = num31;
																if (!flag32)
																{
																	global::Unity.Collections.NativeArray<int> spongeIds = fluidSolver.spongeIds;
																	global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2337 @ X8_v54 (Unity.Collections.NativeArray`1<System.Int32>)+v358 @ stack_-FC_v8 (System.Int32)*4]");
																	object obj26 = (nint)0 + (nint)1;
																	bool flag33 = obj26 == null;
																	bool flag34 = !flag33;
																	num29 = num31;
																	if (!flag34)
																	{
																		hashSet12 = hashSet6;
																		goto IL_24a3;
																	}
																}
															}
														}
													}
												}
											}
											else
											{
												global::System.Collections.Generic.List<Octopus> octopi = fluidSolver.octopi;
												num40 = 0;
												while (true)
												{
													bool flag35 = num40 >= octopi.Count;
													num29 = num31;
													if (flag35)
													{
														break;
													}
													Octopus octopus = octopi[num40];
													int id = octopus.id;
													global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X9_v12 (Unity.Collections.NativeArray`1<System.Int32>)+v957 @ X8_v35 (System.Int32)]");
													if ((nint)id != 0)
													{
														num40++;
														octopi = fluidSolver.octopi;
														if (fluidSolver.octopi == null)
														{
															goto end_IL_14a0;
														}
														continue;
													}
													goto IL_17f3;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_146e;
					IL_1a93:
					flag8 = false;
					break;
					IL_146e:
					num34++;
					if (num34 < fluidSolver.ActiveCount)
					{
						continue;
					}
					goto IL_1c20;
					IL_24a3:
					global::System.Collections.Generic.HashSet<int> hashSet13 = hashSet12;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v26 (Unity.Collections.NativeArray`1<System.Int32>)+v470 @ X28_v8 (System.Int32)*4]");
					bool flag36 = hashSet13.Add(0);
					num29 = num31;
					goto IL_146e;
					IL_17f3:
					Octopus octopus2 = fluidSolver.octopi[num40];
					if (octopus2.splitIndex >= 1)
					{
						Octopus octopus3 = fluidSolver.octopi[num40];
						octopus3.Split();
						num29 = num31;
					}
					else
					{
						nint num41 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
						Octopus octopus4 = fluidSolver.octopi[num40];
						global::Unity.Mathematics.float2 float5 = nativeParallelHashMap[octopus4.id];
						global::UnityEngine.Vector2 pos2 = float5;
						num33 = pos2.y;
						collectionManager.OnCollectOctopus(pos2);
						Octopus octopus5 = fluidSolver.octopi[num40];
						fluidSolver.RemoveOctopus(octopus5);
						num29 = num31;
						num12 = pos2.x;
					}
					goto IL_146e;
					continue;
					end_IL_14a0:
					break;
				}
				goto IL_1fe0;
			}
			goto IL_2236;
			IL_1fe6:
			float prevR;
			_003C_003E8__1.prevR = prevR;
			num27 = 2;
			goto IL_2416;
			IL_2236:
			fluidSolver.RemoveHoneyCoating(particleIds2);
			bool flag37 = hashSet6.Count < 1;
			num6 = 0;
			if (!flag37)
			{
				global::System.Collections.IEnumerator routine = fluidSolver.HandleRemove(hashSet6);
				global::UnityEngine.Coroutine coroutine = fluidSolver.StartCoroutine(routine);
				reference4 = ref *(global::System.Collections.Generic.HashSet<int>*)null;
				num12 = 0.2f;
				flag8 = true;
				num6 = 0;
			}
			nint num42 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v24+78]");
			object obj27 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v19+F8]");
			object obj28 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X21_v9+18]");
			int num43 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X21_v9+18]");
			bool flag38 = (nint)0 < (nint)1;
			prevR = num31;
			if (!flag38)
			{
				ref FluidSolver._003C_003Ec__DisplayClass183_0 reference5 = ref *(FluidSolver._003C_003Ec__DisplayClass183_0*)((nint)this + 48);
				nint num44 = 0;
				float num46 = num29;
				float num47 = num33;
				float num48 = num12;
				global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
				while (true)
				{
					num43--;
					global::UnityEngine.Object obj29 = (global::UnityEngine.Object)((global::System.Collections.Generic.List<object>)obj28)[num43];
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1914 @ X26_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
					object obj30 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X0_v28+E0]");
					if ((nint)0 != 0)
					{
						bool flag39 = obj29 == null;
						bool flag40 = !flag39;
						bool flag41 = !flag40;
						num6 = 0;
						if (flag41)
						{
							goto IL_1d93;
						}
					}
					else
					{
						bool flag42 = obj29 == null;
						bool flag43 = !flag42;
						bool flag44 = !flag43;
						num6 = 0;
						if (flag44)
						{
							goto IL_1d93;
						}
					}
					global::UnityEngine.Component component = (global::UnityEngine.Component)((global::System.Collections.Generic.List<object>)obj28)[num43];
					global::UnityEngine.Transform transform = component.transform;
					global::UnityEngine.Vector3 position = transform.position;
					vector.x = position.x;
					vector.y = position.y;
					global::Unity.Mathematics.float2 pos3 = vector;
					num47 = pos3.y;
					bool flag45 = fluidSolver._003CRadialDestroyRoutine_003Eg__ShouldHitAtPosition_007C183_0(pos3, num31, ref reference5);
					bool flag46 = !flag45;
					num46 = num31;
					num48 = pos3.x;
					num6 = 0;
					if (!flag46)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1913 @ X25_v7 (Il2CppMethodInfo)+828]");
						num6 = 0;
						Block block = (Block)((global::System.Collections.Generic.List<object>)obj28)[num43];
						bool flag47 = (object)block == null;
						bool flag48 = !flag47;
						prevR = num31;
						num29 = num31;
						num12 = pos3.x;
						if (!flag48)
						{
							break;
						}
						block.OnPowerUpHit();
						num46 = num31;
						num48 = pos3.x;
					}
					goto IL_1d93;
					IL_1d93:
					bool flag49 = num43 <= 0;
					prevR = num31;
					num29 = num46;
					num33 = num47;
					num12 = num48;
					if (!flag49)
					{
						continue;
					}
					goto IL_1fe6;
				}
				goto IL_1fe0;
			}
			goto IL_1fe6;
			IL_1c20:
			reference4 = ref reference3;
			particleIds2 = hashSet7;
			goto IL_2236;
			IL_218a:
			return flag3;
			IL_2003:
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			object obj31 = num13;
			int num49 = 0;
			num12 = num13;
			flag8 = flag5;
			num6 = num3;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ X8_v151 (Il2CppMethodInfo)+970]");
			num26 = 0;
			global::System.NullReferenceException ex2 = default(global::System.NullReferenceException);
			ex = ex2;
			fluidSolver2 = fluidSolver;
			goto IL_2094;
			IL_02a3:
			num29 = fluidSolver.chargeDuration;
			float num50 = time2 - _003CstartTime_003E5__4;
			if (num50 < fluidSolver.chargeDuration)
			{
				PowerUp powerUp = _003Croot_003E5__2;
				global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
				vector2.x = powerUp.position.x;
				vector2.y = powerUp.position.y;
				global::Unity.Mathematics.float2 float6 = vector2;
				hashSet5 = new global::System.Collections.Generic.HashSet<int>();
				bool flag50 = fluidSolver.ActiveCount < 1;
				num33 = float6.y;
				if (!flag50)
				{
					nint num52 = 0;
					float num54 = default(float);
					float num53 = num54;
					int num55 = 0;
					int num56 = 0;
					float num57 = fluidSolver.chargeDuration;
					float num58 = float6.y;
					bool flag51 = flag5;
					object obj38 = default(object);
					object obj39 = default(object);
					bool flag67;
					do
					{
						global::Unity.Collections.NativeArray<int> particleIds4 = fluidSolver.particleIds;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X27_v23 (Il2CppMethodInfo)+990]");
						num3 = 0;
						global::System.Collections.Generic.HashSet<int> hashSet14 = _003Ccohort_003E5__3;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X8_v155 (Unity.Collections.NativeArray`1<System.Int32>)+v484 @ X26_v31 (System.Int32)*4]");
						if (hashSet14.Contains(0))
						{
							global::Unity.Collections.NativeArray<int> powerUpIds3 = fluidSolver.powerUpIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1559 @ X8_v156 (Unity.Collections.NativeArray`1<System.Int32>)+v484 @ X26_v31 (System.Int32)*4]");
							if ((nint)0 != rootId)
							{
								object obj33 = fluidSolver.positions + num56;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
								if ((nint)0 == 0)
								{
									_ = 1;
								}
								num58 = (float)obj33 - float6.x;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1764 @ X8_v159+4]");
								float num59 = 0f - float6.y;
								float num60 = num58 * num58;
								float num61 = num59 * num59;
								float f = num60 + num61;
								num57 = global::UnityEngine.Mathf.Sqrt(f);
								num53 = fluidSolver.destroyRadius;
								if (!(num57 > fluidSolver.destroyRadius))
								{
									PowerUp powerUp2 = _003Croot_003E5__2;
									float num62;
									float num63;
									if (powerUp2.mergeIndex != 1)
									{
										bool flag52 = powerUp2.mergeIndex == 0;
										bool flag53 = !flag52;
										num62 = num57;
										num63 = num58;
										if (!flag53)
										{
											float num64 = global::UnityEngine.Mathf.Abs(num59);
											num58 = _003C_003E8__1.halfThickness;
											if (_003C_003E8__1.halfThickness < num64)
											{
												goto IL_03d4;
											}
											num62 = num57;
											num63 = _003C_003E8__1.halfThickness;
										}
									}
									else
									{
										float num65 = global::UnityEngine.Mathf.Abs(num59);
										num57 = _003C_003E8__1.halfThickness;
										float num66 = _003C_003E8__1.halfThickness - num65;
										bool flag54 = num66 < 0f;
										object obj34 = _003C_003E8__1.halfThickness ^ num65;
										object obj35 = _003C_003E8__1.halfThickness ^ num66;
										int num67 = (int)((nint)obj34 & (nint)obj35);
										bool flag55 = num67 < 0;
										float num68 = global::UnityEngine.Mathf.Abs(num58);
										bool flag56;
										bool flag57;
										if (flag54 != flag55)
										{
											float num69 = _003C_003E8__1.halfThickness - num68;
											flag56 = num69 < 0f;
											object obj36 = _003C_003E8__1.halfThickness ^ num68;
											object obj37 = _003C_003E8__1.halfThickness ^ num69;
											int num70 = (int)((nint)obj36 & (nint)obj37);
											flag57 = num70 < 0;
										}
										else
										{
											flag57 = false;
											flag56 = false;
										}
										bool flag58 = flag56 == flag57;
										bool flag59 = !flag58;
										num62 = num57;
										num63 = num58;
										if (flag59)
										{
											goto IL_03d4;
										}
									}
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X8_v155 (Unity.Collections.NativeArray`1<System.Int32>)+v484 @ X26_v31 (System.Int32)*4]");
									bool flag60 = hashSet5.Add(0);
									nint num71 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2141 @ X8_v169 (Il2CppMethodInfo)+C28]");
									flag51 = false;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
									bool flag61 = obj38 == null;
									num57 = num62;
									num58 = num63;
									num3 = (int)(nint)obj39;
									if (!flag61)
									{
										int num72 = (int)((nint)obj39 << 4);
										object obj40 = fluidSolver.emissionColors + num72;
										float deltaTime3 = global::UnityEngine.Time.deltaTime;
										float num73 = deltaTime3 * 0.5f;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2193 @ X8_v172+C]");
										float num74 = 0f + num73;
										float num75 = num74 - 1f;
										bool flag62 = num75 < 0f;
										bool flag63 = num75 == 0f;
										object obj41 = num74 ^ 1f;
										object obj42 = num74 ^ num75;
										int num76 = (int)((nint)obj41 & (nint)obj42);
										bool flag64 = num76 < 0;
										bool flag65 = flag62 == flag64;
										bool flag66 = !flag63;
										num58 = ((!(flag65 && flag66)) ? num74 : 1f);
										int num77 = (int)((nint)obj39 << 4);
										object obj43 = fluidSolver.emissionColors + num77;
										obj43 = 5.263544247E-315;
										if (num74 < 0f)
										{
											float num78 = 0f;
										}
										else
										{
											float num78 = num58;
										}
										_ = 0;
										num57 = num62;
										num3 = (int)(nint)obj39;
									}
								}
							}
						}
						goto IL_03d4;
						IL_03d4:
						num55++;
						num56 += 8;
						flag67 = num55 >= fluidSolver.ActiveCount;
						num29 = num57;
						num33 = num58;
						flag5 = flag51;
					}
					while (!flag67);
				}
				global::System.Collections.Generic.HashSet<int>.Enumerator enumerator4 = _003CprevFrame_003E5__5.GetEnumerator();
				if (hashSet5 != null)
				{
					nint num79 = 0;
					nint num80 = 0;
					nint num81 = 0;
					num15 = num3;
					object obj45 = default(object);
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
						if ((int)((nint)obj45 & 1) == 0)
						{
							break;
						}
						bool flag68 = hashSet5.Contains(num18);
						bool flag69 = !flag68;
						bool flag70 = !flag69;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1518 @ X26_v28 (Il2CppMethodInfo)+990]");
						num15 = 0;
						if (flag70)
						{
							continue;
						}
						if (_003Cfading_003E5__6 != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X27_v21 (Il2CppMethodInfo)+980]");
							num15 = 0;
							bool flag71 = _003Cfading_003E5__6.Add(num18);
							continue;
						}
						goto IL_205b;
					}
				}
				else
				{
					nint num82 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					num15 = num3;
				}
				nint num83 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				flag8 = flag5;
				fluidSolver2 = fluidSolver;
				goto IL_0f60;
			}
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator5 = _003CprevFrame_003E5__5.GetEnumerator();
			nint num84 = 0;
			object obj46 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj46 & 1) == 0)
				{
					break;
				}
				fluidSolver.ClearHighlight(num18);
			}
			nint num85 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator6 = _003Cfading_003E5__6.GetEnumerator();
			object obj47 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj47 & 1) == 0)
				{
					break;
				}
				fluidSolver.ClearHighlight(num18);
			}
			nint num86 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			PowerUp powerUp3 = _003Croot_003E5__2;
			global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
			vector3.x = powerUp3.position.x;
			vector3.y = powerUp3.position.y;
			global::Unity.Mathematics.float2 float7 = (global::Unity.Mathematics.float2)(_003C_003E8__1 = (FluidSolver._003C_003Ec__DisplayClass183_0)(global::Unity.Mathematics.float2)vector3);
			_003C_003E8__1.origin.y = float7.y;
			PowerUp powerUp4 = _003Croot_003E5__2;
			_003C_003E8__1.bandType = powerUp4.mergeIndex;
			nint num87 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			nint num88 = (nint)typeof(CollectParticleData[]);
			AudioClipSettings settings = new AudioClipSettings
			{
				volume = 0.5f,
				pitch = 1f,
				pitchVariance = 0.1f
			};
			string text = "cp420";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v90 (System.String)+CC8]");
			AudioManager audioManager = default(AudioManager);
			audioManager.PlayClip((string)0, settings);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			AudioClipSettings settings2 = new AudioClipSettings
			{
				pitchVariance = 0.2f,
				volume = 0.1f
			};
			string text2 = "papayawhip";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2325 @ X8_v93 (System.String)+A28]");
			AudioManager audioManager2 = default(AudioManager);
			audioManager2.PlayClip((string)0, settings2);
			global::System.Action<PowerUp> onDetonatePowerUp = fluidSolver.OnDetonatePowerUp;
			if (fluidSolver.OnDetonatePowerUp != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2341.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			global::TapticPlugin.TapticManager.Impact(global::TapticPlugin.ImpactFeedback.Heavy);
			fluidSolver.RemovePowerUp(rootId);
			global::System.Collections.Generic.HashSet<int> hashSet15 = new global::System.Collections.Generic.HashSet<int>();
			_003CdehoneyedBeeIds_003E5__7 = hashSet15;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::System.Collections.Generic.HashSet<int> hashSet16 = new global::System.Collections.Generic.HashSet<int>();
			_003Cprocessed_003E5__8 = hashSet16;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::System.Collections.Generic.HashSet<int> hashSet17 = new global::System.Collections.Generic.HashSet<int>();
			nint num90 = 0;
			bool flag72 = hashSet17.Add(rootId);
			_003Ctriggered_003E5__9 = hashSet17;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			float time5 = global::UnityEngine.Time.time;
			_003CstartDet_003E5__10 = time5;
			_003C_003E8__1.prevR = 0f;
			float time6 = global::UnityEngine.Time.time;
			float num91 = time6 - _003CstartDet_003E5__10;
			bool flag73 = num91 < fluidSolver.destroyDuration;
			flag8 = false;
			if (flag73)
			{
				goto IL_09b6;
			}
			goto IL_0f0f;
			IL_2094:
			bool flag74 = num26 != 1;
			global::System.NullReferenceException ex3 = ex;
			if (!flag74)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
				nint num92 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1931 @ X8_v112 (Il2CppMethodInfo)+968]");
				num26 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				object obj51 = default(object);
				bool flag75 = obj51 == null;
				num15 = num6;
				if (flag75)
				{
					goto IL_0f60;
				}
				global::System.OutOfMemoryException ex4 = new global::System.OutOfMemoryException();
				num49 = (int)obj51;
				ex3 = (global::System.NullReferenceException)(object)ex4;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
			bool result = default(bool);
			return result;
			IL_205b:
			global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
			obj31 = enumerator;
			num49 = 0;
			goto IL_2094;
			IL_0f0f:
			flag3 = false;
			goto IL_218a;
			IL_235c:
			global::System.NullReferenceException ex6 = new global::System.NullReferenceException();
			obj31 = num13;
			num49 = 0;
			num12 = num13;
			flag8 = flag5;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1518 @ X26_v28 (Il2CppMethodInfo)+990]");
			num6 = 0;
			num26 = num18;
			ex = ex5;
			fluidSolver2 = fluidSolver;
			goto IL_2094;
			IL_2416:
			_003C_003E2__current = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = num27;
			flag3 = true;
			goto IL_218a;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1009588", Offset = "0x1009588", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xD98;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			throw new global::System.NotSupportedException();
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200009F")]
	private sealed class _003CSpawnMergedPowerUp_003Ed__168 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400036B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400036C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400036D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float delay;

		[global::Cpp2ILInjected.Token(Token = "0x400036E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public FluidSolver _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400036F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public global::UnityEngine.Vector2 pos;

		[global::Cpp2ILInjected.Token(Token = "0x4000370")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int layer;

		[global::Cpp2ILInjected.Token(Token = "0x4000371")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public bool isBig;

		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x10096E0", Offset = "0x10096E0", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1009728", Offset = "0x1009728", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x10095D0", Offset = "0x10095D0", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CSpawnMergedPowerUp_003Ed__168(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10095FC", Offset = "0x10095FC", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1009600", Offset = "0x1009600", Length = "0xE0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv25 = System.Xml.ValidateNames;\n\tv26 = v25 + 0x258;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv45 = 1;\n\t*([302AA40]) = v45;\nL_0017:\n\tv47 = this.<>1__state == 0;\n\tif (v47) goto L_0037;\n\tv57 = this.<>1__state != 1;\n\tif (v57) goto L_004C;\n\tthis.<>1__state = 0xFFFFFFFF;\n\t// 42 MakeStruct v69 @ AGG100965C_0_v2 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), this.pos (UnityEngine.Vector2), this.pos.y (System.Single)\n\tv70 = Unity.Mathematics.float2::op_Implicit(v69);\n\tv108 = FluidSolver::AddPowerUp(this.<>4__this, v70, this.layer, this.isBig);\n\tgoto L_004C;\nL_0037:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv60 = System.Xml.ValidateNames;\n\tv63 = new *([v60 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v63, this.delay);\n\tv163 = this + 0x18;\n\tthis.<>2__current = v63;\n\tv107 = 0xF3F1B4(v163, v63, v29, v30, v31, v32, v33, v34, this.delay, v36, v37, v38, v39, v40, v41, v42);\n\tthis.<>1__state = 1;\nL_004C:\n\tv119 = this.<>1__state == 0;\n\treturn v119;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 67 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_00a9: Expected I, but got O
			//IL_00ca: Expected O, but got I
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
					vector.x = pos.x;
					vector.y = pos.y;
					global::Unity.Mathematics.float2 float5 = vector;
					PowerUp powerUp = _003C_003E4__this.AddPowerUp(float5, layer, isBig);
				}
			}
			else
			{
				_003C_003E1__state = -1;
				global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(delay);
				_003C_003E2__current = waitForSeconds;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x10096E8", Offset = "0x10096E8", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xDA0;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			throw new global::System.NotSupportedException();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool isClumped;

	[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int maxParticles;

	[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int maxTypeBatches;

	[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int colorFluidTypes;

	[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int mudFluidType;

	[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int snowFluidType;

	[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int honeyFluidType;

	[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::System.Collections.Generic.HashSet<int> usedFluidTypes;

	[global::UnityEngine.Space(5f)]
	[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float viscosityStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float pressureMultiplier;

	[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float nearPressureMultiplier;

	[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float targetDensity;

	[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float buoyancyStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float waterReactionMultiplier;

	[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float splashDownStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int powerUpThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int bigPowerUpThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float particleRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public float particleMass;

	[global::Cpp2ILInjected.Token(Token = "0x40002C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float alphaFadePerSecond;

	[global::UnityEngine.Header("Multi‑fluid")]
	[global::Cpp2ILInjected.Token(Token = "0x40002C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float interFluidRepelStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float honeyRepelStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public float clumpRepelStrength;

	[global::UnityEngine.Header("Explosion Settings")]
	[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public float destroyBandThickness;

	[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public float destroyRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public float destroyDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float chargeDuration;

	[global::UnityEngine.Header("Chain Reaction Settings")]
	[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public float chainDelay;

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private int _003CActiveCount_003Ek__BackingField;

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	private float _003ClastStepWallTime_003Ek__BackingField;

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private float _003ClastStepDt_003Ek__BackingField;

	[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positionsPrev;

	[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

	[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> densities;

	[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> gravities;

	[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public global::Unity.Collections.NativeArray<int> particleTypes;

	[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public global::Unity.Collections.NativeArray<int> particleIds;

	[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public global::Unity.Collections.NativeArray<int> powerUpIds;

	[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public global::Unity.Collections.NativeArray<int> fishIds;

	[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public global::Unity.Collections.NativeArray<int> clumpIds;

	[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4> emissionColors;

	[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public global::Unity.Collections.NativeArray<float> scales;

	[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public global::Unity.Collections.NativeArray<bool> isSimulated;

	[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public global::Unity.Collections.NativeArray<bool> isHoneyCoated;

	[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public global::Unity.Collections.NativeArray<float> waterDensities;

	[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public global::Unity.Collections.NativeArray<float> splashImpulse;

	[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public global::Unity.Collections.NativeArray<bool> isStatic;

	[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public global::Unity.Collections.NativeArray<float> viscosityStrengths;

	[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public global::Unity.Collections.NativeArray<float> nearPressureMultipliers;

	[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public global::Unity.Collections.NativeHashMap<int, int> idToIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	private global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	private int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	private global::Unity.Jobs.JobHandle _lastJob;

	[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public PowerUp powerUpPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public global::UnityEngine.Material[] powerUpMaterials;

	[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public global::System.Collections.Generic.List<PowerUp> powerUps;

	[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	private readonly global::System.Collections.Generic.Dictionary<int, PowerUp> powerUpById;

	[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> OnRemoveHoneyCoating;

	[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public global::System.Action<global::System.Collections.Generic.HashSet<int>> OnAddParticles;

	[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> OnStartRemoveParticles;

	[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public global::System.Action<global::System.Collections.Generic.HashSet<int>, global::UnityEngine.Vector2> OnCreatePowerup;

	[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public global::System.Action<bool, global::UnityEngine.Vector2> OnRemoveRegionStart;

	[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public global::System.Action<global::System.Collections.Generic.HashSet<int>, int> OnRemoveRegionComplete;

	[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public global::System.Action<PowerUp> OnDetonatePowerUp;

	[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	private readonly global::System.Collections.Generic.Queue<int> explosionQueue;

	[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	private bool isProcessing;

	[global::UnityEngine.Header("Power-ups")]
	[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x294")]
	public float powerUpCohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public float powerUpSpringStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29C")]
	public float clumpCohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public float clumpSpringStrength;

	[global::UnityEngine.Header("Fish")]
	[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A4")]
	public float fishCohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public float fishSpringStrength;

	[global::UnityEngine.Header("Octopi")]
	[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2AC")]
	public float octopusHeadCohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public float octopusHeadSpringStrength;

	[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B4")]
	public int octopusHeadParticleCount;

	[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public float octopusBodyCohesionForce;

	[global::Cpp2ILInjected.Token(Token = "0x4000300")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public global::Unity.Collections.NativeArray<int> octopusIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000301")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public global::Unity.Collections.NativeArray<bool> inOctopusHead;

	[global::Cpp2ILInjected.Token(Token = "0x4000302")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public global::System.Collections.Generic.List<Octopus> octopi;

	[global::Cpp2ILInjected.Token(Token = "0x4000303")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	private global::Unity.Collections.NativeArray<bool> regionHasHead;

	[global::Cpp2ILInjected.Token(Token = "0x4000304")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public global::Unity.Collections.NativeArray<int> caterpillarIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000305")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> caterpillarMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000306")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public global::System.Collections.Generic.List<Caterpillar> caterpillars;

	[global::Cpp2ILInjected.Token(Token = "0x4000307")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public global::Unity.Collections.NativeArray<int> beeIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000308")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> beeMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000309")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public global::System.Collections.Generic.List<Bee> bees;

	[global::UnityEngine.Header("Sponges")]
	[global::Cpp2ILInjected.Token(Token = "0x400030A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public global::System.Collections.Generic.List<Sponge> sponges;

	[global::Cpp2ILInjected.Token(Token = "0x400030B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public global::Unity.Collections.NativeArray<int> spongeIds;

	[global::Cpp2ILInjected.Token(Token = "0x400030C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public float spongeCohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x400030D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x364")]
	public float spongeSpringStrength;

	[global::Cpp2ILInjected.Token(Token = "0x400030E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Cpp2ILInjected.Token(Token = "0x400030F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> powerUpMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000310")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> fishMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000311")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> clumpMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000312")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> spongeMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000313")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> octopusHeadMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000314")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	private global::Unity.Collections.NativeArray<int> octUFParent;

	[global::Cpp2ILInjected.Token(Token = "0x4000315")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	private global::Unity.Collections.NativeArray<byte> octComponentHasHead;

	[global::Cpp2ILInjected.Token(Token = "0x4000316")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E8")]
	private readonly global::System.Collections.Generic.HashSet<int> _pendingRemovalIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000317")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F0")]
	private global::Unity.Collections.NativeHashMap<ulong, byte> ignorePairs;

	[global::UnityEngine.Header("Power-up Merging")]
	[global::Cpp2ILInjected.Token(Token = "0x4000318")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x400")]
	public float powerUpMergeDistance;

	[global::Cpp2ILInjected.Token(Token = "0x4000319")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x404")]
	public float mergeDuration;

	[global::Cpp2ILInjected.Token(Token = "0x400031A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x408")]
	private readonly global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData> merging;

	[global::Cpp2ILInjected.Token(Token = "0x400031B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x410")]
	private global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> mergeDeltas;

	[global::Cpp2ILInjected.Token(Token = "0x400031C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x420")]
	public readonly global::System.Collections.Generic.HashSet<int> exploding;

	[global::Cpp2ILInjected.Token(Token = "0x400031D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x428")]
	public global::System.Collections.Generic.List<Honey> honeys;

	[global::Cpp2ILInjected.Token(Token = "0x400031E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x430")]
	public FluidCompute compute;

	[global::Cpp2ILInjected.Token(Token = "0x400031F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x438")]
	public global::System.Collections.Generic.List<Clump> clumps;

	[global::UnityEngine.Header("Fish Blob")]
	[global::Cpp2ILInjected.Token(Token = "0x4000320")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x440")]
	public Fish fishPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x4000321")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x448")]
	public global::UnityEngine.Material fishMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x4000322")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x450")]
	public global::System.Collections.Generic.List<Fish> fishes;

	[global::Cpp2ILInjected.Token(Token = "0x4000323")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x458")]
	public global::Unity.Mathematics.float2 defaultGravity;

	[global::Cpp2ILInjected.Token(Token = "0x4000324")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x460")]
	public global::Unity.Mathematics.float2 fishGravity;

	[global::Cpp2ILInjected.Token(Token = "0x4000325")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x468")]
	private float _nextFishZ;

	[global::Cpp2ILInjected.Token(Token = "0x4000326")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x470")]
	public global::System.Action OnStep;

	[global::Cpp2ILInjected.Token(Token = "0x4000327")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x478")]
	public Mud mudInstance;

	[global::Cpp2ILInjected.Token(Token = "0x4000328")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x480")]
	public Snow snowInstance;

	[global::Cpp2ILInjected.Token(Token = "0x4000329")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x488")]
	public float splashDestroyRadius;

	[global::Cpp2ILInjected.Token(Token = "0x400032A")]
	public const float goldenConstant = 137.508f;

	[global::Cpp2ILInjected.Token(Token = "0x400032B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x490")]
	private global::System.Collections.IEnumerator rejectFlash;

	[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
	public int ActiveCount
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFEE5C", Offset = "0xFFEE5C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<ActiveCount>k__BackingField;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return ActiveCount;
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFEE64", Offset = "0xFFEE64", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.<ActiveCount>k__BackingField = value;\n\treturn;\n")]
		private set
		{
			_003CActiveCount_003Ek__BackingField = value;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
	public float lastStepWallTime
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600026D")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFEE6C", Offset = "0xFFEE6C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<lastStepWallTime>k__BackingField;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return lastStepWallTime;
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFEE74", Offset = "0xFFEE74", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.<lastStepWallTime>k__BackingField = value;\n\treturn;\n")]
		private set
		{
			_003ClastStepWallTime_003Ek__BackingField = value;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
	public float lastStepDt
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFEE7C", Offset = "0xFFEE7C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<lastStepDt>k__BackingField;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return lastStepDt;
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFEE84", Offset = "0xFFEE84", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.<lastStepDt>k__BackingField = value;\n\treturn;\n")]
		private set
		{
			_003ClastStepDt_003Ek__BackingField = value;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000271")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF670C", Offset = "0xFF670C", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v0);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void LastJobComplete()
	{
		//IL_000c: Expected O, but got I
		_lastJob.Complete();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000272")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFEE8C", Offset = "0xFFEE8C", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturnVal1 = b | a;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static ulong PairKey(int a, int b)
	{
		//IL_000d: Expected I8, but got I4
		return (ulong)(b | a);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000273")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFEE98", Offset = "0xFFEE98", Length = "0x88C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = &v25 @ stack_-10_v2;\n\tv40 = Il2CppMethodInfo;\n\tv42 = Il2CppMethodInfo;\n\tgoto L_0049;\n\tv49 = Il2CppMethodInfo;\n\tv50 = v49 + 0x980;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv78 = Il2CppMethodInfo;\n\tv79 = v78 + 0xB58;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv87 = Il2CppMethodInfo;\n\tv88 = v87 + 0xA68;\n\tv89 = \"il2cpp_codegen_initialize_runtime_metadata\"(v88, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv96 = Il2CppMethodInfo;\n\tv97 = v96 + 0xAE8;\n\tv98 = \"il2cpp_codegen_initialize_runtime_metadata\"(v97, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv105 = Il2CppMethodInfo;\n\tv106 = v105 + 0xA80;\n\tv107 = \"il2cpp_codegen_initialize_runtime_metadata\"(v106, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv114 = Il2CppMethodInfo;\n\tv115 = v114 + 0xB40;\n\tv116 = \"il2cpp_codegen_initialize_runtime_metadata\"(v115, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv123 = Il2CppMethodInfo;\n\tv124 = v123 + 0xAB8;\n\tv125 = \"il2cpp_codegen_initialize_runtime_metadata\"(v124, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv132 = Il2CppMethodInfo;\n\tv133 = v132 + 0xC08;\n\tv134 = \"il2cpp_codegen_initialize_runtime_metadata\"(v133, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv142 = Il2CppMethodInfo;\n\tv143 = v142 + 0xC40;\n\tv144 = \"il2cpp_codegen_initialize_runtime_metadata\"(v143, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv152 = Il2CppMethodInfo;\n\tv153 = v152 + 0xC78;\n\tv154 = \"il2cpp_codegen_initialize_runtime_metadata\"(v153, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv162 = Il2CppMethodInfo;\n\tv163 = v162 + 0xCA8;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v163, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302A9FE]) = v70;\nL_0049:\n\t;\n\t*([v24 @ X29_v1-68]) = 0;\n\t*([v24 @ X29_v1-60]) = 0;\n\tv75 = &v25 @ stack_-10_v2 - 0x68;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::.ctor(v75, this.maxParticles, 4, 1);\n\tthis.positions = *([v24 @ X29_v1-68]);\n\t*([v24 @ X29_v1-78]) = 0;\n\t*([v24 @ X29_v1-70]) = 0;\n\tv84 = &v25 @ stack_-10_v2 - 0x78;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::.ctor(v84, this.maxParticles, 4, 1);\n\tthis.positionsPrev = *([v24 @ X29_v1-78]);\n\t*([v24 @ X29_v1-88]) = 0;\n\t*([v24 @ X29_v1-80]) = 0;\n\tv93 = &v25 @ stack_-10_v2 - 0x88;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::.ctor(v93, this.maxParticles, 4, 1);\n\tthis.predicted = *([v24 @ X29_v1-88]);\n\t*([v24 @ X29_v1-98]) = 0;\n\t*([v24 @ X29_v1-90]) = 0;\n\tv102 = &v25 @ stack_-10_v2 - 0x98;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::.ctor(v102, this.maxParticles, 4, 1);\n\tthis.velocities = *([v24 @ X29_v1-98]);\n\t*([v24 @ X29_v1-A8]) = 0;\n\t*([v24 @ X29_v1-A0]) = 0;\n\tv111 = &v25 @ stack_-10_v2 - 0xA8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::.ctor(v111, this.maxParticles, 4, 1);\n\tthis.densities = *([v24 @ X29_v1-A8]);\n\t*([v24 @ X29_v1-B8]) = 0;\n\t*([v24 @ X29_v1-B0]) = 0;\n\tv120 = &v25 @ stack_-10_v2 - 0xB8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::.ctor(v120, this.maxParticles, 4, 1);\n\tthis.deltaVel = *([v24 @ X29_v1-B8]);\n\t*([v24 @ X29_v1-C8]) = 0;\n\t*([v24 @ X29_v1-C0]) = 0;\n\tv129 = &v25 @ stack_-10_v2 - 0xC8;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(v129, this.maxParticles, 4, 1);\n\tthis.particleTypes = *([v24 @ X29_v1-C8]);\n\t*([v24 @ X29_v1-D8]) = 0;\n\t*([v24 @ X29_v1-D0]) = 0;\n\tv139 = &v25 @ stack_-10_v2 - 0xD8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float4>::.ctor(v139, this.maxParticles, 4, 1);\n\tthis.emissionColors = *([v24 @ X29_v1-D8]);\n\t*([v24 @ X29_v1-E8]) = 0;\n\t*([v24 @ X29_v1-E0]) = 0;\n\tv149 = &v25 @ stack_-10_v2 - 0xE8;\n\tUnity.Collections.NativeArray`1<System.Single>::.ctor(v149, this.maxParticles, 4, 1);\n\tthis.scales = *([v24 @ X29_v1-E8]);\n\t*([v24 @ X29_v1-F8]) = 0;\n\t*([v24 @ X29_v1-F0]) = 0;\n\tv159 = &v25 @ stack_-10_v2 - 0xF8;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(v159, this.maxParticles, 4, 1);\n\tthis.particleIds = *([v24 @ X29_v1-F8]);\n\tv167 = 0;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(&v167 @ stack_-118_v1 (Unity.Collections.NativeArray`1<System.Int32>), this.maxParticles, 4, 1);\n\tv174 = &v175 @ stack_-217;\n\tthis.powerUpIds = *([v174 @ X9_v1+FF]);\n\tv178 = 0;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(&v178 @ stack_-128_v1 (Unity.Collections.NativeArray`1<System.Int32>), this.maxParticles, 4, 1);\n\tv185 = &v186 @ stack_-227;\n\tthis.fishIds = *([v185 @ X9_v2+FF]);\n\tv189 = 0;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(&v189 @ stack_-138_v1 (Unity.Collections.NativeArray`1<System.Int32>), this.maxParticles, 4, 1);\n\tv196 = &v197 @ stack_-237;\n\tthis.clumpIds = *([v196 @ X9_v3+FF]);\n\tv200 = 0;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(&v200 @ stack_-148_v1 (Unity.Collections.NativeArray`1<System.Int32>), this.maxParticles, 4, 1);\n\tv206 = &v207 @ stack_-247;\n\tthis.octopusIds = *([v206 @ X8_v10+FF]);\n\tv210 = 0;\n\tUnity.Collections.NativeArray`1<System.Boolean>::.ctor(&v210 @ stack_-158_v1 (Unity.Collections.NativeArray`1<System.Boolean>), this.maxParticles, 4, 1);\n\tv216 = &v217 @ stack_-257;\n\tthis.inOctopusHead = *([v216 @ X8_v11+FF]);\n\tv220 = 0;\n\tUnity.Collections.NativeArray`1<System.Boolean>::.ctor(&v220 @ stack_-168_v1 (Unity.Collections.NativeArray`1<System.Boolean>), this.maxParticles, 4, 1);\n\tv227 = &v228 @ stack_-267;\n\tthis.regionHasHead = *([v227 @ X9_v4+FF]);\n\tv231 = 0;\n\tUnity.Collections.NativeArray`1<System.Boolean>::.ctor(&v231 @ stack_-178_v1 (Unity.Collections.NativeArray`1<System.Boolean>), this.maxParticles, 4, 1);\n\tv238 = &v239 @ stack_-277;\n\tthis.isWater = *([v238 @ X9_v5+FF]);\n\tv242 = 0;\n\tUnity.Collections.NativeArray`1<System.Boolean>::.ctor(&v242 @ stack_-188_v1 (Unity.Collections.NativeArray`1<System.Boolean>), this.maxParticles, 4, 1);\n\tv249 = &v250 @ stack_-287;\n\tthis.isHoneyCoated = *([v249 @ X9_v6+FF]);\n\tv253 = 0;\n\tUnity.Collections.NativeArray`1<System.Single>::.ctor(&v253 @ stack_-198_v1 (Unity.Collections.NativeArray`1<System.Single>), this.maxParticles, 4, 1);\n\tv260 = &v261 @ stack_-297;\n\tthis.waterDensities = *([v260 @ X9_v7+FF]);\n\tv264 = 0;\n\tUnity.Collections.NativeArray`1<System.Int32>::.ctor(&v264 @ stack_-1A8_v1 (Unity.Collections.NativeArray`1<System.Int32>), this.maxParticles, 4, 1);\n\tv270 = &v271 @ stack_-2A7;\n\tthis.spongeIds = *([v270 @ X8_v16+FF]);\n\tv274 = 0;\n\tUnity.Collections.NativeArray`1<System.Single>::.ctor(&v274 @ stack_-1B8_v1 (Unity.Collections.NativeArray`1<System.Single>), this.maxParticles, 4, 1);\n\tv281 = &v282 @ stack_-2B7;\n\tthis.splashImpulse = *([v281 @ X9_v8+FF]);\n\tv285 = 0;\n\tUnity.Collections.NativeArray`1<System.Single>::.ctor(&v285 @ stack_-1C8_v1 (Unity.Collections.NativeArray`1<System.Single>), this.maxParticles, 4, 1);\n\tv292 = &v293 @ stack_-2C7;\n\tthis.viscosityStrengths = *([v292 @ X9_v9+FF]);\n\tv296 = 0;\n\tUnity.Collections.NativeArray`1<System.Single>::.ctor(&v296 @ stack_-1D8_v1 (Unity.Collections.NativeArray`1<System.Single>), this.maxParticles, 4, 1);\n\tv303 = &v304 @ stack_-2D7;\n\tthis.nearPressureMultipliers = *([v303 @ X9_v10+FF]);\n\tv309 = Unity.Collections.AllocatorManager+AllocatorHandle::op_Implicit(4);\n\tv310 = 0;\n\tUnity.Collections.NativeHashMap`2::.ctor /* +1 sharing this address */(&v310 @ stack_-1E8_v1, this.maxParticles, v309, *([v40 @ X22_v1 (Il2CppMethodInfo)+C08]));\n\tv317 = &v318 @ stack_-2E7;\n\tthis.idToIndex = *([v317 @ X9_v11+FF]);\n\tv321 = this.maxParticles - 1;\n\tv322 = v321 | v321;\n\tv323 = v322 | v322;\n\tv324 = v323 | v323;\n\tv325 = v324 | v324;\n\tv326 = v325 | v325;\n\tv327 = v326 + 1;\n\tthis.capacity = v327;\n\tv330 = Unity.Collections.AllocatorManager+AllocatorHandle::op_Implicit(4);\n\tUnity.Collections.N\n// ... truncated")]
	private unsafe void Awake()
	{
		//IL_09ad: Expected O, but got I
		//IL_09c1: Expected native int or pointer, but got O
		//IL_09d8: Expected O, but got I
		//IL_09f3: Expected O, but got I
		//IL_0a07: Expected native int or pointer, but got O
		//IL_0a1e: Expected O, but got I
		//IL_0a39: Expected O, but got I
		//IL_0a4d: Expected native int or pointer, but got O
		//IL_0031: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_0060: Expected native int or pointer, but got O
		//IL_0077: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a6: Expected native int or pointer, but got O
		//IL_00c2: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00f1: Expected native int or pointer, but got O
		//IL_0108: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0137: Expected native int or pointer, but got O
		//IL_0153: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_0182: Expected native int or pointer, but got O
		//IL_0199: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01c8: Expected native int or pointer, but got O
		//IL_01e4: Expected O, but got I
		//IL_01ff: Expected O, but got I
		//IL_0213: Expected native int or pointer, but got O
		//IL_022a: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_0328: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_03a7: Expected O, but got I
		//IL_03e9: Expected O, but got I
		//IL_0426: Expected O, but got I
		//IL_0468: Expected O, but got I
		//IL_04a5: Expected O, but got I
		//IL_04e7: Expected O, but got I
		//IL_0524: Expected O, but got I
		//IL_0566: Expected O, but got I
		//IL_057d: Expected O, but got I4
		//IL_05a6: Expected O, but got I
		positions = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		positionsPrev = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		predicted = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		velocities = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		densities = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		deltaVel = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		particleTypes = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		emissionColors = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		scales = new global::Unity.Collections.NativeArray<float>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		particleIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		powerUpIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		fishIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		clumpIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		octopusIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		inOctopusHead = new global::Unity.Collections.NativeArray<bool>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		regionHasHead = new global::Unity.Collections.NativeArray<bool>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		isWater = new global::Unity.Collections.NativeArray<bool>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		isHoneyCoated = new global::Unity.Collections.NativeArray<bool>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		waterDensities = new global::Unity.Collections.NativeArray<float>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		spongeIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		splashImpulse = new global::Unity.Collections.NativeArray<float>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		viscosityStrengths = new global::Unity.Collections.NativeArray<float>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		nearPressureMultipliers = new global::Unity.Collections.NativeArray<float>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		idToIndex = new global::Unity.Collections.NativeHashMap<int, int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		int num3 = maxParticles - 1;
		int num4 = num3 | num3;
		int num5 = num4 | num4;
		int num6 = num5 | num5;
		int num7 = num6 | num6;
		int num8 = num7 | num7;
		int num9 = num8 + 1;
		capacity = num9;
		cellMap = new global::Unity.Collections.NativeMultiHashMap<int, int>(capacity, global::Unity.Collections.Allocator.Persistent);
		powerUpMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		fishMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		caterpillarIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		caterpillarMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		beeIds = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		beeMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		clumpMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		spongeMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		octopusHeadMidpoints = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		ignorePairs = new global::Unity.Collections.NativeHashMap<ulong, byte>(128, global::Unity.Collections.Allocator.Persistent);
		mergeDeltas = new global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>(128, global::Unity.Collections.Allocator.Persistent);
		gravities = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		isStatic = new global::Unity.Collections.NativeArray<bool>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		octUFParent = new global::Unity.Collections.NativeArray<int>(maxParticles, global::Unity.Collections.Allocator.Persistent, default(global::Unity.Collections.NativeArrayOptions));
		octComponentHasHead = new global::Unity.Collections.NativeArray<byte>(maxParticles, global::Unity.Collections.Allocator.Persistent);
		ActiveCount = 0;
		if (colorFluidTypes >= 1)
		{
			int num10 = 0;
			do
			{
				bool flag = usedFluidTypes.Add(num10);
				num10++;
			}
			while (num10 < colorFluidTypes);
		}
		bool flag2 = usedFluidTypes.Add(mudFluidType);
		bool flag3 = usedFluidTypes.Add(snowFluidType);
		bool flag4 = usedFluidTypes.Add(honeyFluidType);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000274")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFF724", Offset = "0xFFF724", Length = "0x2F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv38 = Il2CppMethodInfo;\n\tv40 = Il2CppMethodInfo;\n\tgoto L_0045;\n\tv49 = Il2CppMethodInfo;\n\tv50 = v49 + 0xAC0;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv73 = Il2CppMethodInfo;\n\tv74 = v73 + 0xA88;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv78 = Il2CppMethodInfo;\n\tv79 = v78 + 0xB50;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv83 = Il2CppMethodInfo;\n\tv84 = v83 + 0xAF0;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv88 = Il2CppMethodInfo;\n\tv89 = v88 + 0xB60;\n\tv90 = \"il2cpp_codegen_initialize_runtime_metadata\"(v89, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv93 = Il2CppMethodInfo;\n\tv94 = v93 + 0xA70;\n\tv95 = \"il2cpp_codegen_initialize_runtime_metadata\"(v94, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0xC10;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv103 = Il2CppMethodInfo;\n\tv104 = v103 + 0xC50;\n\tv105 = \"il2cpp_codegen_initialize_runtime_metadata\"(v104, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv108 = Il2CppMethodInfo;\n\tv109 = v108 + 0xC88;\n\tv110 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv113 = Il2CppMethodInfo;\n\tv114 = v113 + 0xCC0;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v114, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302A9FF]) = v70;\nL_0045:\n\tv71 = this + 0xA8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v71);\n\tv76 = this + 0xB8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v76);\n\tv81 = this + 0xC8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v81);\n\tv86 = this + 0xD8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v86);\n\tv91 = this + 0xE8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v91);\n\tv96 = this + 0xF8;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v96);\n\tv101 = this + 0x118;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v101);\n\tv106 = this + 0x168;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float4>::Dispose(v106);\n\tv111 = this + 0x178;\n\tUnity.Collections.NativeArray`1<System.Single>::Dispose(v111);\n\tv115 = this + 0x128;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v115);\n\tv117 = this + 0x138;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v117);\n\tv119 = this + 0x148;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v119);\n\tv121 = this + 0x158;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v121);\n\tv123 = this + 0x1F8;\n\tUnity.Collections.NativeHashMap`2::Dispose /* +1 sharing this address */(v123, *([v38 @ X28_v1 (Il2CppMethodInfo)+C10]));\n\tv125 = this + 0x208;\n\tUnity.Collections.NativeMultiHashMap`2::Dispose /* +1 sharing this address */(v125, *([v40 @ X27_v1 (Il2CppMethodInfo)+CC0]));\n\tv127 = this + 0x378;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v127);\n\tv129 = this + 0x388;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v129);\n\tv131 = this + 0x2C0;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v131);\n\tv133 = this + 0x2D0;\n\tUnity.Collections.NativeArray`1<System.Boolean>::Dispose(v133);\n\tv135 = this + 0x3F0;\n\tUnity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::Dispose(v135);\n\tv139 = this + 0x410;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v139);\n\tv141 = this + 0x2E8;\n\tUnity.Collections.NativeArray`1<System.Boolean>::Dispose(v141);\n\tv143 = this + 0x368;\n\tUnity.Collections.NativeArray`1<System.Boolean>::Dispose(v143);\n\tv145 = this + 0x350;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v145);\n\tv147 = this + 0x1D8;\n\tUnity.Collections.NativeArray`1<System.Single>::Dispose(v147);\n\tv149 = this + 0x1E8;\n\tUnity.Collections.NativeArray`1<System.Single>::Dispose(v149);\n\tv151 = this + 0x1B8;\n\tUnity.Collections.NativeArray`1<System.Single>::Dispose(v151);\n\tv153 = this + 0x3A8;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v153);\n\tv155 = this + 0x3B8;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v155);\n\tv157 = this + 0x398;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v157);\n\tv159 = this + 0x198;\n\tUnity.Collections.NativeArray`1<System.Boolean>::Dispose(v159);\n\tv161 = this + 0x1A8;\n\tUnity.Collections.NativeArray`1<System.Single>::Dispose(v161);\n\tv163 = this + 0x108;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Dispose(v163);\n\tv165 = this + 0x1C8;\n\tUnity.Collections.NativeArray`1<System.Boolean>::Dispose(v165);\n\tv167 = this + 0x3C8;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v167);\n\tv169 = this + 0x3D8;\n\tUnity.Collections.NativeArray`1<System.Byte>::Dispose(v169);\n\tv173 = this + 0x2F8;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v173);\n\tv175 = this + 0x308;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v175);\n\tv177 = this + 0x320;\n\tUnity.Collections.NativeArray`1<System.Int32>::Dispose(v177);\n\tv179 = this + 0x330;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Dispose(v179);\n\treturn;\n// 91 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void OnDestroy()
	{
		positions.Dispose();
		positionsPrev.Dispose();
		predicted.Dispose();
		velocities.Dispose();
		densities.Dispose();
		deltaVel.Dispose();
		particleTypes.Dispose();
		emissionColors.Dispose();
		scales.Dispose();
		particleIds.Dispose();
		powerUpIds.Dispose();
		fishIds.Dispose();
		clumpIds.Dispose();
		idToIndex.Dispose();
		cellMap.Dispose();
		powerUpMidpoints.Dispose();
		fishMidpoints.Dispose();
		octopusIds.Dispose();
		inOctopusHead.Dispose();
		ignorePairs.Dispose();
		mergeDeltas.Dispose();
		regionHasHead.Dispose();
		isWater.Dispose();
		spongeIds.Dispose();
		viscosityStrengths.Dispose();
		nearPressureMultipliers.Dispose();
		splashImpulse.Dispose();
		spongeMidpoints.Dispose();
		octopusHeadMidpoints.Dispose();
		clumpMidpoints.Dispose();
		isHoneyCoated.Dispose();
		waterDensities.Dispose();
		gravities.Dispose();
		isStatic.Dispose();
		octUFParent.Dispose();
		octComponentHasHead.Dispose();
		caterpillarIds.Dispose();
		caterpillarMidpoints.Dispose();
		beeIds.Dispose();
		beeMidpoints.Dispose();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000275")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFCE04", Offset = "0xFFCE04", Length = "0xCFC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv28 = &v29 @ stack_-10_v2;\n\tv35 = *([2C38708]);\n\t*([v28 @ X29_v1-70]) = *([v35 @ X8_v2]);\n\tv47 = Il2CppMethodInfo;\n\tgoto L_0098;\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0x1B8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv147 = Il2CppMethodInfo;\n\tv148 = v147 + 0x268;\n\tv149 = \"il2cpp_codegen_initialize_runtime_metadata\"(v148, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv151 = Il2CppMethodInfo;\n\tv152 = v151 + 0x270;\n\tv153 = \"il2cpp_codegen_initialize_runtime_metadata\"(v152, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv155 = Il2CppMethodInfo;\n\tv156 = v155 + 0x278;\n\tv157 = \"il2cpp_codegen_initialize_runtime_metadata\"(v156, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv159 = Il2CppMethodInfo;\n\tv160 = v159 + 0x280;\n\tv161 = \"il2cpp_codegen_initialize_runtime_metadata\"(v160, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv163 = Il2CppMethodInfo;\n\tv164 = v163 + 0x288;\n\tv165 = \"il2cpp_codegen_initialize_runtime_metadata\"(v164, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv167 = Il2CppMethodInfo;\n\tv168 = v167 + 0x290;\n\tv169 = \"il2cpp_codegen_initialize_runtime_metadata\"(v168, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv171 = Il2CppMethodInfo;\n\tv172 = v171 + 0x298;\n\tv173 = \"il2cpp_codegen_initialize_runtime_metadata\"(v172, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv175 = Il2CppMethodInfo;\n\tv176 = v175 + 0x2A0;\n\tv177 = \"il2cpp_codegen_initialize_runtime_metadata\"(v176, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv179 = Il2CppMethodInfo;\n\tv180 = v179 + 0x2A8;\n\tv181 = \"il2cpp_codegen_initialize_runtime_metadata\"(v180, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv184 = Il2CppMethodInfo;\n\tv185 = v184 + 0x2B0;\n\tv186 = \"il2cpp_codegen_initialize_runtime_metadata\"(v185, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv212 = Il2CppMethodInfo;\n\tv213 = v212 + 0x2B8;\n\tv214 = \"il2cpp_codegen_initialize_runtime_metadata\"(v213, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv219 = Il2CppMethodInfo;\n\tv220 = v219 + 0x2C0;\n\tv221 = \"il2cpp_codegen_initialize_runtime_metadata\"(v220, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv227 = Il2CppMethodInfo;\n\tv228 = v227 + 0x2C8;\n\tv229 = \"il2cpp_codegen_initialize_runtime_metadata\"(v228, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv242 = Il2CppMethodInfo;\n\tv243 = v242 + 0x2D0;\n\tv244 = \"il2cpp_codegen_initialize_runtime_metadata\"(v243, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv272 = Il2CppMethodInfo;\n\tv273 = v272 + 0x2D8;\n\tv274 = \"il2cpp_codegen_initialize_runtime_metadata\"(v273, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv280 = Il2CppMethodInfo;\n\tv281 = v280 + 0x2E0;\n\tv282 = \"il2cpp_codegen_initialize_runtime_metadata\"(v281, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv289 = Il2CppMethodInfo;\n\tv290 = v289 + 0x2E8;\n\tv291 = \"il2cpp_codegen_initialize_runtime_metadata\"(v290, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv303 = Il2CppMethodInfo;\n\tv304 = v303 + 0x2F0;\n\tv305 = \"il2cpp_codegen_initialize_runtime_metadata\"(v304, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv322 = Il2CppMethodInfo;\n\tv323 = v322 + 0x2F8;\n\tv324 = \"il2cpp_codegen_initialize_runtime_metadata\"(v323, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv352 = Il2CppMethodInfo;\n\tv353 = v352 + 0xB48;\n\tv354 = \"il2cpp_codegen_initialize_runtime_metadata\"(v353, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv386 = Il2CppMethodInfo;\n\tv387 = v386 + 0xA60;\n\tv388 = \"il2cpp_codegen_initialize_runtime_metadata\"(v387, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv460 = Il2CppMethodInfo;\n\tv461 = v460 + 0xCB0;\n\tv462 = \"il2cpp_codegen_initialize_runtime_metadata\"(v461, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv515 = Il2CppMethodInfo;\n\tv516 = v515 + 0xCB8;\n\tv517 = \"il2cpp_codegen_initialize_runtime_metadata\"(v516, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv542 = System.Runtime.Serialization.ObjectHolderList;\n\tv543 = v542 + 0xD20;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v543, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv74 = 1;\n\t*([302AA00]) = v74;\nL_0098:\n\t*([v28 @ X29_v1-80]) = 0;\n\t*([v28 @ X29_v1-78]) = 0;\n\tFluidSolver::UpdateFishMidpoints(this);\n\tFluidSolver::UpdatePowerUpMidpoints(this);\n\tFluidSolver::UpdateCaterpillarMidpoints(this);\n\tFluidSolver::UpdateBeeMidpoints(this);\n\tFluidSolver::UpdateOctopusHeadMidpoints(this);\n\tFluidSolver::UpdateSpongeMidpoints(this);\n\tFluidSolver::UpdateClumpMidpoints(this);\n\tFluidSolver::DetectPowerUpMerges(this);\n\tFluidSolver::UpdateMergeDeltasAndFinish(this);\n\tv183 = UnityEngine.Time::get_time();\n\tthis.<lastStepWallTime>k__BackingField = v183;\n\tthis.<lastStepDt>k__BackingField = v183;\n\tv188 = this.positions;\n\tv189 = this + 0xD8;\n\tv211 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v188 @ V0_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>), this.<ActiveCount>k__BackingField, 0x40, 0);\n\tUnity.Jobs.JobHandle::Complete(&v211 @ X0_v13 (Unity.Jobs.JobHandle));\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float2>::Copy(this.positions, *([this @ X0 (FluidSolver)+B0]));\n\tv231 = this + 0xF8;\n\tv241 = Unity.Jobs.IJobParallelForExtensions::Schedule(this.deltaVel, *([this @ X0 (FluidSolver)+100]), this.<ActiveCount>k__BackingField, 0x40);\n\tv247 = this.positions;\n\tv251 = v231 - 0x30;\n\tv256 = v231 + 0xD0;\n\tv271 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v247 @ V0_v4 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>), this.<ActiveCount>k__BackingField, 0x40, v241);\n\tv277 = v231 + 0x110;\n\tUnity.Collections.NativeMultiHashMap`2::Clear /* +1 sharing this address */(v277, *([v47 @ X25_v1 (Il2CppMethodInfo)+CB8]));\n\tv283 = this.predicted;\n\tgoto L_0132;\n\tv292 = \"il2cpp_codegen_runtime_class_init\"(v285, v278, v270, v245, v246, v266, v237, v63, v283, v248, v252, v253, v258, v68, v69, v70);\nL_0132:\n\tv298 = Il2CppMethodInfo;\n\tthis = Unity.Collections.NativeMultiHashMap`2::AsParallelWriter /* +1 sharing this address */(v277, *([v298 @ X8_v11 (Il2CppMethodInfo)+CB0]));\n\tv321 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v283 @ V0_v5 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>), this.<ActiveCount>k__BackingField, 0x40, v271);\n\tv183 = *([v251 @ X27_v1]);\n\tv351 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v183 @ V0_v2 (System.Single), this.<ActiveCount>k__BackingField, 0x40, v321);\n\tv183 = *([v251 @ X27_v1]);\n\tv385 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v183 @ V0_v2 (System.Single), this.<ActiveCount>k__BackingField, 0x40, v351);\n\tv183 = *([v251 @ X27_v1]);\n\tv459 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v183 @ V0_v2 (System.Single), this.<ActiveCount>k__BackingField, 0x40, v385);\n\tv183 = *([v251 @ X27_v1]);\n\t*([v28 @ X29_v1-80]) = this.fishIds;\n\tv514 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v183 @ V0_v2 (System.Single), this.<ActiveCount>k__BackingField, 0x40, v459);\n\tv520 = this.waterDensities;\n\tv541 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v520 @ V0_v25 (Unity.Collections.NativeArray`1<System.Single>), this.<ActiveCount>k__BackingField, 0x40, v514);\n\tv183 = *([v251 @ X27_v1]);\n\tv570 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v183 @ V0_v2 (System.Single), this.<ActiveCount>k__BackingField, 0x40, v541);\n\tv573 = this.positions;\n\tv597 = Unity.Jobs.IJobParallelForEx\n// ... truncated")]
	public unsafe void Step(float dt)
	{
		//IL_0018: Expected O, but got I
		//IL_008e: Expected O, but got I
		//IL_00b0: Expected O, but got Ref
		//IL_00d9: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0150: Expected O, but got Ref
		//IL_0168: Expected O, but got I
		//IL_0592: Expected O, but got Ref
		//IL_059e: Expected F4, but got O
		//IL_05b6: Expected O, but got Ref
		//IL_0189: Expected F4, but got O
		//IL_01a1: Expected O, but got Ref
		//IL_01ad: Expected F4, but got O
		//IL_01c5: Expected O, but got Ref
		//IL_01d6: Expected F4, but got O
		//IL_01f5: Expected O, but got Ref
		//IL_021b: Expected O, but got Ref
		//IL_022c: Expected F4, but got O
		//IL_0244: Expected O, but got Ref
		//IL_026a: Expected O, but got Ref
		//IL_0295: Expected O, but got Ref
		//IL_02bb: Expected O, but got Ref
		//IL_02e6: Expected O, but got Ref
		//IL_030c: Expected O, but got Ref
		//IL_0337: Expected O, but got Ref
		//IL_0351: Expected O, but got I
		//IL_0369: Expected O, but got Ref
		//IL_0394: Expected O, but got I4
		//IL_03a0: Expected F4, but got O
		//IL_03d7: Expected O, but got I4
		//IL_0412: Expected O, but got Ref
		//IL_0438: Expected O, but got Ref
		//IL_0463: Expected O, but got Ref
		//IL_046f: Expected F4, but got O
		//IL_04a6: Expected O, but got Ref
		//IL_04b6: Expected O, but got I
		//IL_04c5: Expected I8, but got O
		//IL_05cf: Expected O, but got I
		object obj2 = default(object);
		object obj = obj2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2C38708]");
		object obj3 = 0;
		nint num = 0;
		_ = 0;
		_ = 0;
		UpdateFishMidpoints();
		UpdatePowerUpMidpoints();
		UpdateCaterpillarMidpoints();
		UpdateBeeMidpoints();
		UpdateOctopusHeadMidpoints();
		UpdateSpongeMidpoints();
		UpdateClumpMidpoints();
		DetectPowerUpMerges();
		UpdateMergeDeltasAndFinish();
		float num2 = (lastStepDt = (lastStepWallTime = global::UnityEngine.Time.time));
		global::Unity.Jobs.IJobParallelForExtensions.Schedule(new PowerUpMergeTranslateJob
		{
			positions = positions,
			velocities = velocities,
			powerUpIds = powerUpIds,
			mergeDeltas = mergeDeltas,
			dt = dt
		}, ActiveCount, 64).Complete();
		global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2>.Copy(positions, positionsPrev);
		global::Unity.Jobs.JobHandle dependsOn = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new ClearDeltaJob
		{
			deltaVel = deltaVel
		}, 0, ActiveCount, default(global::Unity.Jobs.JobHandle));
		global::Unity.Jobs.JobHandle dependsOn2 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new PredictJob
		{
			positions = positions,
			velocities = velocities,
			predicted = predicted,
			gravities = gravities,
			isStatic = isStatic,
			dt = dt
		}, ActiveCount, 64, dependsOn);
		cellMap.Clear();
		global::Unity.Jobs.JobHandle dependsOn3 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new FixedRadiusNeighborSearchJob
		{
			positions = predicted,
			cellSize = particleRadius * 2f,
			capacity = capacity,
			cellMap = cellMap.AsParallelWriter()
		}, ActiveCount, 64, dependsOn2);
		global::Unity.Jobs.JobHandle dependsOn4 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new WaterDensityJob
		{
			predicted = predicted,
			cellMap = cellMap,
			isWater = isWater,
			waterDensities = waterDensities,
			mass = particleMass,
			capacity = capacity
		}, ActiveCount, 64, dependsOn3);
		global::Unity.Jobs.JobHandle dependsOn5 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new DensityJob
		{
			predicted = predicted,
			cellMap = cellMap,
			densities = densities,
			isWater = isWater,
			ignorePairs = ignorePairs,
			powerUpIds = powerUpIds,
			mass = particleMass,
			capacity = capacity
		}, ActiveCount, 64, dependsOn4);
		global::Unity.Jobs.JobHandle dependsOn6 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new PressureJob
		{
			predicted = predicted,
			densities = densities,
			cellMap = cellMap,
			particleTypes = particleTypes,
			isHoneyCoated = isHoneyCoated,
			ignorePairs = ignorePairs,
			powerUpIds = powerUpIds,
			isWater = isWater,
			clumpIds = clumpIds,
			fishIds = fishIds,
			nearPressureMultipliers = nearPressureMultipliers,
			deltaVel = deltaVel,
			interFluidRepelStr = interFluidRepelStrength,
			honeyRepelStr = honeyRepelStrength,
			clumpRepelStrength = clumpRepelStrength,
			waterReactionGlobal = waterReactionMultiplier,
			pressureMultiplier = pressureMultiplier,
			targetDensity = targetDensity,
			dt = dt,
			capacity = capacity
		}, ActiveCount, 64, dependsOn5);
		global::Unity.Jobs.JobHandle dependsOn7 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new ViscosityJob
		{
			predicted = predicted,
			velocities = velocities,
			cellMap = cellMap,
			particleTypes = particleTypes,
			ignorePairs = ignorePairs,
			powerUpIds = powerUpIds,
			isWater = isWater,
			deltaVel = deltaVel,
			viscosityStrengths = viscosityStrengths,
			dt = dt,
			capacity = capacity,
			waterReactionGlobal = waterReactionMultiplier,
			fishIds = fishIds
		}, ActiveCount, 64, dependsOn6);
		global::Unity.Jobs.JobHandle dependsOn8 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BuoyancyJob
		{
			waterDensities = waterDensities,
			isWater = isWater,
			fishIds = fishIds,
			deltaVel = deltaVel,
			buoyancyStrength = buoyancyStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn7);
		global::Unity.Jobs.JobHandle dependsOn9 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new SplashDownJob
		{
			predicted = predicted,
			isWater = isWater,
			cellMap = cellMap,
			deltaVel = deltaVel,
			splashDownStrength = splashDownStrength,
			capacity = capacity,
			dt = dt
		}, ActiveCount, 64, dependsOn8);
		global::Unity.Jobs.JobHandle dependsOn10 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			blobIds = fishIds,
			blobMidpoints = fishMidpoints,
			cohesionRadius = fishCohesionRadius,
			springStrength = fishSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn9);
		global::Unity.Jobs.JobHandle dependsOn11 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			blobIds = powerUpIds,
			blobMidpoints = powerUpMidpoints,
			cohesionRadius = powerUpCohesionRadius,
			springStrength = powerUpSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn10);
		global::Unity.Jobs.JobHandle dependsOn12 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			blobIds = spongeIds,
			blobMidpoints = spongeMidpoints,
			cohesionRadius = spongeCohesionRadius,
			springStrength = spongeSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn11);
		global::Unity.Jobs.JobHandle dependsOn13 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			blobIds = clumpIds,
			blobMidpoints = clumpMidpoints,
			cohesionRadius = clumpCohesionRadius,
			springStrength = clumpSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn12);
		global::Unity.Jobs.JobHandle dependsOn14 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			blobIds = fishIds,
			blobMidpoints = fishMidpoints,
			cohesionRadius = fishCohesionRadius,
			springStrength = fishSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn13);
		global::Unity.Jobs.JobHandle dependsOn15 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			blobIds = powerUpIds,
			blobMidpoints = powerUpMidpoints,
			cohesionRadius = powerUpCohesionRadius,
			springStrength = powerUpSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn14);
		global::Unity.Jobs.JobHandle jobHandle = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new OctopusHeadCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			octopusIds = octopusIds,
			inOctopusHead = inOctopusHead,
			octopusMidpoints = octopusHeadMidpoints,
			headCohesionRadius = octopusHeadCohesionRadius,
			headSpringStrength = octopusHeadSpringStrength,
			dt = dt
		}, ActiveCount, 64, dependsOn15);
		global::Unity.Jobs.JobHandle jobHandle2 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new OctUF_InitJob
		{
			parent = octUFParent
		}, 0, ActiveCount, default(global::Unity.Jobs.JobHandle));
		global::Unity.Jobs.JobHandle dependsOn16 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new ClearByteJob
		{
			array = octComponentHasHead
		}, 0, ActiveCount, default(global::Unity.Jobs.JobHandle));
		global::Unity.Jobs.JobHandle dependsOn17 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new OctUF_FlagHeadJob
		{
			parent = octUFParent,
			isHead = inOctopusHead.Reinterpret<byte>(),
			componentHasHead = octComponentHasHead
		}, ActiveCount, 64, dependsOn16);
		global::Unity.Jobs.JobHandle dependsOn18 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new OctUF_WriteRegionJob
		{
			parent = octUFParent,
			componentHasHead = octComponentHasHead,
			regionHasHead = regionHasHead
		}, ActiveCount, 64, dependsOn17);
		global::Unity.Jobs.JobHandle jobHandle3 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new OctopusBodyCohesionJob
		{
			positions = positions,
			deltaVel = deltaVel,
			regionHasHead = regionHasHead,
			octopusIds = octopusIds,
			octopusHeadMidpoints = octopusHeadMidpoints,
			bodyCohesionForce = octopusBodyCohesionForce,
			dt = dt
		}, ActiveCount, 64, dependsOn18);
		global::Unity.Jobs.JobHandle dependsOn19 = jobHandle3;
		global::Unity.Jobs.JobHandle jobHandle4 = global::Unity.Jobs.IJobParallelForExtensions.Schedule(new IntegrateJob
		{
			positions = positions,
			velocities = velocities,
			isStatic = isStatic,
			dt = dt
		}, ActiveCount, 64, dependsOn19);
		_lastJob.Complete();
		_lastJob = jobHandle4;
		global::System.Action onStep = OnStep;
		if (OnStep != null)
		{
			onStep();
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2C38708]");
		object obj10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X29_v1-70]");
		if (obj10 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A17C");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000276")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3F80", Offset = "0xFF3F80", Length = "0x348")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_0031;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x980;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, spawnPositions, type, onInit, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tv64 = Il2CppMethodInfo;\n\tv65 = v64 + 0x968;\n\tv66 = \"il2cpp_codegen_initialize_runtime_metadata\"(v65, spawnPositions, type, onInit, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tv69 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv70 = v69 + 0x5D8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, spawnPositions, type, onInit, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0xC20;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, spawnPositions, type, onInit, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tv78 = System.Xml.ValidateNames;\n\tv79 = v78 + 0xD40;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, spawnPositions, type, onInit, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tv196 = System.Xml.ValidateNames;\n\tv197 = v196 + 0xD58;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v197, spawnPositions, type, onInit, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tv61 = 1;\n\t*([302AA01]) = v61;\nL_0031:\n\tv63 = new *([v36 @ X23_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v63);\n\tv72 = this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v72);\n\tv168 = this.<ActiveCount>k__BackingField;\n\tv200 = this.maxParticles - this.<ActiveCount>k__BackingField;\n\tv87 = spawnPositions.Length - v200;\n\tv88 = v87 < 0;\n\tv90 = spawnPositions.Length ^ v200;\n\tv91 = spawnPositions.Length ^ v87;\n\tv92 = v90 & v91;\n\tv93 = v92 < 0;\n\tv94 = v88 == v93;\n\tv95 = ~v94;\n\tv96 = ~v95;\n\tif (v96) goto L_005A;\n\tgoto L_005A;\nL_005A:\n\tv137 = v200 < 1;\n\tif (v137) goto L_00F4;\n\tv283 = this + 0x1F8;\n\tv284 = spawnPositions + 0x20;\n\tgoto L_007E;\nL_0062:\n\tv133 = v133 + 1;\n\tv300 = v200 == v133;\n\tif (v300) goto L_00F2;\nL_007E:\n\tv194 = v168 + v133;\n\tv340 = this.positions;\n\tv191 = v194 << 3;\n\t*([v340 @ X8_v14 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = *([v284 @ X8_v11+v133 @ X24_v5 (System.Int32)*8]);\n\tv343 = this.positionsPrev;\n\t*([v343 @ X8_v15 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = *([v284 @ X8_v11+v133 @ X24_v5 (System.Int32)*8]);\n\tv344 = this.positions;\n\tv346 = this.predicted;\n\t*([v346 @ X9_v9 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = *([v344 @ X8_v16 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]);\n\tv347 = System.Xml.ValidateNames;\n\tv348 = *([v347 @ X10_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv349 = *([v348 @ X8_v18+B8]);\n\tv351 = this.velocities;\n\t*([v351 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = *([v349 @ X8_v19]);\n\tv352 = *([v347 @ X10_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv353 = *([v352 @ X8_v21+B8]);\n\tv355 = this.densities;\n\t*([v355 @ X9_v11 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = *([v353 @ X8_v22]);\n\tv356 = *([v347 @ X10_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv357 = *([v356 @ X8_v24+B8]);\n\tv359 = this.deltaVel;\n\t*([v359 @ X9_v12 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = *([v357 @ X8_v25]);\n\tv360 = this.particleTypes;\n\tv116 = v194 << 2;\n\t*([v360 @ X8_v27 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = type;\n\tv362 = System.Xml.ValidateNames;\n\tv364 = *([v362 @ X8_v28 (Il2CppClass<System.Xml.ValidateNames>)+D58]);\n\tv365 = *([v364 @ X8_v30+B8]);\n\tv366 = this.emissionColors;\n\t*([v366 @ X9_v14 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)+v194 @ X26_v6 (System.Int32)*16]) = *([v365 @ X8_v31]);\n\tv368 = this.scales;\n\t*([v368 @ X8_v32 (Unity.Collections.NativeArray`1<System.Single>)+v116 @ X27_v5 (System.Int32)]) = 0x3F800000;\n\tv371 = IdGenerator::Next();\n\tv372 = this.particleIds;\n\t*([v372 @ X8_v33 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = v371;\n\tv373 = this.powerUpIds;\n\t*([v373 @ X8_v34 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv375 = this.fishIds;\n\t*([v375 @ X8_v35 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv376 = this.octopusIds;\n\t*([v376 @ X8_v36 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv377 = this.inOctopusHead;\n\t*([v377 @ X8_v37 (Unity.Collections.NativeArray`1<System.Boolean>)+v194 @ X26_v6 (System.Int32)]) = 0;\n\tv378 = this.isWater;\n\t*([v378 @ X8_v38 (Unity.Collections.NativeArray`1<System.Boolean>)+v194 @ X26_v6 (System.Int32)]) = 0;\n\tv379 = this.isHoneyCoated;\n\t*([v379 @ X8_v39 (Unity.Collections.NativeArray`1<System.Boolean>)+v194 @ X26_v6 (System.Int32)]) = 0;\n\tv380 = this.clumpIds;\n\t*([v380 @ X8_v40 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv381 = this.spongeIds;\n\t*([v381 @ X8_v41 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv382 = this.caterpillarIds;\n\t*([v382 @ X8_v42 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv383 = this.beeIds;\n\t*([v383 @ X8_v43 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]) = 0xFFFFFFFF;\n\tv166 = this.gravities;\n\t*([v166 @ X9_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v191 @ X22_v7 (System.Int32)]) = this.defaultGravity;\n\tv385 = this.isStatic;\n\t*([v385 @ X8_v45 (Unity.Collections.NativeArray`1<System.Boolean>)+v194 @ X26_v6 (System.Int32)]) = 0;\n\tv387 = this.nearPressureMultipliers;\n\t*([v387 @ X8_v46 (Unity.Collections.NativeArray`1<System.Single>)+v116 @ X27_v5 (System.Int32)]) = this.nearPressureMultiplier;\n\tv388 = this.viscosityStrengths;\n\t*([v388 @ X8_v47 (Unity.Collections.NativeArray`1<System.Single>)+v116 @ X27_v5 (System.Int32)]) = this.viscosityStrength;\n\tv389 = this.particleIds;\n\tv390 = Il2CppMethodInfo;\n\tv290 = *([v390 @ X8_v49 (Il2CppMethodInfo)+C20]);\n\tv176 = Unity.Collections.NativeHashMap`2::TryAdd /* +1 sharing this address */(v283, *([v389 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v116 @ X27_v5 (System.Int32)]), v194, *([v390 @ X8_v49 (Il2CppMethodInfo)+C20]));\n\tv392 = this.particleIds;\n\tv398 = System.Collections.Generic.HashSet`1<System.Int32>::Add(v316, *([v392 @ X8_v51 (Unity.Collections.NativeArray`1<System.Int32>)+v194 @ X26_v6 (System.Int32)*4]));\n\tv311 = v223 == 0;\n\tif (v311) goto L_0062;\n\tv399 = this.particleIds;\n\tParticleInitData::.ctor(&v404 @ stack_-70_v5 (ParticleInitData), v194, *([v399 @ X8_v54 (Unity.Collections.NativeArray`1<System.Int32>)+v194 @ X26_v6 (System.Int32)*4]), v133);\n\tv290 = v223.method;\n\tv223.invoke_impl(v411, v223.method_code, v404, 0, v223.method, 0, v47, v48, v49, this.viscosityStrength, v51, v52, v53, v54, v55, v56, v57);\n\tgoto L_0062;\nL_00F2:\n\tv168 = this.<ActiveCount>k__BackingField;\nL_00F4:\n\tv321 = v168 + v200;\n\tthis.<ActiveCount>k__BackingField = v321;\n\tv271 = this.OnAddParticles;\n\tv265 = this.OnAddParticles == 0;\n\tif (v265) goto L_010C;\n\tv271.invoke_impl(v338, v271.method_code, v316, v271.method, v290, 0, v47, v48, v49, this.viscosityStrength, v51, v52, v53, v54, v55, v56, v57);\nL_010C:\n\treturn v316;\n\tv175 = new System.IndexOutOfRangeException();\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 138 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe global::System.Collections.Generic.HashSet<int> AddParticles(global::Unity.Mathematics.float2[] spawnPositions, int type, global::System.Action<ParticleInitData> onInit = null)
	{
		//IL_000e: Expected I, but got O
		//IL_0490: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_019b: Expected I, but got O
		//IL_01ab: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_0253: Expected I, but got O
		//IL_0263: Expected O, but got I
		//IL_0273: Expected O, but got I
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		_lastJob.Complete();
		int activeCount = ActiveCount;
		int num2 = maxParticles - ActiveCount;
		if (num2 > spawnPositions.Length)
		{
			num2 = spawnPositions.Length;
		}
		if (num2 >= 1)
		{
			int num7 = 0;
			do
			{
				int num8 = activeCount + num7;
				positions[num8] = spawnPositions[num7];
				positionsPrev[num8] = spawnPositions[num7];
				predicted[num8] = spawnPositions[num7];
				velocities[num8] = default(global::Unity.Mathematics.float2);
				densities[num8] = default(global::Unity.Mathematics.float2);
				deltaVel[num8] = default(global::Unity.Mathematics.float2);
				particleTypes[num8] = type;
				int num13 = IdGenerator.Next();
				particleIds[num8] = num13;
				powerUpIds[num8] = -1;
				fishIds[num8] = -1;
				octopusIds[num8] = -1;
				inOctopusHead[num8] = false;
				isWater[num8] = false;
				isHoneyCoated[num8] = false;
				clumpIds[num8] = -1;
				spongeIds[num8] = -1;
				caterpillarIds[num8] = -1;
				beeIds[num8] = -1;
				gravities[num8] = defaultGravity;
				isStatic[num8] = false;
				nearPressureMultipliers[num8] = nearPressureMultiplier;
				viscosityStrengths[num8] = viscosityStrength;
				emissionColors[num8] = default(global::Unity.Mathematics.float4);
				scales[num8] = 1f;
				idToIndex.TryAdd(num13, num8);
				hashSet.Add(num13);
				if (onInit != null)
				{
					ParticleInitData particleInitData = new ParticleInitData(num8, num13, num7);
					onInit(particleInitData);
				}
				num7++;
			}
			while (num2 != num7);
			activeCount = ActiveCount;
		}
		ActiveCount = activeCount + num2;
		OnAddParticles?.Invoke(hashSet);
		return hashSet;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000277")]
	[global::Cpp2ILInjected.Address(RVA = "0x1000CB0", Offset = "0x1000CB0", Length = "0xE4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = this.<ActiveCount>k__BackingField == 0;\n\tif (v30) goto L_FFFFFFFF;\n\tv41 = this.<ActiveCount>k__BackingField < 1;\n\tif (v41) goto L_FFFFFFFF;\n\tv66 = maxRadius * maxRadius;\nL_0028:\n\tv161 = this.positions + v147;\n\tv164 = Unity.Mathematics.float2::op_Implicit(worldPos);\n\tv166 = *([v161 @ X8_v6]) - v164;\n\tv167 = *([v161 @ X8_v6+4]) - v164.y;\n\tv168 = v166 * v166;\n\tv123 = v167 * v167;\n\tv87 = v168 + v123;\n\tv169 = this.isWater;\n\tv180 = v87 >= v66;\n\tif (v180) goto L_FFFFFFFF;\n\tv198 = *([v169 @ X8_v7 (Unity.Collections.NativeArray`1<System.Boolean>)+v146 @ X22_v4 (System.Int32)]) == 0;\n\tgoto L_0055;\nL_0055:\n\tv205 = v87 - v89;\n\tv206 = v205 < 0;\n\tv119 = v198 & v206;\n\tv213 = ~v119;\n\tv216 = ~v213;\n\tv217 = ~v216;\n\tif (v217) goto L_0069;\n\tgoto L_0069;\nL_0069:\n\tv220 = ~v213;\n\tv85 = ~v220;\n\tif (v85) goto L_0070;\n\tgoto L_0070;\nL_0070:\n\tv146 = v146 + 1;\n\tv147 = v147 + 8;\n\tv101 = v146 < this.<ActiveCount>k__BackingField;\n\tif (v101) goto L_0028;\n\tgoto L_008F;\nL_008F:\n\treturn v90;\n// 109 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public int FindClosestParticle(global::UnityEngine.Vector2 worldPos, float maxRadius)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		int result;
		if (ActiveCount != 0 && ActiveCount >= 1)
		{
			float num = maxRadius * maxRadius;
			float num2 = float.MaxValue;
			result = -1;
			int num3 = 0;
			int num4 = 0;
			do
			{
				global::Unity.Mathematics.float2 float4 = positions[num3];
				global::Unity.Mathematics.float2 float5 = worldPos;
				float num5 = float4.x - float5.x;
				float num6 = float4.y - float5.y;
				float num7 = num5 * num5;
				float num8 = num6 * num6;
				float num9 = num7 + num8;
				bool flag;
				if (num9 < num)
				{
					flag = !isWater[num3];
				}
				else
				{
					flag = false;
				}
				float num10 = num9 - num2;
				bool flag2 = num10 < 0f;
				bool flag3 = flag && flag2;
				bool flag4 = !flag3;
				if (!flag4)
				{
					result = num3;
				}
				if (!flag4)
				{
					num2 = num9;
				}
				num3++;
				num4 += 8;
			}
			while (num3 < ActiveCount);
		}
		else
		{
			result = -1;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000278")]
	[global::Cpp2ILInjected.Address(RVA = "0x1000D94", Offset = "0x1000D94", Length = "0xA28")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = &v33 @ stack_-10_v2;\n\tv40 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv42 = Il2CppMethodInfo;\n\tgoto L_005D;\n\tv47 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv48 = v47 + 0xFB8;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv93 = Il2CppMethodInfo;\n\tv94 = v93 + 0x2C0;\n\tv95 = \"il2cpp_codegen_initialize_runtime_metadata\"(v94, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0x2B8;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv108 = Il2CppMethodInfo;\n\tv109 = v108 + 0x2C8;\n\tv110 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv114 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv115 = v114 + 0x810;\n\tv116 = \"il2cpp_codegen_initialize_runtime_metadata\"(v115, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv129 = Il2CppMethodInfo;\n\tv130 = v129 + 0x980;\n\tv131 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv213 = Il2CppMethodInfo;\n\tv214 = v213 + 0x988;\n\tv215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v214, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv261 = Il2CppMethodInfo;\n\tv262 = v261 + 0x990;\n\tv263 = \"il2cpp_codegen_initialize_runtime_metadata\"(v262, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv317 = Il2CppMethodInfo;\n\tv318 = v317 + 0x980;\n\tv319 = \"il2cpp_codegen_initialize_runtime_metadata\"(v318, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv326 = Il2CppMethodInfo;\n\tv327 = v326 + 0x968;\n\tv328 = \"il2cpp_codegen_initialize_runtime_metadata\"(v327, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv594 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv595 = v594 + 0x5D8;\n\tv596 = \"il2cpp_codegen_initialize_runtime_metadata\"(v595, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv679 = Il2CppMethodInfo;\n\tv680 = v679 + 0x410;\n\tv681 = \"il2cpp_codegen_initialize_runtime_metadata\"(v680, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv825 = Il2CppMethodInfo;\n\tv826 = v825 + 0x438;\n\tv827 = \"il2cpp_codegen_initialize_runtime_metadata\"(v826, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv851 = Il2CppMethodInfo;\n\tv852 = v851 + 0x3F8;\n\tv853 = \"il2cpp_codegen_initialize_runtime_metadata\"(v852, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv927 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv928 = v927 + 0x110;\n\tv929 = \"il2cpp_codegen_initialize_runtime_metadata\"(v928, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv948 = Il2CppMethodInfo;\n\tv949 = v948 + 0x870;\n\tv950 = \"il2cpp_codegen_initialize_runtime_metadata\"(v949, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv1003 = Il2CppMethodInfo;\n\tv1004 = v1003 + 0x878;\n\tv1005 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1004, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv1131 = Il2CppMethodInfo;\n\tv1132 = v1131 + 0x868;\n\tv1133 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1132, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv1142 = Il2CppMethodInfo;\n\tv1143 = v1142 + 0x880;\n\tv1144 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1143, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv1181 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1182 = v1181 + 0x9D8;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1182, seedIndex, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv67 = 1;\n\t*([302AA02]) = v67;\nL_005D:\n\tv278 = Il2CppMethodInfo + 0x2C0;\n\t*([v32 @ X29_v1-80]) = 0;\n\tv74 = this.particleTypes;\n\tv77 = this.isHoneyCoated;\n\tif (this.isClumped) goto L_FFFFFFFF;\n\tgoto L_007B;\nL_007B:\n\tv102 = this.particleRadius * v193;\n\tv104 = 1f / v102;\n\tv107 = new *([v40 @ X20_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+810])();\n\tv191 = *([v42 @ X22_v1 (Il2CppMethodInfo)+2B8]);\n\tSystem.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::.ctor(v107, this.<ActiveCount>k__BackingField);\n\tv188 = this.<ActiveCount>k__BackingField;\n\tv128 = this.<ActiveCount>k__BackingField < 1;\n\tif (v128) goto L_015F;\n\tv137 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_00AD;\nL_009A:\n\tv1244 = *([v579 @ X8_v114+20]);\n\tv311 = *([v1244 @ X8_v117+C0]);\n\tv191 = *([v311 @ X8_v118+70]);\n\tSystem.Collections.Generic.List`1<System.Int32>::AddWithResize(v309, v243);\nL_009F:\n\tv243 = v243 + 1;\n\tv188 = this.<ActiveCount>k__BackingField;\n\tv226 = v226 + 8;\n\tv171 = v243 >= this.<ActiveCount>k__BackingField;\n\tif (v171) goto L_FFFFFFFF;\nL_00AD:\n\tv246 = this.particleTypes;\n\tv257 = *([v246 @ X8_v100 (Unity.Collections.NativeArray`1<System.Int32>)+v243 @ X21_v9 (System.Int32)*4]) != *([v74 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+seedIndex @ X1 (System.Int32)*4]);\n\tif (v257) goto L_009F;\n\tv264 = this.isHoneyCoated;\n\tv275 = *([v264 @ X8_v102 (Unity.Collections.NativeArray`1<System.Boolean>)+v243 @ X21_v9 (System.Int32)]) != *([v77 @ X8_v4 (Unity.Collections.NativeArray`1<System.Boolean>)+seedIndex @ X1 (System.Int32)]);\n\tif (v275) goto L_009F;\n\tv321 = this.positions + v226;\n\tv324 = *([2DD4414]) == 0;\n\tif (v324) goto L_00DD;\n\tv597 = v104 * *([v321 @ X8_v105]);\n\tv330 = *([v137 @ X22_v18 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv332 = *([v330 @ X0_v120+E0]) == 0;\n\tif (v332) goto L_00E6;\nL_00D3:\n\tv605 = UnityEngine.Mathf::Floor(v597);\n\tgoto L_00F0;\n\tgoto L_FFFFFFFF;\nL_00DD:\n\t*([2DD4414]) = 1;\n\tv597 = v104 * *([v321 @ X8_v105]);\n\tv600 = *([v137 @ X22_v18 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv612 = *([v600 @ X0_v117+E0]) == 0;\n\tv602 = ~v612;\n\tif (v602) goto L_00D3;\nL_00E6:\n\tv285 = UnityEngine.Mathf::Floor(v606);\n\tv842 = *([2DD4414]) == 0;\n\tif (v842) goto L_0156;\n\tgoto L_00F0;\nL_00F0:\n\tv841 = v104 * *([v321 @ X8_v105+4]);\n\tv193 = UnityEngine.Mathf::Floor(v841);\n\tv585 = v841 << 0x20;\n\tv868 = v193 != 0x7F800000;\n\tif (v868) goto L_0110;\n\tgoto L_0110;\nL_0110:\n\tv280 = v285 != 0x7F800000;\n\tif (v280) goto L_FFFFFFFF;\n\tgoto L_0118;\nL_0118:\n\tv313 = v585 | v449;\n\tv148 = *([v278 @ X25_v12]);\n\tv191 = &v33 @ stack_-10_v2 - 0x80;\n\tv1149 = System.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::TryGetValue(v107, v313, v191);\n\tv1184 = v1149 == 0;\n\tv1185 = ~v1184;\n\tif (v1185) goto L_0135;\n\tv1194 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1197 = new *([v1194 @ X8_v119 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+110])();\n\tSystem.Collections.Generic.List`1<System.Int32>::.ctor(v1197);\n\t*([v32 @ X29_v1-80]) = v1197;\n\tv1238 = Il2CppMethodInfo;\n\tv148 = *([v1238 @ X8_v123 (Il2CppMethodInfo)+2C8]);\n\tv278 = Il2CppMethodInfo + 0x2C0;\n\tSystem.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::set_Item(v107, v313, v1197);\nL_0135:\n\tv309 = *([v32 @ X29_v1-80]);\n\tv1232 = Il2CppMethodInfo;\n\tv579 = *([v1232 @ X8_v112 (Il2CppMethodInfo)+410]);\n\tv1235 = v309._version + 1;\n\tv309._version = v1235;\n\tv283 = v309._items;\n\tv281 = v309._size;\n\tv1240 = v309._size < v283.Length;\n\tv302 = ~v1240;\n\tif (v302) goto L_009A;\n\tv1243 \n// ... truncated")]
	public unsafe global::System.Collections.Generic.HashSet<int> FindContiguousRegionIndices(int seedIndex)
	{
		// The original flood-fill traversal over the spatial hash grid could not be recovered
		// from the decompiled body (near-total type-inference failure throughout). This keeps
		// the method's contract (a non-null result containing the seed) without fabricating
		// the connectivity search.
		return new global::System.Collections.Generic.HashSet<int> { seedIndex };
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000279")]
	[global::Cpp2ILInjected.Address(RVA = "0x10017BC", Offset = "0x10017BC", Length = "0xDE0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = &v33 @ stack_-10_v2;\n\tv40 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_0077;\n\tv47 = Il2CppMethodInfo;\n\tv48 = v47 + 0x2C0;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0x2B8;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv79 = Il2CppMethodInfo;\n\tv80 = v79 + 0x2C8;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v80, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv84 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv85 = v84 + 0x810;\n\tv86 = \"il2cpp_codegen_initialize_runtime_metadata\"(v85, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv88 = Il2CppMethodInfo;\n\tv89 = v88 + 0x980;\n\tv90 = \"il2cpp_codegen_initialize_runtime_metadata\"(v89, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv236 = Il2CppMethodInfo;\n\tv237 = v236 + 0x968;\n\tv238 = \"il2cpp_codegen_initialize_runtime_metadata\"(v237, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv343 = Il2CppMethodInfo;\n\tv344 = v343 + 0x970;\n\tv345 = \"il2cpp_codegen_initialize_runtime_metadata\"(v344, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv350 = Il2CppMethodInfo;\n\tv351 = v350 + 0x988;\n\tv352 = \"il2cpp_codegen_initialize_runtime_metadata\"(v351, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv361 = Il2CppMethodInfo;\n\tv362 = v361 + 0x978;\n\tv363 = \"il2cpp_codegen_initialize_runtime_metadata\"(v362, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv381 = Il2CppMethodInfo;\n\tv382 = v381 + 0x990;\n\tv383 = \"il2cpp_codegen_initialize_runtime_metadata\"(v382, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv448 = Il2CppMethodInfo;\n\tv449 = v448 + 0x980;\n\tv450 = \"il2cpp_codegen_initialize_runtime_metadata\"(v449, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv453 = Il2CppMethodInfo;\n\tv454 = v453 + 0x990;\n\tv455 = \"il2cpp_codegen_initialize_runtime_metadata\"(v454, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv462 = Il2CppMethodInfo;\n\tv463 = v462 + 0x998;\n\tv464 = \"il2cpp_codegen_initialize_runtime_metadata\"(v463, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv470 = Il2CppMethodInfo;\n\tv471 = v470 + 0x968;\n\tv472 = \"il2cpp_codegen_initialize_runtime_metadata\"(v471, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv483 = Il2CppMethodInfo;\n\tv484 = v483 + 0x9B0;\n\tv485 = \"il2cpp_codegen_initialize_runtime_metadata\"(v484, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv499 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv500 = v499 + 0x5D8;\n\tv501 = \"il2cpp_codegen_initialize_runtime_metadata\"(v500, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv526 = Il2CppMethodInfo;\n\tv527 = v526 + 0x410;\n\tv528 = \"il2cpp_codegen_initialize_runtime_metadata\"(v527, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv544 = Il2CppMethodInfo;\n\tv545 = v544 + 0x4C0;\n\tv546 = \"il2cpp_codegen_initialize_runtime_metadata\"(v545, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv572 = Il2CppMethodInfo;\n\tv573 = v572 + 0x438;\n\tv574 = \"il2cpp_codegen_initialize_runtime_metadata\"(v573, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv614 = Il2CppMethodInfo;\n\tv615 = v614 + 0x3F8;\n\tv616 = \"il2cpp_codegen_initialize_runtime_metadata\"(v615, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv653 = Il2CppMethodInfo;\n\tv654 = v653 + 0x4B8;\n\tv655 = \"il2cpp_codegen_initialize_runtime_metadata\"(v654, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv773 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv774 = v773 + 0x110;\n\tv775 = \"il2cpp_codegen_initialize_runtime_metadata\"(v774, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv789 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv790 = v789 + 0xE08;\n\tv791 = \"il2cpp_codegen_initialize_runtime_metadata\"(v790, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv798 = Il2CppMethodInfo;\n\tv799 = v798 + 0xC28;\n\tv800 = \"il2cpp_codegen_initialize_runtime_metadata\"(v799, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv810 = Il2CppMethodInfo;\n\tv811 = v810 + 0x870;\n\tv812 = \"il2cpp_codegen_initialize_runtime_metadata\"(v811, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv942 = Il2CppMethodInfo;\n\tv943 = v942 + 0x878;\n\tv944 = \"il2cpp_codegen_initialize_runtime_metadata\"(v943, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv961 = Il2CppMethodInfo;\n\tv962 = v961 + 0x868;\n\tv963 = \"il2cpp_codegen_initialize_runtime_metadata\"(v962, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv975 = Il2CppMethodInfo;\n\tv976 = v975 + 0x880;\n\tv977 = \"il2cpp_codegen_initialize_runtime_metadata\"(v976, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv985 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv986 = v985 + 0x9D8;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v986, ids, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv67 = 1;\n\t*([302AA03]) = v67;\nL_0077:\n\t*([v32 @ X29_v1-90]) = 0;\n\t*([v32 @ X29_v1-88]) = 0;\n\t*([v32 @ X29_v1-80]) = 0;\n\t*([v32 @ X29_v1-94]) = 0;\n\t*([v32 @ X29_v1-A0]) = 0;\n\t*([v32 @ X29_v1-A4]) = 0;\n\tv71 = this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v71);\n\tv78 = new *([v40 @ X21_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+E08])();\n\tSystem.Collections.Generic.List`1<System.Collections.Generic.HashSet`1<System.Int32>>::.ctor(v78);\n\tv87 = ids == 0;\n\tif (v87) goto L_01E5;\n\tv92 = ids._count == 0;\n\tif (v92) goto L_01E5;\n\tv240 = this.particleRadius + this.particleRadius;\n\tv195 = 1f / v240;\n\tv193 = v240 * v240;\n\tv242 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv245 = new *([v242 @ X8_v4 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+810])();\n\tSystem.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::.ctor(v245, ids._count);\n\tv360 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\n\t*([v32 @ X29_v1-90]) = v357;\n\t*([v32 @ X29_v1-80]) = v366;\n\tv369 = this + 0x1F8;\n\tv375 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv379 = Il2CppMethodInfo;\n\tgoto L_00BF;\nL_00BA:\n\tv988 = v434._size + 1;\n\tv434._size = v988;\n\tv415[v389 @ X10_v11 (System.Int32)] = *([v32 @ X29_v1-94]);\nL_00BF:\n\tv443 = Il2CppMethodInfo;\n\tv446 = &v33 @ stack_-10_v2 - 0x90;\n\tv447 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(v446, *([v443 @ X8_v15 (Il2CppMethodInfo)+970]));\n\tv451 = v447 & 1;\n\tv452 = v451 == 0;\n\tif (v452) goto L_016F;\n\tv456 = Il2CppMethodInfo;\n\tv424 = &v33 @ stack_-10_v2 - 0x94;\n\tv435 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v369, *([v32 @ X29_v1-80]), v424, *([v456 @ X8_v142 (Il2CppMethodInfo)+C28]));\n\tv465 = v435 & 1;\n\tv438 = v465 == 0;\n\tif (v438) goto L_00BF;\n\tv421 = *([v32 @ X29_v1-94]) << 3;\n\tv475 = this.positions + v421;\n\tv479 = *([2DD4414]) == 0;\n\tif (v479) goto L_00F0;\n\tv502 = v195 * *([v475 @ X8_v145]);\n\tv487 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv489 = *([v487 @ X8_v181 (Il2CppClass<Facebook.Unity.Wind\n// ... truncated")]
	public unsafe global::System.Collections.Generic.List<global::System.Collections.Generic.HashSet<int>> FindContiguousRegions(global::System.Collections.Generic.HashSet<int> ids)
	{
		// The original flood-fill traversal over the spatial hash grid could not be recovered
		// from the decompiled body (near-total type-inference failure throughout). This keeps
		// every id rather than fabricate the connectivity search: all ids come back as one region.
		return new global::System.Collections.Generic.List<global::System.Collections.Generic.HashSet<int>> { new global::System.Collections.Generic.HashSet<int>(ids) };
	}

	[global::Cpp2ILInjected.Token(Token = "0x600027A")]
	[global::Cpp2ILInjected.Address(RVA = "0x100259C", Offset = "0x100259C", Length = "0x394")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv42 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0042;\n\tv47 = System.Collections.Generic.NullableComparer`1;\n\tv48 = v47 + 0xC48;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0x968;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv72 = Il2CppMethodInfo;\n\tv73 = v72 + 0x970;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0x978;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv174 = Il2CppMethodInfo;\n\tv175 = v174 + 0x980;\n\tv176 = \"il2cpp_codegen_initialize_runtime_metadata\"(v175, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv179 = Il2CppMethodInfo;\n\tv180 = v179 + 0x998;\n\tv181 = \"il2cpp_codegen_initialize_runtime_metadata\"(v180, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv194 = Il2CppMethodInfo;\n\tv195 = v194 + 0x968;\n\tv196 = \"il2cpp_codegen_initialize_runtime_metadata\"(v195, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv213 = Il2CppMethodInfo;\n\tv214 = v213 + 0x9B0;\n\tv215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v214, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv220 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv221 = v220 + 0x5D8;\n\tv222 = \"il2cpp_codegen_initialize_runtime_metadata\"(v221, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv237 = Il2CppMethodInfo;\n\tv238 = v237 + 0xD38;\n\tv239 = \"il2cpp_codegen_initialize_runtime_metadata\"(v238, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv242 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv243 = v242 + 0xB70;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v243, ids, touchId, methodInfo, v51, v52, v53, v54, wPos, v0, delay, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302AA04]) = v64;\nL_0042:\n\tv66 = new *([v42 @ X23_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B70])();\n\tFluidSolver+<>c__DisplayClass140_0::.ctor(v66);\n\tv75 = v66 == 0;\n\tif (v75) goto L_0119;\n\tv79 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv150 = Il2CppMethodInfo + 0x968;\n\tv84 = v66 + 0x20;\n\tv66.<>4__this = this;\n\tv86 = 0xF3F1B4(v84, this, v464, methodInfo, v51, v52, v53, v54, wPos, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv66.touchId = v464;\n\tv178 = new *([v79 @ X23_v10 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v178);\n\tv172 = v66 + 0x18;\n\tv66.fresh = v178;\n\tv157 = 0xF3F1B4(v172, v178, v464, methodInfo, v51, v52, v53, v54, wPos, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv161 = ids == 0;\n\tif (v161) goto L_0119;\n\tv225 = Il2CppMethodInfo;\n\tv226 = Il2CppMethodInfo;\n\tv141 = System.Collections.Generic.NullableComparer`1 + 0xC48;\n\tv150 = Il2CppMethodInfo + 0xD38;\n\tv229 = Il2CppMethodInfo;\n\tv138 = Il2CppMethodInfo + 0x968;\n\tv234 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\nL_0078:\n\tv260 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v232 @ stack_-A8_v5 (UnityEngine.Vector2), *([v225 @ X27_v4 (Il2CppMethodInfo)+970]));\n\tv348 = v260 & 1;\n\tv265 = v348 == 0;\n\tif (v265) goto L_008D;\n\tv352 = this._pendingRemovalIds == 0;\n\tif (v352) goto L_0115;\n\tv251 = System.Collections.Generic.HashSet`1<System.Int32>::Add(this._pendingRemovalIds, v241);\n\tv254 = v251 == 0;\n\tif (v254) goto L_0078;\n\tv464 = *([v226 @ X28_v4 (Il2CppMethodInfo)+980]);\n\tv252 = System.Collections.Generic.HashSet`1<System.Int32>::Add(v66.fresh, v241);\n\tgoto L_0078;\nL_008D:\n\tv152 = *([v229 @ X26_v4 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v232 @ stack_-A8_v5 (UnityEngine.Vector2), *([v229 @ X26_v4 (Il2CppMethodInfo)+968]));\nL_0090:\n\tv169 = v172.m_value;\n\tv162 = v172.m_value == 0;\n\tif (v162) goto L_0119;\n\tv350 = *([v169 @ X8_v5 (System.Int32)+20]) == 0;\n\tif (v350) goto L_0102;\n\tv354 = ~this.isClumped;\n\tif (v354) goto L_0103;\n\tv383 = *([v169 @ X8_v5 (System.Int32)+20]) - 0x10;\n\tv384 = v383 < 0;\n\tv386 = *([v169 @ X8_v5 (System.Int32)+20]) ^ 0x10;\n\tv387 = *([v169 @ X8_v5 (System.Int32)+20]) ^ v383;\n\tv388 = v386 & v387;\n\tv389 = v388 < 0;\n\tv390 = v384 == v389;\n\tv66.createPowerup = v390;\n\tv410 = this.OnRemoveRegionStart;\n\tv393 = this.OnRemoveRegionStart == 0;\n\tif (v393) goto L_00BB;\nL_00AB:\n\tv425 = *([v169 @ X8_v5 (System.Int32)+20]) - v421;\n\tv426 = v425 < 0;\n\tv428 = *([v169 @ X8_v5 (System.Int32)+20]) ^ v421;\n\tv429 = *([v169 @ X8_v5 (System.Int32)+20]) ^ v425;\n\tv430 = v428 & v429;\n\tv431 = v430 < 0;\n\tv432 = v426 == v431;\n\tv410.invoke_impl(v439, v410.method_code, v432, v410.method, methodInfo, v51, v52, v53, v54, wPos, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv359 = v66.createPowerup;\nL_00BB:\n\tv457 = ~v359;\n\tif (v457) goto L_00C9;\n\tv460 = this.OnCreatePowerup;\n\tv461 = this.OnCreatePowerup == 0;\n\tif (v461) goto L_00C9;\n\tv460.invoke_impl(v471, v460.method_code, ids, v460.method, methodInfo, v51, v52, v53, v54, wPos, wPos.y, delay, v56, v57, v58, v59, v60);\nL_00C9:\n\tv356 = v66.touchId << 3;\n\tv476 = this.positions + v356;\n\t// 206 MakeStruct v355 @ AGG1002814_0_v2 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v476 @ X8_v11], [v476 @ X8_v11+4]\n\tv480 = Unity.Mathematics.float2::op_Implicit(v355);\n\tv66.touchPos = v480;\n\tv66.touchPos.y = v480.y;\n\tFluidSolver::HandleSplashDestroy(this, ids);\n\tv485 = new *([v141 @ X25_v2])();\n\tSystem.Action`1<System.Collections.Generic.HashSet`1<System.Int32>>::.ctor(v485, v66, *([v150 @ X24_v2]));\n\tv365 = v66.createPowerup == 0;\n\tv495 = FluidSolver::HandleRemove(this, ids, v485, v365, 0.2f);\n\tv373 = UnityEngine.MonoBehaviour::StartCoroutine(this, v495);\nL_0102:\n\treturn;\nL_0103:\n\tv421 = this.powerUpThreshold;\n\tv397 = *([v169 @ X8_v5 (System.Int32)+20]) - this.powerUpThreshold;\n\tv398 = v397 < 0;\n\tv400 = *([v169 @ X8_v5 (System.Int32)+20]) ^ this.powerUpThreshold;\n\tv401 = *([v169 @ X8_v5 (System.Int32)+20]) ^ v397;\n\tv402 = v400 & v401;\n\tv403 = v402 < 0;\n\tv404 = v398 == v403;\n\tv66.createPowerup = v404;\n\tv410 = this.OnRemoveRegionStart;\n\tv407 = this.OnRemoveRegionStart == 0;\n\tv408 = ~v407;\n\tif (v408) goto L_00AB;\n\tgoto L_00BB;\nL_0115:\n\tv379 = new System.NullReferenceException();\n\tgoto L_0118;\n\tv459 = new System.NullReferenceException();\nL_0118:\n\t// 280 Interrupt\nL_0119:\n\tv173 = new System.NullReferenceException();\n\tgoto L_0128;\n\tgoto L_0128;\n\tgoto L_0128;\n\tgoto L_0128;\nL_0128:\n\tv193 = v152 != 1;\n\tif (v193) goto L_0138;\n\tv200 = 0x274A080(v173, v152, v464, methodInfo, v51, v52, v53, v54, v131, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv217 = 0x274A098(v200, v152, v464, methodInfo, v51, v52, v53, v54, v131, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv152 = *([v138 @ X26_v2]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v120, *([v138 @ X26_v2]));\n\tv208 = *([v200 @ X0_v13]) == 0;\n\tif (v208) goto L_0090;\n\tv206 = new System.OutOfMemoryException();\nL_0138:\n\tv212 = 0xBF092C(&v134 @ stack_-A8 (System.Int32), v152, v464, methodInfo, v51, v52, v53, v54, v131, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv219 = 0x27498DC(v209, v152, v464, methodInfo, v51, v52, v53, v54, v131, wPos.y, delay, v56, v57, v58, v59, v60);\n\tv236 = 0xD6F8(v219, v152, v464, methodInfo, v51, v52, v53, v54, v131, wPos.y, delay, v56, v57, v58, v59, v60);\n\treturn;\n// 160 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void UserRemoveRegion(global::System.Collections.Generic.HashSet<int> ids, int touchId, global::UnityEngine.Vector2 wPos, float delay = 0.3f)
	{
		FluidSolver._003C_003Ec__DisplayClass140_0 displayClass = new FluidSolver._003C_003Ec__DisplayClass140_0();
		displayClass._003C_003E4__this = this;
		displayClass.touchId = touchId;
		global::System.Collections.Generic.HashSet<int> fresh = new global::System.Collections.Generic.HashSet<int>();
		displayClass.fresh = fresh;
		if (ids != null)
		{
			foreach (int id in ids)
			{
				if (_pendingRemovalIds.Add(id))
				{
					fresh.Add(id);
				}
			}
		}
		if (isClumped)
		{
			displayClass.createPowerup = fresh.Count >= bigPowerUpThreshold;
		}
		else
		{
			displayClass.createPowerup = fresh.Count >= powerUpThreshold;
		}
		OnRemoveRegionStart?.Invoke(displayClass.createPowerup, wPos);
		if (displayClass.createPowerup)
		{
			OnCreatePowerup?.Invoke(fresh, wPos);
		}
		global::Unity.Mathematics.float2 float5 = positions[displayClass.touchId];
		global::UnityEngine.Vector2 vector3 = (displayClass.touchPos = float5);
		HandleSplashDestroy(ids);
		global::System.Action<global::System.Collections.Generic.HashSet<int>> onRemove = displayClass._003CUserRemoveRegion_003Eb__0;
		bool explode = !displayClass.createPowerup;
		global::System.Collections.IEnumerator routine = HandleRemove(ids, onRemove, explode);
		global::UnityEngine.Coroutine coroutine = StartCoroutine(routine);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FluidSolver._003CHandleRemove_003Ed__141))]
	[global::Cpp2ILInjected.Token(Token = "0x600027B")]
	[global::Cpp2ILInjected.Address(RVA = "0x1002C70", Offset = "0x1002C70", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv34 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_001F;\n\tv39 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv40 = v39 + 0xBC0;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, ids, onRemove, explode, methodInfo, v43, v44, v45, delay, v46, v47, v48, v49, v50, v51, v52);\n\tv55 = 1;\n\t*([302AA05]) = v55;\nL_001F:\n\tv57 = new *([v34 @ X24_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BC0])();\n\tFluidSolver+<HandleRemove>d__141::.ctor(v57, 0);\n\tv63 = v57 + 0x20;\n\tv57.<>4__this = this;\n\tv65 = 0xF3F1B4(v63, this, 0, explode, methodInfo, v43, v44, v45, delay, v46, v47, v48, v49, v50, v51, v52);\n\tv68 = v57 + 0x28;\n\tv57.ids = ids;\n\tv70 = 0xF3F1B4(v68, ids, 0, explode, methodInfo, v43, v44, v45, delay, v46, v47, v48, v49, v50, v51, v52);\n\tv72 = v57 + 0x38;\n\tv57.onRemove = onRemove;\n\tv74 = 0xF3F1B4(v72, onRemove, 0, explode, methodInfo, v43, v44, v45, delay, v46, v47, v48, v49, v50, v51, v52);\n\tv57.explode = explode;\n\tv57.delay = delay;\n\treturn v57;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 47 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleRemove(global::System.Collections.Generic.HashSet<int> ids, global::System.Action<global::System.Collections.Generic.HashSet<int>> onRemove = null, bool explode = true, float delay = 0.2f)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0070: Expected O, but got I
		FluidSolver._003CHandleRemove_003Ed__141 _003CHandleRemove_003Ed__142 = new FluidSolver._003CHandleRemove_003Ed__141(0);
		_003CHandleRemove_003Ed__142._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CHandleRemove_003Ed__142.ids = ids;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CHandleRemove_003Ed__142.onRemove = onRemove;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CHandleRemove_003Ed__142.explode = explode;
		_003CHandleRemove_003Ed__142.delay = delay;
		return _003CHandleRemove_003Ed__142;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600027C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF7F34", Offset = "0xFF7F34", Length = "0x4E0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv34 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv36 = Il2CppMethodInfo;\n\tv37 = Il2CppMethodInfo + 0x968;\n\tgoto L_0044;\n\tv41 = Il2CppMethodInfo;\n\tv42 = v41 + 0x968;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0x970;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv72 = Il2CppMethodInfo;\n\tv73 = v72 + 0x978;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0x980;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv171 = Il2CppMethodInfo;\n\tv172 = v171 + 0x990;\n\tv173 = \"il2cpp_codegen_initialize_runtime_metadata\"(v172, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv178 = Il2CppMethodInfo;\n\tv179 = v178 + 0x998;\n\tv180 = \"il2cpp_codegen_initialize_runtime_metadata\"(v179, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv203 = Il2CppMethodInfo;\n\tv204 = v203 + 0x968;\n\tv205 = \"il2cpp_codegen_initialize_runtime_metadata\"(v204, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv240 = Il2CppMethodInfo;\n\tv241 = v240 + 0x9B0;\n\tv242 = \"il2cpp_codegen_initialize_runtime_metadata\"(v241, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv257 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv258 = v257 + 0x5D8;\n\tv259 = \"il2cpp_codegen_initialize_runtime_metadata\"(v258, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv278 = Il2CppMethodInfo;\n\tv279 = v278 + 0xC18;\n\tv280 = \"il2cpp_codegen_initialize_runtime_metadata\"(v279, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv298 = Il2CppMethodInfo;\n\tv299 = v298 + 0xC28;\n\tv300 = \"il2cpp_codegen_initialize_runtime_metadata\"(v299, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv304 = Il2CppMethodInfo;\n\tv305 = v304 + 0xC38;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v305, ids, onRemove, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv60 = 1;\n\t*([302AA06]) = v60;\nL_0044:\n\tv64 = 0;\n\tv66 = new *([v34 @ X20_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1::.ctor /* +1 sharing this address */(v66, *([v36 @ X21_v1 (Il2CppMethodInfo)+968]));\n\tv75 = ids == 0;\n\tif (v75) goto L_014E;\n\tv81 = Il2CppMethodInfo;\n\tv147 = Il2CppMethodInfo + 0x968;\n\tv83 = Il2CppMethodInfo;\n\tv145 = Il2CppMethodInfo + 0x970;\n\tv89 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\n\tv159 = this + 0x1F8;\n\tv176 = Il2CppMethodInfo;\n\tv177 = v66 == 0;\n\tif (v177) goto L_0082;\n\tv181 = Il2CppMethodInfo;\nL_0066:\n\tv223 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v140 @ stack_-A0_v1 (System.Int32), *([v83 @ X26_v8 (Il2CppMethodInfo)+970]));\n\tv243 = v223 & 1;\n\tv244 = v243 == 0;\n\tif (v244) goto L_0088;\n\tv124 = *([v176 @ X24_v14 (Il2CppMethodInfo)+C28]);\n\tv217 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v159, v175, &v64 @ stack_-84_v1, *([v176 @ X24_v14 (Il2CppMethodInfo)+C28]));\n\tv281 = v217 & 1;\n\tv220 = v281 == 0;\n\tif (v220) goto L_0066;\n\tv121 = *([v181 @ X28_v5 (Il2CppMethodInfo)+980]);\n\tv218 = System.Collections.Generic.HashSet`1::Add /* +1 sharing this address */(v66, v64, *([v181 @ X28_v5 (Il2CppMethodInfo)+980]));\n\tgoto L_0066;\nL_0078:\n\tv124 = *([v176 @ X24_v14 (Il2CppMethodInfo)+C28]);\n\tv187 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v159, v175, &v64 @ stack_-84_v1, *([v176 @ X24_v14 (Il2CppMethodInfo)+C28]));\nL_0082:\n\tv191 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v140 @ stack_-A0_v1 (System.Int32), *([v83 @ X26_v8 (Il2CppMethodInfo)+970]));\n\tv224 = v191 == 0;\n\tv225 = ~v224;\n\tif (v225) goto L_0078;\nL_0088:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v140 @ stack_-A0_v1 (System.Int32), *([v81 @ X25_v8 (Il2CppMethodInfo)+968]));\nL_0089:\n\tv273 = v272 == 0;\n\tif (v273) goto L_0090;\n\tv272.invoke_impl(v286, v272.method_code, ids, v272.method, v124, v45, v46, v47, v48, v265, v50, v51, v52, v53, v54, v55, v56);\nL_0090:\n\tv291 = Il2CppMethodInfo;\n\tv296 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\nL_009F:\n\tv315 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v140 @ stack_-A0_v1 (System.Int32), *([v145 @ X26_v2]));\n\tv392 = v315 & 1;\n\tv312 = v392 == 0;\n\tif (v312) goto L_00AA;\n\tv121 = *([v291 @ X23_v4 (Il2CppMethodInfo)+C18]);\n\tv310 = Unity.Collections.NativeHashMap`2::Remove /* +1 sharing this address */(v161, v175, *([v291 @ X23_v4 (Il2CppMethodInfo)+C18]));\n\tgoto L_009F;\nL_00AA:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v140 @ stack_-A0_v1 (System.Int32), *([v147 @ X25_v2]));\nL_00AB:\n\tv158 = v66 == 0;\n\tif (v158) goto L_014E;\n\tv395 = *([v66 @ X0_v3+20]) == 0;\n\tif (v395) goto L_014B;\n\tv407 = this.<ActiveCount>k__BackingField < 1;\n\tif (v407) goto L_FFFFFFFF;\n\tv442 = Il2CppMethodInfo;\n\tv444 = Il2CppMethodInfo;\n\tgoto L_0129;\nL_00C5:\n\tv538 = this.positions;\n\tv539 = v493 << 3;\n\tv542 = v492 & 0xFFFFFFFF;\n\tv543 = v542 << 3;\n\t*([v538 @ X8_v18 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v543 @ X12_v6 (System.Int32)]) = *([v538 @ X8_v18 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v539 @ X9_v7 (System.Int32)]);\n\tv544 = this.positionsPrev;\n\t*([v544 @ X8_v19 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v543 @ X12_v6 (System.Int32)]) = *([v544 @ X8_v19 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v539 @ X9_v7 (System.Int32)]);\n\tv546 = this.predicted;\n\t*([v546 @ X8_v20 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v543 @ X12_v6 (System.Int32)]) = *([v546 @ X8_v20 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v539 @ X9_v7 (System.Int32)]);\n\tv548 = this.velocities;\n\t*([v548 @ X8_v21 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v543 @ X12_v6 (System.Int32)]) = *([v548 @ X8_v21 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v539 @ X9_v7 (System.Int32)]);\n\tv550 = this.densities;\n\t*([v550 @ X8_v22 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v543 @ X12_v6 (System.Int32)]) = *([v550 @ X8_v22 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v539 @ X9_v7 (System.Int32)]);\n\tv552 = this.deltaVel;\n\t*([v552 @ X8_v23 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v543 @ X12_v6 (System.Int32)]) = *([v552 @ X8_v23 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v539 @ X9_v7 (System.Int32)]);\n\tv554 = this.particleTypes;\n\tv555 = v493 << 2;\n\tv557 = v492 & 0xFFFFFFFF;\n\tv558 = v557 << 2;\n\t*([v554 @ X8_v24 (Unity.Collections.NativeArray`1<System.Int32>)+v558 @ X12_v7 (System.Int32)]) = *([v554 @ X8_v24 (Unity.Collections.NativeArray`1<System.Int32>)+v555 @ X10_v11 (System.Int32)]);\n\tv559 = this.emissionColors;\n\t*([v559 @ X8_v25 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)+v492 @ X22_v8 (System.Int32)*16]) = *([v559 @ X8_v25 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)+v489 @ X24_v12 (System.Int32)]);\n\tv561 = this.scales;\n\t*([v561 @ X8_v26 (Unity.Collections.NativeArray`1<System.Single>)+v558 @ X12_v7 (System.Int32)]) = *([v561 @ X8_v26 (Unity.Collections.NativeArray`1<System.Single>)+v555 @ X10_v11 (System.Int32)]);\n\tv533 = this.particleIds;\n\t*([v533 @ X8_v16 (Unity.Collections.NativeArray`1<System.Int32>)+v558 @ X12_v7 (System.Int32)]) = *([v533 @ X8_v16 (Unity.Collections.NativeArray`1<\n// ... truncated")]
	public void RemoveParticles(global::System.Collections.Generic.HashSet<int> ids, global::System.Action<global::System.Collections.Generic.HashSet<int>> onRemove = null)
	{
		if (ids == null)
		{
			return;
		}
		onRemove?.Invoke(ids);
		foreach (int id in ids)
		{
			idToIndex.Remove(id);
		}
		int writeIndex = 0;
		if (ActiveCount >= 1)
		{
			for (int readIndex = 0; readIndex < ActiveCount; readIndex++)
			{
				if (ids.Contains(particleIds[readIndex]))
				{
					continue;
				}
				if (readIndex != writeIndex)
				{
					positions[writeIndex] = positions[readIndex];
					positionsPrev[writeIndex] = positionsPrev[readIndex];
					predicted[writeIndex] = predicted[readIndex];
					velocities[writeIndex] = velocities[readIndex];
					densities[writeIndex] = densities[readIndex];
					deltaVel[writeIndex] = deltaVel[readIndex];
					particleTypes[writeIndex] = particleTypes[readIndex];
					emissionColors[writeIndex] = emissionColors[readIndex];
					scales[writeIndex] = scales[readIndex];
					particleIds[writeIndex] = particleIds[readIndex];
					powerUpIds[writeIndex] = powerUpIds[readIndex];
					caterpillarIds[writeIndex] = caterpillarIds[readIndex];
					beeIds[writeIndex] = beeIds[readIndex];
					fishIds[writeIndex] = fishIds[readIndex];
					octopusIds[writeIndex] = octopusIds[readIndex];
					inOctopusHead[writeIndex] = inOctopusHead[readIndex];
					isHoneyCoated[writeIndex] = isHoneyCoated[readIndex];
					spongeIds[writeIndex] = spongeIds[readIndex];
					isWater[writeIndex] = isWater[readIndex];
					viscosityStrengths[writeIndex] = viscosityStrengths[readIndex];
					nearPressureMultipliers[writeIndex] = nearPressureMultipliers[readIndex];
					clumpIds[writeIndex] = clumpIds[readIndex];
					isStatic[writeIndex] = isStatic[readIndex];
				}
				idToIndex[particleIds[writeIndex]] = writeIndex;
				writeIndex++;
			}
		}
		ActiveCount = writeIndex;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600027D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1002D38", Offset = "0x1002D38", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x980;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x990;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AA07]) = v42;\nL_0017:\n\tv77 = this.usedFluidTypes;\n\tv58 = Il2CppMethodInfo + 0x980;\nL_0021:\n\tv81 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(v77, v73);\n\tv77 = this.usedFluidTypes;\n\tv83 = v81 == 0;\n\tif (v83) goto L_0030;\n\tv71 = v73 + 1;\n\tv88 = this.usedFluidTypes == 0;\n\tv66 = ~v88;\n\tif (v66) goto L_0021;\n\tv64 = new System.NullReferenceException();\nL_0030:\n\tv87 = System.Collections.Generic.HashSet`1::Add /* +1 sharing this address */(v64, v73, *([v58 @ X21_v3]));\n\treturn v73;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public int GetNextUnusedFluidType()
	{
		//IL_0012: Expected O, but got I
		global::System.Collections.Generic.HashSet<int> hashSet = usedFluidTypes;
		object obj = (nint)0 + (nint)2432;
		int num = 0;
		while (true)
		{
			bool flag = hashSet.Contains(num);
			hashSet = usedFluidTypes;
			bool flag2 = !flag;
			global::System.NullReferenceException ex = (global::System.NullReferenceException)(object)usedFluidTypes;
			if (flag2)
			{
				break;
			}
			int num2 = num + 1;
			bool flag3 = usedFluidTypes == null;
			bool flag4 = !flag3;
			num = num2;
			if (!flag4)
			{
				ex = new global::System.NullReferenceException();
				num = num2;
				break;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C3C78 (System.Collections.Generic.HashSet`1::Add, and 1 more at this address)");
		return num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600027E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5238", Offset = "0xFF5238", Length = "0x214")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = 0x302A000;\n\tv32 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv34 = *([302AA08]) & 1;\n\tv35 = v34 == 0;\n\tif (v35) goto L_007D;\n\tv37 = *([v32 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv39 = *([v37 @ X0_v57+E0]) == 0;\n\tif (v39) goto L_0085;\nL_001C:\n\tv94 = this + 0x478;\n\tv69 = UnityEngine.Object::op_Equality(v59, 0);\n\tv78 = ~v69;\n\tif (v78) goto L_008D;\nL_0023:\n\tv95 = System.Collections.Generic.NullableComparer`1;\n\tv97 = Il2CppMethodInfo;\n\tv101 = Il2CppMethodInfo;\n\tv105 = new *([v95 @ X8_v10 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v105, this, *([v97 @ X26_v4 (Il2CppMethodInfo)+560]));\n\tv161 = FluidSolver::AddParticles(this, positions, this.mudFluidType, v105);\n\tgoto L_0040;\n\tv229 = \"il2cpp_codegen_runtime_class_init\"(v202, v139, v136, v129, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_0040:\n\tv142 = Singleton`1::get_Instance /* +1 sharing this address */(*([v101 @ X25_v4 (Il2CppMethodInfo)+C90]));\n\tv235 = UnityEngine.Component::get_transform(this);\n\tgoto L_004E;\n\tv241 = \"il2cpp_codegen_runtime_class_init\"(v237, v234, v136, v129, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_004E:\n\tv243 = Il2CppMethodInfo;\n\tv246 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v142 @ X0_v39+B0]), v235, *([v243 @ X8_v14 (Il2CppMethodInfo)+B8]));\n\tthis.mudInstance = v246;\n\tv248 = 0xF3F1B4(v94, v246, *([v243 @ X8_v14 (Il2CppMethodInfo)+B8]), v105, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv143 = Singleton`1::get_Instance /* +1 sharing this address */(*([v101 @ X25_v4 (Il2CppMethodInfo)+C90]));\n\tv179 = SpecialFluid::Init(this.mudInstance, this, v161, this.mudFluidType, *([v143 @ X0_v49+108]));\n\tgoto L_00A3;\nL_007D:\n\t*([v30 @ X20_v1+A08]) = 1;\n\tv58 = *([v32 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv228 = *([v58 @ X0_v30+E0]) == 0;\n\tv62 = ~v228;\n\tif (v62) goto L_001C;\nL_0085:\n\tv94 = this + 0x478;\n\tv83 = UnityEngine.Object::op_Equality(v71, 0);\n\tv115 = ~v83;\n\tv92 = ~v115;\n\tif (v92) goto L_0023;\nL_008D:\n\tv113 = *([v184 @ X20_v2]);\n\tv123 = *([v113 @ X0_v6]);\n\t*([v123 @ X8_v5+1A8])(v127, v113, positions, *([v123 @ X8_v5+1B0]), v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_00A3:\n\treturn *([v184 @ X20_v2]);\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 119 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Mud AddMud(global::Unity.Mathematics.float2[] positions)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_01bc: Expected O, but got I
		//IL_009f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_020c: Expected O, but got I
		//IL_00dc: Expected I, but got O
		//IL_0199: Expected O, but got I
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA08]");
		global::UnityEngine.Object obj3;
		global::UnityEngine.Object obj4;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v57+E0]");
			bool flag = (nint)0 == 0;
			obj3 = mudInstance;
			obj4 = mudInstance;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v30+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj3 = mudInstance;
			obj4 = mudInstance;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		object obj6 = mudInstance;
		bool flag4 = obj4 == null;
		bool flag5 = !flag4;
		bool flag6 = !flag5;
		object obj7 = obj6;
		if (flag6)
		{
			goto IL_00ce;
		}
		goto IL_024b;
		IL_026f:
		return (Mud)obj7;
		IL_00ce:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X26_v4 (Il2CppMethodInfo)+560]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(this, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(positions, mudFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::UnityEngine.Transform transform = base.transform;
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		Mud mud = default(Mud);
		mudInstance = mud;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		Mud mud2 = mudInstance;
		int fluidType = mudFluidType;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v49+108]");
		mud2.Init(this, hashSet, fluidType, default(FluidCompute));
		obj7 = obj6;
		goto IL_026f;
		IL_024b:
		object obj8 = obj7;
		object obj9 = obj8;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X8_v5+1A8] (should have been resolved before IL gen)");
		goto IL_026f;
		IL_0093:
		obj6 = mudInstance;
		bool flag7 = obj3 == null;
		bool flag8 = !flag7;
		obj7 = obj6;
		if (!flag8)
		{
			goto IL_00ce;
		}
		goto IL_024b;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600027F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF544C", Offset = "0xFF544C", Length = "0x204")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = 0x302A000;\n\tv28 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv30 = *([302AA09]) & 1;\n\tv31 = v30 == 0;\n\tif (v31) goto L_007A;\n\tv33 = *([v28 @ X23_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv35 = *([v33 @ X0_v57+E0]) == 0;\n\tif (v35) goto L_0085;\nL_001D:\n\tv64 = UnityEngine.Object::op_Equality(v59, 0);\n\tv73 = ~v64;\n\tif (v73) goto L_0090;\nL_0020:\n\tv88 = System.Collections.Generic.NullableComparer`1;\n\tv90 = Il2CppMethodInfo;\n\tv94 = Il2CppMethodInfo;\n\tv98 = new *([v88 @ X8_v10 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v98, this, *([v90 @ X25_v4 (Il2CppMethodInfo)+568]));\n\tv152 = FluidSolver::AddParticles(this, positions, this.snowFluidType, v98);\n\tgoto L_003D;\n\tv215 = \"il2cpp_codegen_runtime_class_init\"(v190, v131, v128, v121, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\nL_003D:\n\tv134 = Singleton`1::get_Instance /* +1 sharing this address */(*([v94 @ X24_v4 (Il2CppMethodInfo)+C90]));\n\tv221 = UnityEngine.Component::get_transform(this);\n\tgoto L_004B;\n\tv227 = \"il2cpp_codegen_runtime_class_init\"(v223, v220, v128, v121, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\nL_004B:\n\tv229 = Il2CppMethodInfo;\n\tv232 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v134 @ X0_v39+B8]), v221, *([v229 @ X8_v14 (Il2CppMethodInfo)+D8]));\n\tv233 = this + 0x480;\n\tthis.snowInstance = v232;\n\tv234 = 0xF3F1B4(v233, v232, *([v229 @ X8_v14 (Il2CppMethodInfo)+D8]), v98, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv135 = Singleton`1::get_Instance /* +1 sharing this address */(*([v94 @ X24_v4 (Il2CppMethodInfo)+C90]));\n\tv170 = SpecialFluid::Init(this.snowInstance, this, v152, this.snowFluidType, *([v135 @ X0_v49+108]));\n\tgoto L_009D;\nL_007A:\n\t*([v26 @ X21_v1+A09]) = 1;\n\tv54 = *([v28 @ X23_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv214 = *([v54 @ X0_v30+E0]) == 0;\n\tv56 = ~v214;\n\tif (v56) goto L_001D;\nL_0085:\n\tv77 = UnityEngine.Object::op_Equality(v68, 0);\n\tv107 = ~v77;\n\tv85 = ~v107;\n\tif (v85) goto L_0020;\nL_0090:\n\tv119 = SpecialFluid::AddParticles(this.snowInstance, positions);\nL_009D:\n\treturn this.snowInstance;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 116 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Snow AddSnow(global::Unity.Mathematics.float2[] positions)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_01ac: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_00c8: Expected I, but got O
		//IL_0147: Expected O, but got I
		//IL_0191: Expected O, but got I
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA09]");
		global::UnityEngine.Object obj3;
		global::UnityEngine.Object obj4;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X23_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X0_v57+E0]");
			bool flag = (nint)0 == 0;
			obj3 = mudInstance;
			obj4 = mudInstance;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X23_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v30+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj3 = mudInstance;
			obj4 = mudInstance;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		if (obj4 == null)
		{
			goto IL_00ba;
		}
		goto IL_0227;
		IL_023b:
		return snowInstance;
		IL_00ba:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X25_v4 (Il2CppMethodInfo)+568]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(this, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(positions, snowFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::UnityEngine.Transform transform = base.transform;
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		Snow snow = default(Snow);
		snowInstance = snow;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		Snow snow2 = snowInstance;
		int fluidType = snowFluidType;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v49+108]");
		snow2.Init(this, hashSet, fluidType, default(FluidCompute));
		goto IL_023b;
		IL_0227:
		snowInstance.AddParticles(positions);
		goto IL_023b;
		IL_0093:
		if (obj3 == null)
		{
			goto IL_00ba;
		}
		goto IL_0227;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000280")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3274", Offset = "0xFF3274", Length = "0x30C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv34 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0040;\n\tv39 = System.Collections.Generic.NullableComparer`1;\n\tv40 = v39 + 0xD10;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x968;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv66 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv67 = v66 + 0x5D8;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x930;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv136 = Il2CppMethodInfo;\n\tv137 = v136 + 0xC70;\n\tv138 = \"il2cpp_codegen_initialize_runtime_metadata\"(v137, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv141 = Il2CppMethodInfo;\n\tv142 = v141 + 0xC0;\n\tv143 = \"il2cpp_codegen_initialize_runtime_metadata\"(v142, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv222 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv223 = v222 + 0xFD8;\n\tv224 = \"il2cpp_codegen_initialize_runtime_metadata\"(v223, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv227 = Il2CppMethodInfo;\n\tv228 = v227 + 0xC90;\n\tv229 = \"il2cpp_codegen_initialize_runtime_metadata\"(v228, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv232 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv233 = v232 + 0xA48;\n\tv234 = \"il2cpp_codegen_initialize_runtime_metadata\"(v233, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv239 = Il2CppMethodInfo;\n\tv240 = v239 + 0xD40;\n\tv241 = \"il2cpp_codegen_initialize_runtime_metadata\"(v240, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv244 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv245 = v244 + 0xB78;\n\tv246 = \"il2cpp_codegen_initialize_runtime_metadata\"(v245, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv251 = System.Xml.ValidateNames;\n\tv252 = v251 + 0xD40;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v252, pos, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302AA0A]) = v58;\nL_0040:\n\tv60 = new *([v34 @ X23_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B78])();\n\tFluidSolver+<>c__DisplayClass146_0::.ctor(v60);\n\tv73 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv77 = System.Collections.Generic.NullableComparer`1;\n\tv79 = Il2CppMethodInfo;\n\tv83 = Il2CppMethodInfo;\n\tv86 = v60 + 0x10;\n\tv60.<>4__this = this;\n\tv88 = 0xF3F1B4(v86, this, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv140 = FluidSolver::GetNextUnusedFluidType(this);\n\tv145 = IdGenerator::Next();\n\tv60.octId = v145;\n\tv226 = new *([v73 @ X24_v2 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v226);\n\tv236 = v60 + 0x20;\n\tv60.headIds = v226;\n\tv238 = 0xF3F1B4(v236, v226, splitIndex, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv243 = new *([v77 @ X28_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v243, v60, *([v79 @ X20_v2 (Il2CppMethodInfo)+D40]));\n\tv254 = FluidSolver::AddParticles(this, pos, v140, v243);\n\tgoto L_007B;\n\tv258 = \"il2cpp_codegen_runtime_class_init\"(v255, v113, v98, v95, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\nL_007B:\n\tv117 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X26_v2 (Il2CppMethodInfo)+C90]));\n\tv262 = Il2CppMethodInfo;\n\tv266 = UnityEngine.Component::get_transform(this);\n\tgoto L_0090;\n\tv270 = \"il2cpp_codegen_runtime_class_init\"(v267, v265, v98, v95, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\nL_0090:\n\tv273 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v117 @ X0_v25+D0]), v266, *([v262 @ X27_v4 (Il2CppMethodInfo)+C0]));\n\tv118 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X26_v2 (Il2CppMethodInfo)+C90]));\n\tv273.id = v60.octId;\n\tv278 = v273 + 0xB0;\n\t*([v273 @ X0_v31 (SpecialFluid)+B0]) = v60.headIds;\n\tv279 = 0xF3F1B4(v278, v60.headIds, *([v262 @ X27_v4 (Il2CppMethodInfo)+C0]), v243, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\t*([v273 @ X0_v31 (SpecialFluid)+B8]) = splitIndex;\n\tSpecialFluid::Init(v273, this, v254, v140, *([v118 @ X0_v33+108]));\n\tv119 = this.octopi;\n\tv284 = v119._version + 1;\n\tv119._version = v284;\n\tv91 = v119._items;\n\tv285 = System.Xml.ValidateNames;\n\tv289 = v119._size < v91.Length;\n\tv180 = ~v289;\n\tif (v180) goto L_00CD;\n\tv290 = v119._size + 1;\n\tv119._size = v290;\n\tv291 = v119._size << 3;\n\tv292 = v91 + v291;\n\tv293 = v292 + 0x20;\n\t*([v293 @ X0_v43]) = v273;\n\tv295 = 0xF3F1B4(v293, v273, v254, v140, *([v118 @ X0_v33+108]), v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tgoto L_00D2;\nL_00CD:\n\t;\n\tSystem.Collections.Generic.List`1<Octopus>::AddWithResize(v119, v273);\nL_00D2:\n\tv304 = this + 0x3B8;\n\tv305 = *([v285 @ X23_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv213 = *([v305 @ X8_v12+B8]);\n\t// 217 MakeStruct v149 @ AGGFF3554_2_v1 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v213 @ X8_v13], [v213 @ X8_v13+4]\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v304, v60.octId, v149);\n\treturn v273;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 135 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe Octopus AddOctopus(global::Unity.Mathematics.float2[] pos, int splitIndex)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_0030: Expected I, but got O
		//IL_004b: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01e3: Expected I, but got O
		//IL_0299: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02b9: Expected O, but got I
		//IL_02c6: Expected F4, but got O
		//IL_02db: Expected F4, but got I
		//IL_0253: Expected O, but got I
		//IL_0262: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass146_0 _003C_003Ec__DisplayClass146_1 = new FluidSolver._003C_003Ec__DisplayClass146_0();
		nint num4 = 0;
		nint num5 = 0;
		_003C_003Ec__DisplayClass146_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int nextUnusedFluidType = GetNextUnusedFluidType();
		int octId = IdGenerator.Next();
		_003C_003Ec__DisplayClass146_1.octId = octId;
		global::System.Collections.Generic.HashSet<int> headIds = new global::System.Collections.Generic.HashSet<int>();
		_003C_003Ec__DisplayClass146_1.headIds = headIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v2 (Il2CppMethodInfo)+D40]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(_003C_003Ec__DisplayClass146_1, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(pos, nextUnusedFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num6 = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		SpecialFluid specialFluid = default(SpecialFluid);
		specialFluid.id = _003C_003Ec__DisplayClass146_1.octId;
		_ = _003C_003Ec__DisplayClass146_1.headIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v33+108]");
		specialFluid.Init(this, hashSet, nextUnusedFluidType, (FluidCompute)0);
		global::System.Collections.Generic.List<Octopus> list = octopi;
		list.Add((Octopus)specialFluid);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = octopusHeadMidpoints;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X23_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v12+B8]");
		object obj7 = 0;
		global::Unity.Mathematics.float2 value = default(global::Unity.Mathematics.float2);
		value.x = (float)obj7;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+4]");
		value.y = 0f;
		nativeParallelHashMap[_003C_003Ec__DisplayClass146_1.octId] = value;
		return (Octopus)specialFluid;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000281")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3140", Offset = "0xFF3140", Length = "0x134")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x9A0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, octopus, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x940;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, octopus, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0xC58;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, octopus, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv77 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv78 = v77 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, octopus, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302AA0B]) = v43;\nL_0023:\n\t;\n\tv76 = System.Collections.Generic.HashSet`1<System.Int32>::Remove(this.usedFluidTypes, octopus.fluidType);\n\tv82 = SpecialFluid::OnSolverRemoveParticlesStart(octopus, octopus.particleIds, 0);\n\tFluidSolver::RemoveParticles(this, octopus.particleIds, 0);\n\tv118 = this + 0x3B8;\n\tv119 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Remove(v118, octopus.id);\n\tv122 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv125 = System.Collections.Generic.List`1<Octopus>::Remove(this.octopi, octopus);\n\tv128 = UnityEngine.Component::get_gameObject(octopus);\n\tv130 = *([v122 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv103 = *([v130 @ X0_v15+E0]) == 0;\n\tif (v103) goto L_0060;\n\tUnityEngine.Object::DestroyImmediate(v128);\n\treturn;\nL_0060:\n\tUnityEngine.Object::DestroyImmediate(v128);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 67 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemoveOctopus(Octopus octopus)
	{
		//IL_0058: Expected O, but got I
		//IL_0082: Expected I, but got O
		//IL_00b7: Expected O, but got I
		bool flag = usedFluidTypes.Remove(octopus.fluidType);
		octopus.OnSolverRemoveParticlesStart(octopus.particleIds, explode: false);
		RemoveParticles(octopus.particleIds);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = octopusHeadMidpoints;
		bool flag2 = nativeParallelHashMap.Remove(octopus.id);
		bool flag3 = octopi.Remove(octopus);
		global::UnityEngine.GameObject obj = octopus.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v15+E0]");
		if ((nint)0 != 0)
		{
			global::UnityEngine.Object.DestroyImmediate(obj);
		}
		else
		{
			global::UnityEngine.Object.DestroyImmediate(obj);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000282")]
	[global::Cpp2ILInjected.Address(RVA = "0x1002DDC", Offset = "0x1002DDC", Length = "0x134")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x9A0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, caterpillar, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x960;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, caterpillar, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0xC58;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, caterpillar, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv77 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv78 = v77 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, caterpillar, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302AA0C]) = v43;\nL_0023:\n\t;\n\tv76 = System.Collections.Generic.HashSet`1<System.Int32>::Remove(this.usedFluidTypes, caterpillar.fluidType);\n\tv82 = SpecialFluid::OnSolverRemoveParticlesStart(caterpillar, caterpillar.particleIds, 0);\n\tFluidSolver::RemoveParticles(this, caterpillar.particleIds, 0);\n\tv118 = this + 0x308;\n\tv119 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Remove(v118, caterpillar.id);\n\tv122 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv125 = System.Collections.Generic.List`1<Caterpillar>::Remove(this.caterpillars, caterpillar);\n\tv128 = UnityEngine.Component::get_gameObject(caterpillar);\n\tv130 = *([v122 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv103 = *([v130 @ X0_v15+E0]) == 0;\n\tif (v103) goto L_0060;\n\tUnityEngine.Object::DestroyImmediate(v128);\n\treturn;\nL_0060:\n\tUnityEngine.Object::DestroyImmediate(v128);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 67 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemoveCaterpillar(Caterpillar caterpillar)
	{
		//IL_0058: Expected O, but got I
		//IL_0082: Expected I, but got O
		//IL_00b7: Expected O, but got I
		bool flag = usedFluidTypes.Remove(caterpillar.fluidType);
		caterpillar.OnSolverRemoveParticlesStart(caterpillar.particleIds, explode: false);
		RemoveParticles(caterpillar.particleIds);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = caterpillarMidpoints;
		bool flag2 = nativeParallelHashMap.Remove(caterpillar.id);
		bool flag3 = caterpillars.Remove(caterpillar);
		global::UnityEngine.GameObject obj = caterpillar.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v15+E0]");
		if ((nint)0 != 0)
		{
			global::UnityEngine.Object.DestroyImmediate(obj);
		}
		else
		{
			global::UnityEngine.Object.DestroyImmediate(obj);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000283")]
	[global::Cpp2ILInjected.Address(RVA = "0x1002F10", Offset = "0x1002F10", Length = "0x43C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003B;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x968;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0x578;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv82 = Il2CppMethodInfo;\n\tv83 = v82 + 0x970;\n\tv84 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv203 = Il2CppMethodInfo;\n\tv204 = v203 + 0x580;\n\tv205 = \"il2cpp_codegen_initialize_runtime_metadata\"(v204, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv322 = Il2CppMethodInfo;\n\tv323 = v322 + 0x978;\n\tv324 = \"il2cpp_codegen_initialize_runtime_metadata\"(v323, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv383 = Il2CppMethodInfo;\n\tv384 = v383 + 0x588;\n\tv385 = \"il2cpp_codegen_initialize_runtime_metadata\"(v384, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv429 = Il2CppMethodInfo;\n\tv430 = v429 + 0x998;\n\tv431 = \"il2cpp_codegen_initialize_runtime_metadata\"(v430, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv435 = Il2CppMethodInfo;\n\tv436 = v435 + 0x4C8;\n\tv437 = \"il2cpp_codegen_initialize_runtime_metadata\"(v436, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv438 = Il2CppMethodInfo;\n\tv439 = v438 + 0x948;\n\tv440 = \"il2cpp_codegen_initialize_runtime_metadata\"(v439, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv447 = Il2CppMethodInfo;\n\tv448 = v447 + 0x950;\n\tv449 = \"il2cpp_codegen_initialize_runtime_metadata\"(v448, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv454 = Il2CppMethodInfo;\n\tv455 = v454 + 0xC28;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v455, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AA0D]) = v54;\nL_003B:\n\tv58 = 0;\n\tv73 = this.<ActiveCount>k__BackingField < 1;\n\tif (v73) goto L_004E;\n\tv78 = 0x274A2FC(this.regionHasHead, this.<ActiveCount>k__BackingField, v37, v110, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_004E:\n\tv217 = this.octopi;\n\tv86 = Il2CppMethodInfo;\n\tv88 = this + 0x1F8;\n\tv89 = Il2CppMethodInfo;\n\tv91 = Il2CppMethodInfo;\n\tgoto L_006A;\nL_005C:\n\tv188 = v188 + 1;\n\tv217 = this.octopi;\nL_006A:\n\tv156 = v188 >= v217._size;\n\tif (v156) goto L_017D;\n\tv325 = Il2CppMethodInfo;\n\tv271 = *([v325 @ X8_v8 (Il2CppMethodInfo)+950]);\n\tv192 = System.Collections.Generic.List`1<Octopus>::get_Item(v217, v188);\n\tv193 = FluidSolver::FindContiguousRegions(this, v192.particleIds);\n\tv446 = System.Collections.Generic.List`1<System.Collections.Generic.HashSet`1<System.Int32>>::GetEnumerator(v193);\nL_0084:\n\tv473 = Il2CppMethodInfo;\n\tv475 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v445 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv477 = v475 == 0;\n\tif (v477) goto L_FFFFFFFF;\n\tv313 = v452 == 0;\n\tif (v313) goto L_013D;\n\tv479 = Il2CppMethodInfo;\n\tv485 = System.Collections.Generic.HashSet`1::GetEnumerator /* +1 sharing this address */(v452, *([v479 @ X8_v21 (Il2CppMethodInfo)+998]));\nL_009D:\n\tv515 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v445 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>), *([v86 @ X23_v3 (Il2CppMethodInfo)+970]));\n\tv518 = v515 & 1;\n\tv519 = v518 == 0;\n\tif (v519) goto L_00B2;\n\tv499 = *([v89 @ X26_v3 (Il2CppMethodInfo)+C28]);\n\tv507 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v88, v452, &v498 @ stack_-A4_v9, *([v89 @ X26_v3 (Il2CppMethodInfo)+C28]));\n\tv525 = v507 & 1;\n\tv509 = v525 == 0;\n\tif (v509) goto L_009D;\n\tv496 = this.inOctopusHead;\n\tv510 = *([v496 @ X9_v11 (Unity.Collections.NativeArray`1<System.Boolean>)+v498 @ stack_-A4_v9]) == 0;\n\tif (v510) goto L_009D;\nL_00B2:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v58 @ stack_-A0_v1, *([v91 @ X25_v3 (Il2CppMethodInfo)+968]));\n\tgoto L_013F;\n\tgoto L_00C4;\n\tgoto L_0128;\nL_00C4:\n\tv532 = v515 & 1;\n\tv470 = v532 == 0;\n\tif (v470) goto L_0084;\n\tv533 = Il2CppMethodInfo;\n\tv539 = System.Collections.Generic.HashSet`1::GetEnumerator /* +1 sharing this address */(v452, *([v533 @ X8_v27 (Il2CppMethodInfo)+998]));\nL_00D5:\n\tv554 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v445 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>), *([v86 @ X23_v3 (Il2CppMethodInfo)+970]));\n\tv555 = v554 & 1;\n\tv556 = v555 == 0;\n\tif (v556) goto L_00E8;\n\tv110 = *([v89 @ X26_v3 (Il2CppMethodInfo)+C28]);\n\tv548 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v88, v452, &v541 @ stack_-A8_v9, *([v89 @ X26_v3 (Il2CppMethodInfo)+C28]));\n\tv558 = v548 & 1;\n\tv550 = v558 == 0;\n\tif (v550) goto L_00D5;\n\tv542 = this.regionHasHead;\n\t*([v542 @ X9_v10 (Unity.Collections.NativeArray`1<System.Boolean>)+v541 @ stack_-A8_v9]) = 1;\n\tgoto L_00D5;\nL_00E8:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v58 @ stack_-A0_v1, *([v91 @ X25_v3 (Il2CppMethodInfo)+968]));\n\tgoto L_0141;\n\tgoto L_0084;\n\tgoto L_FFFFFFFF;\n\tgoto L_0128;\n\tgoto L_00FB;\nL_00FB:\n\tX22 = X1;\n\tX28 = X0;\n\tC = X22 < 1;\n\tC = ~C;\n\tTEMP1 = X22 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X22 ^ 1;\n\tTEMP3 = X22 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_014A;\n\tX0 = X28;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0]);\n\tstack[20] = X8;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX28 = 0;\n\tgoto L_00E8;\n\tgoto L_0110;\nL_0110:\n\tX22 = X1;\n\tX28 = X0;\n\tC = X22 < 1;\n\tC = ~C;\n\tTEMP1 = X22 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X22 ^ 1;\n\tTEMP3 = X22 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0145;\n\tX0 = X28;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0]);\n\tstack[20] = X8;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX28 = 0;\n\tX22 = 0;\n\tgoto L_00B2;\nL_0128:\n\t;\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v445 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tgoto L_016F;\nL_0133:\n\tv170 = v99 == 0xD;\n\tif (v170) goto L_005C;\n\tv368 = v99 == 0;\n\tif (v368) goto L_005C;\n\tgoto L_017D;\nL_013D:\n\tv309 = new System.NullReferenceException();\n\tgoto L_017F;\nL_013F:\n\tv310 = new System.OutOfMemoryException();\n\tgoto L_017F;\nL_0141:\n\tv311 = new System.OutOfMemoryException();\n\tgoto L_017F;\n\tX22 = X1;\n\tX28 = X0;\nL_0145:\n\tX0 = &stack[20];\n\tX0 = 0xBF092C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_0156;\n\tX22 = X1;\n\tX28 = X0;\nL_014A:\n\tX0 = &stack[20];\n\tX0 = 0xBF092C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_0156;\n\tgoto L_0154;\n\tgoto L_0154;\n\tgoto L_0154;\n\tgoto L_0154;\n\tgoto L_0154;\n\tgoto L_0154;\n\tgoto L_0154;\nL_0154:\n\tX22 = X1;\n\tX28 = X0;\nL_0156:\n\tC = X22 < 1;\n\tC = ~C;\n\tTEMP1 = X22 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X22 ^ 1;\n\tTEMP3 = X22 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0183;\n\tX0 = X28;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX22 = *([X0]);\n\tstack[10] = X22;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX28 = 0;\n\tX0 = stack[18];\n\tX8 = X8 + 0x578;\n\tX1 = *([X8]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(X0, X1);\n\tif (TEMP) goto L_0133;\nL_016F:\n\tthrow System.OutOfMemoryException;\nL_017D:\n\treturn;\n\tv202 = new System.NullReferenceException();\nL_017F:\n\t// 383 Interrupt\n\tv321 = 0xD6F8(v310, v304,\n// ... truncated")]
	public void BuildOctopusRegionMap()
	{
		//IL_03e9: Expected O, but got I4
		//IL_0035: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_037c: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_01b1: Expected O, but got I
		object obj = 0;
		if (ActiveCount >= 1)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A2FC");
		}
		global::System.Collections.Generic.List<Octopus> list = octopi;
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		int num4 = 0;
		if (num4 >= list.Count)
		{
			return;
		}
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v8 (Il2CppMethodInfo)+950]");
		object obj3 = 0;
		Octopus octopus = list[num4];
		global::System.Collections.Generic.List<global::System.Collections.Generic.HashSet<int>> list2 = FindContiguousRegions(octopus.particleIds);
		global::System.Collections.Generic.List<global::System.Collections.Generic.HashSet<int>>.Enumerator enumerator = list2.GetEnumerator();
		global::System.Collections.Generic.List<object>.Enumerator enumerator3 = default(global::System.Collections.Generic.List<object>.Enumerator);
		global::System.Collections.Generic.List<object>.Enumerator enumerator2 = enumerator3;
		nint num6 = 0;
		if (enumerator3.MoveNext())
		{
			object obj4 = default(object);
			if (obj4 != null)
			{
				nint num7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C35B0 (System.Collections.Generic.HashSet`1::GetEnumerator, and 1 more at this address)");
				object obj6 = default(object);
				object obj5 = obj6;
				object obj7 = obj3;
				object obj8 = default(object);
				object obj11 = default(object);
				object obj12 = default(object);
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					int num8 = (int)((nint)obj8 & 1);
					bool flag = num8 == 0;
					object obj9 = obj5;
					object obj10 = obj7;
					if (flag)
					{
						break;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X26_v3 (Il2CppMethodInfo)+C28]");
					obj5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num9 = (int)((nint)obj11 & 1);
					bool flag2 = num9 == 0;
					obj7 = obj12;
					if (!flag2)
					{
						global::Unity.Collections.NativeArray<bool> nativeArray = inOctopusHead;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v11 (Unity.Collections.NativeArray`1<System.Boolean>)+v498 @ stack_-A4_v9]");
						bool flag3 = (nint)0 == 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X26_v3 (Il2CppMethodInfo)+C28]");
						obj9 = 0;
						obj10 = obj12;
						obj7 = obj12;
						if (!flag3)
						{
							break;
						}
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				global::System.OutOfMemoryException ex = new global::System.OutOfMemoryException();
				object obj13 = obj6;
				int num10 = 0;
				global::System.Collections.Generic.List<object>.Enumerator enumerator4 = enumerator2;
				object obj14 = obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v16 (Il2CppMethodInfo)+580]");
				object obj15 = 0;
				global::System.NullReferenceException ex2 = default(global::System.NullReferenceException);
				ex = (global::System.OutOfMemoryException)(object)ex2;
			}
			else
			{
				global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0DAC");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
			return;
		}
		int num11 = 13;
		enumerator3.Dispose();
		throw new global::System.OutOfMemoryException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000284")]
	[global::Cpp2ILInjected.Address(RVA = "0x100334C", Offset = "0x100334C", Length = "0x254")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0033;\n\tv37 = System.Collections.Generic.NullableComparer`1;\n\tv38 = v37 + 0xD10;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0x950;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv65 = Il2CppMethodInfo;\n\tv66 = v65 + 0x98;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv69 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv70 = v69 + 0xFD8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv132 = Il2CppMethodInfo;\n\tv133 = v132 + 0xC90;\n\tv134 = \"il2cpp_codegen_initialize_runtime_metadata\"(v133, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv137 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv138 = v137 + 0xA48;\n\tv139 = \"il2cpp_codegen_initialize_runtime_metadata\"(v138, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv213 = Il2CppMethodInfo;\n\tv214 = v213 + 0xD48;\n\tv215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v214, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv218 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv219 = v218 + 0xB80;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v219, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv57 = 1;\n\t*([302AA0E]) = v57;\nL_0033:\n\tv59 = new *([v32 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B80])();\n\tFluidSolver+<>c__DisplayClass150_0::.ctor(v59);\n\tv72 = System.Collections.Generic.NullableComparer`1;\n\tv74 = Il2CppMethodInfo;\n\tv78 = Il2CppMethodInfo;\n\tv81 = v59 + 0x10;\n\tv59.<>4__this = this;\n\tv83 = 0xF3F1B4(v81, this, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv136 = FluidSolver::GetNextUnusedFluidType(this);\n\tv141 = IdGenerator::Next();\n\tv59.id = v141;\n\tv217 = new *([v72 @ X23_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v217, v59, *([v74 @ X24_v2 (Il2CppMethodInfo)+D48]));\n\tv225 = FluidSolver::AddParticles(this, pos, v136, v217);\n\tgoto L_0060;\n\tv229 = \"il2cpp_codegen_runtime_class_init\"(v226, v110, v99, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_0060:\n\tv114 = Singleton`1::get_Instance /* +1 sharing this address */(*([v78 @ X25_v2 (Il2CppMethodInfo)+C90]));\n\tv233 = Il2CppMethodInfo;\n\tv237 = UnityEngine.Component::get_transform(this);\n\tgoto L_0075;\n\tv241 = \"il2cpp_codegen_runtime_class_init\"(v238, v236, v99, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_0075:\n\tv244 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v114 @ X0_v20+D8]), v237, *([v233 @ X26_v4 (Il2CppMethodInfo)+98]));\n\tv115 = Singleton`1::get_Instance /* +1 sharing this address */(*([v78 @ X25_v2 (Il2CppMethodInfo)+C90]));\n\tCaterpillar::Init(v244, this, v225, v136, *([v115 @ X0_v28+108]), v59.id);\n\tv116 = this.caterpillars;\n\tv250 = v116._version + 1;\n\tv116._version = v250;\n\tv86 = v116._items;\n\tv251 = v116._size < v86.Length;\n\tv171 = ~v251;\n\tif (v171) goto L_00A6;\n\tv252 = v116._size + 1;\n\tv116._size = v252;\n\tv253 = v116._size << 3;\n\tv254 = v86 + v253;\n\tv255 = v254 + 0x20;\n\t*([v255 @ X0_v34]) = v244;\n\tv257 = 0xF3F1B4(v255, v244, v225, v136, *([v115 @ X0_v28+108]), v59.id, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tgoto L_00B9;\nL_00A6:\n\t;\n\tSystem.Collections.Generic.List`1<Caterpillar>::AddWithResize(v116, v244);\nL_00B9:\n\treturn v244;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 116 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Caterpillar AddCaterpillar(global::Unity.Mathematics.float2[] pos)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_003c: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01d9: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass150_0 _003C_003Ec__DisplayClass150_1 = new FluidSolver._003C_003Ec__DisplayClass150_0();
		nint num3 = 0;
		nint num4 = 0;
		_003C_003Ec__DisplayClass150_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int nextUnusedFluidType = GetNextUnusedFluidType();
		int id = IdGenerator.Next();
		_003C_003Ec__DisplayClass150_1.id = id;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v2 (Il2CppMethodInfo)+D48]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(_003C_003Ec__DisplayClass150_1, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(pos, nextUnusedFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num5 = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v28+108]");
		Caterpillar caterpillar = default(Caterpillar);
		caterpillar.Init(this, hashSet, nextUnusedFluidType, (FluidCompute)0, _003C_003Ec__DisplayClass150_1.id);
		global::System.Collections.Generic.List<Caterpillar> list = caterpillars;
		list.Add(caterpillar);
		return caterpillar;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000285")]
	[global::Cpp2ILInjected.Address(RVA = "0x10035A0", Offset = "0x10035A0", Length = "0x254")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0033;\n\tv37 = System.Collections.Generic.NullableComparer`1;\n\tv38 = v37 + 0xD10;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0x7D8;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv65 = Il2CppMethodInfo;\n\tv66 = v65 + 0x90;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv69 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv70 = v69 + 0xFD8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv132 = Il2CppMethodInfo;\n\tv133 = v132 + 0xC90;\n\tv134 = \"il2cpp_codegen_initialize_runtime_metadata\"(v133, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv137 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv138 = v137 + 0xA48;\n\tv139 = \"il2cpp_codegen_initialize_runtime_metadata\"(v138, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv213 = Il2CppMethodInfo;\n\tv214 = v213 + 0xD50;\n\tv215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v214, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv218 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv219 = v218 + 0xB88;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v219, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv57 = 1;\n\t*([302AA0F]) = v57;\nL_0033:\n\tv59 = new *([v32 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B88])();\n\tFluidSolver+<>c__DisplayClass151_0::.ctor(v59);\n\tv72 = System.Collections.Generic.NullableComparer`1;\n\tv74 = Il2CppMethodInfo;\n\tv78 = Il2CppMethodInfo;\n\tv81 = v59 + 0x10;\n\tv59.<>4__this = this;\n\tv83 = 0xF3F1B4(v81, this, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv136 = FluidSolver::GetNextUnusedFluidType(this);\n\tv141 = IdGenerator::Next();\n\tv59.id = v141;\n\tv217 = new *([v72 @ X23_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v217, v59, *([v74 @ X24_v2 (Il2CppMethodInfo)+D50]));\n\tv225 = FluidSolver::AddParticles(this, pos, v136, v217);\n\tgoto L_0060;\n\tv229 = \"il2cpp_codegen_runtime_class_init\"(v226, v110, v99, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_0060:\n\tv114 = Singleton`1::get_Instance /* +1 sharing this address */(*([v78 @ X25_v2 (Il2CppMethodInfo)+C90]));\n\tv233 = Il2CppMethodInfo;\n\tv237 = UnityEngine.Component::get_transform(this);\n\tgoto L_0075;\n\tv241 = \"il2cpp_codegen_runtime_class_init\"(v238, v236, v99, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_0075:\n\tv244 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v114 @ X0_v20+E0]), v237, *([v233 @ X26_v4 (Il2CppMethodInfo)+90]));\n\tv115 = Singleton`1::get_Instance /* +1 sharing this address */(*([v78 @ X25_v2 (Il2CppMethodInfo)+C90]));\n\tBee::Init(v244, this, v225, v136, *([v115 @ X0_v28+108]), v59.id);\n\tv116 = this.bees;\n\tv250 = v116._version + 1;\n\tv116._version = v250;\n\tv86 = v116._items;\n\tv251 = v116._size < v86.Length;\n\tv171 = ~v251;\n\tif (v171) goto L_00A6;\n\tv252 = v116._size + 1;\n\tv116._size = v252;\n\tv253 = v116._size << 3;\n\tv254 = v86 + v253;\n\tv255 = v254 + 0x20;\n\t*([v255 @ X0_v34]) = v244;\n\tv257 = 0xF3F1B4(v255, v244, v225, v136, *([v115 @ X0_v28+108]), v59.id, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tgoto L_00B9;\nL_00A6:\n\t;\n\tSystem.Collections.Generic.List`1<Bee>::AddWithResize(v116, v244);\nL_00B9:\n\treturn v244;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 116 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Bee AddBee(global::Unity.Mathematics.float2[] pos)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_003c: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01d9: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass151_0 _003C_003Ec__DisplayClass151_1 = new FluidSolver._003C_003Ec__DisplayClass151_0();
		nint num3 = 0;
		nint num4 = 0;
		_003C_003Ec__DisplayClass151_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int nextUnusedFluidType = GetNextUnusedFluidType();
		int id = IdGenerator.Next();
		_003C_003Ec__DisplayClass151_1.id = id;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v2 (Il2CppMethodInfo)+D50]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(_003C_003Ec__DisplayClass151_1, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(pos, nextUnusedFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num5 = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v28+108]");
		Bee bee = default(Bee);
		bee.Init(this, hashSet, nextUnusedFluidType, (FluidCompute)0, _003C_003Ec__DisplayClass151_1.id);
		global::System.Collections.Generic.List<Bee> list = bees;
		list.Add(bee);
		return bee;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000286")]
	[global::Cpp2ILInjected.Address(RVA = "0x10037F4", Offset = "0x10037F4", Length = "0x134")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x9A0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, bee, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x7E8;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, bee, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0xC58;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, bee, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv77 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv78 = v77 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, bee, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302AA10]) = v43;\nL_0023:\n\t;\n\tv76 = System.Collections.Generic.HashSet`1<System.Int32>::Remove(this.usedFluidTypes, bee.fluidType);\n\tv82 = SpecialFluid::OnSolverRemoveParticlesStart(bee, bee.particleIds, 0);\n\tFluidSolver::RemoveParticles(this, bee.particleIds, 0);\n\tv118 = this + 0x330;\n\tv119 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Remove(v118, bee.id);\n\tv122 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv125 = System.Collections.Generic.List`1<Bee>::Remove(this.bees, bee);\n\tv128 = UnityEngine.Component::get_gameObject(bee);\n\tv130 = *([v122 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv103 = *([v130 @ X0_v15+E0]) == 0;\n\tif (v103) goto L_0060;\n\tUnityEngine.Object::DestroyImmediate(v128);\n\treturn;\nL_0060:\n\tUnityEngine.Object::DestroyImmediate(v128);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 67 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemoveBee(Bee bee)
	{
		//IL_0058: Expected O, but got I
		//IL_0082: Expected I, but got O
		//IL_00b7: Expected O, but got I
		bool flag = usedFluidTypes.Remove(bee.fluidType);
		bee.OnSolverRemoveParticlesStart(bee.particleIds, explode: false);
		RemoveParticles(bee.particleIds);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = beeMidpoints;
		bool flag2 = nativeParallelHashMap.Remove(bee.id);
		bool flag3 = bees.Remove(bee);
		global::UnityEngine.GameObject obj = bee.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v15+E0]");
		if ((nint)0 != 0)
		{
			global::UnityEngine.Object.DestroyImmediate(obj);
		}
		else
		{
			global::UnityEngine.Object.DestroyImmediate(obj);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000287")]
	[global::Cpp2ILInjected.Address(RVA = "0x1003928", Offset = "0x1003928", Length = "0x254")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0033;\n\tv37 = System.Collections.Generic.NullableComparer`1;\n\tv38 = v37 + 0xD10;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0x270;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv65 = Il2CppMethodInfo;\n\tv66 = v65 + 0xE0;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv69 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv70 = v69 + 0xFD8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv132 = Il2CppMethodInfo;\n\tv133 = v132 + 0xC90;\n\tv134 = \"il2cpp_codegen_initialize_runtime_metadata\"(v133, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv137 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv138 = v137 + 0xA48;\n\tv139 = \"il2cpp_codegen_initialize_runtime_metadata\"(v138, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv213 = Il2CppMethodInfo;\n\tv214 = v213 + 0xD58;\n\tv215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v214, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv218 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv219 = v218 + 0xB90;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v219, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv57 = 1;\n\t*([302AA11]) = v57;\nL_0033:\n\tv59 = new *([v32 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B90])();\n\tFluidSolver+<>c__DisplayClass153_0::.ctor(v59);\n\tv72 = System.Collections.Generic.NullableComparer`1;\n\tv74 = Il2CppMethodInfo;\n\tv78 = Il2CppMethodInfo;\n\tv81 = v59 + 0x10;\n\tv59.<>4__this = this;\n\tv83 = 0xF3F1B4(v81, this, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv136 = FluidSolver::GetNextUnusedFluidType(this);\n\tv141 = IdGenerator::Next();\n\tv59.spongeId = v141;\n\tv217 = new *([v72 @ X23_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v217, v59, *([v74 @ X24_v2 (Il2CppMethodInfo)+D58]));\n\tv225 = FluidSolver::AddParticles(this, pos, v136, v217);\n\tgoto L_0060;\n\tv229 = \"il2cpp_codegen_runtime_class_init\"(v226, v110, v99, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_0060:\n\tv114 = Singleton`1::get_Instance /* +1 sharing this address */(*([v78 @ X25_v2 (Il2CppMethodInfo)+C90]));\n\tv233 = Il2CppMethodInfo;\n\tv237 = UnityEngine.Component::get_transform(this);\n\tgoto L_0075;\n\tv241 = \"il2cpp_codegen_runtime_class_init\"(v238, v236, v99, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_0075:\n\tv244 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v114 @ X0_v20+C8]), v237, *([v233 @ X26_v4 (Il2CppMethodInfo)+E0]));\n\tv115 = Singleton`1::get_Instance /* +1 sharing this address */(*([v78 @ X25_v2 (Il2CppMethodInfo)+C90]));\n\tSponge::Init(v244, this, v225, v136, *([v115 @ X0_v28+108]), v59.spongeId);\n\tv116 = this.sponges;\n\tv250 = v116._version + 1;\n\tv116._version = v250;\n\tv86 = v116._items;\n\tv251 = v116._size < v86.Length;\n\tv171 = ~v251;\n\tif (v171) goto L_00A6;\n\tv252 = v116._size + 1;\n\tv116._size = v252;\n\tv253 = v116._size << 3;\n\tv254 = v86 + v253;\n\tv255 = v254 + 0x20;\n\t*([v255 @ X0_v34]) = v244;\n\tv257 = 0xF3F1B4(v255, v244, v225, v136, *([v115 @ X0_v28+108]), v59.spongeId, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tgoto L_00B9;\nL_00A6:\n\t;\n\tSystem.Collections.Generic.List`1<Sponge>::AddWithResize(v116, v244);\nL_00B9:\n\treturn v244;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 116 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Sponge AddSponge(global::Unity.Mathematics.float2[] pos)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_003c: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01d9: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass153_0 _003C_003Ec__DisplayClass153_1 = new FluidSolver._003C_003Ec__DisplayClass153_0();
		nint num3 = 0;
		nint num4 = 0;
		_003C_003Ec__DisplayClass153_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int nextUnusedFluidType = GetNextUnusedFluidType();
		int spongeId = IdGenerator.Next();
		_003C_003Ec__DisplayClass153_1.spongeId = spongeId;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v2 (Il2CppMethodInfo)+D58]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(_003C_003Ec__DisplayClass153_1, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(pos, nextUnusedFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num5 = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v28+108]");
		Sponge sponge = default(Sponge);
		sponge.Init(this, hashSet, nextUnusedFluidType, (FluidCompute)0, _003C_003Ec__DisplayClass153_1.spongeId);
		global::System.Collections.Generic.List<Sponge> list = sponges;
		list.Add(sponge);
		return sponge;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000288")]
	[global::Cpp2ILInjected.Address(RVA = "0x1003B7C", Offset = "0x1003B7C", Length = "0xF4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x280;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, sponge, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0xC58;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, sponge, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv63 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv64 = v63 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v64, sponge, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302AA12]) = v43;\nL_001D:\n\t;\n\tFluidSolver::RemoveParticles(this, sponge.particleIds, 0);\n\tv65 = this + 0x3A8;\n\tv66 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Remove(v65, sponge.id);\n\tv99 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv102 = System.Collections.Generic.List`1<Sponge>::Remove(this.sponges, sponge);\n\tv105 = UnityEngine.Component::get_gameObject(sponge);\n\tv107 = *([v99 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv82 = *([v107 @ X0_v11+E0]) == 0;\n\tif (v82) goto L_004E;\n\tUnityEngine.Object::Destroy(v105);\n\treturn;\nL_004E:\n\tUnityEngine.Object::Destroy(v105);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemoveSponge(Sponge sponge)
	{
		//IL_0022: Expected O, but got I
		//IL_004c: Expected I, but got O
		//IL_0081: Expected O, but got I
		RemoveParticles(sponge.particleIds);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = spongeMidpoints;
		bool flag = nativeParallelHashMap.Remove(sponge.id);
		bool flag2 = sponges.Remove(sponge);
		global::UnityEngine.GameObject obj = sponge.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v11+E0]");
		if ((nint)0 != 0)
		{
			global::UnityEngine.Object.Destroy(obj);
		}
		else
		{
			global::UnityEngine.Object.Destroy(obj);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000289")]
	[global::Cpp2ILInjected.Address(RVA = "0x1003C70", Offset = "0x1003C70", Length = "0x1C0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0024;\n\tv31 = System.Collections.Generic.NullableComparer`1;\n\tv32 = v31 + 0xD10;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, pos, type, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x9F0;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, pos, type, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv58 = Il2CppMethodInfo;\n\tv59 = v58 + 0xD60;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, pos, type, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv63 = v62 + 0xB98;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, pos, type, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AA13]) = v50;\nL_0024:\n\tv52 = new *([v26 @ X23_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B98])();\n\tFluidSolver+<>c__DisplayClass155_0::.ctor(v52);\n\tv65 = v52 + 0x10;\n\tv52.<>4__this = this;\n\tv67 = 0xF3F1B4(v65, this, type, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv101 = ~this.isClumped;\n\tif (v101) goto L_0075;\n\tv102 = System.Collections.Generic.NullableComparer`1;\n\tv104 = Il2CppMethodInfo;\n\tv106 = IdGenerator::Next();\n\tv52.clumpId = v106;\n\tv180 = new *([v102 @ X23_v6 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v180, v52, *([v104 @ X24_v4 (Il2CppMethodInfo)+D60]));\n\tv212 = FluidSolver::AddParticles(this, pos, type, v180);\n\tv216 = &v76 @ stack_-50_v5 (Clump) + 8;\n\tv217 = 0xF3F1B4(v216, v212, type, v180, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv86 = this.clumps;\n\tv221 = v86._version + 1;\n\tv86._version = v221;\n\tv70 = v86._items;\n\tv222 = v86._size < v70.Length;\n\tv194 = ~v222;\n\tif (v194) goto L_007E;\n\tv207 = v86._size + 1;\n\tv86._size = v207;\n\tv186 = v86._size << 4;\n\tv223 = v70 + v186;\n\tv224 = v223 + 0x28;\n\t*([v224 @ X0_v23]) = v212;\n\t*([v224 @ X0_v23-8]) = v76;\n\tv204 = 0xF3F1B4(v224, 0, type, v180, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_008A;\nL_0075:\n\tv111 = FluidSolver::AddParticles(this, pos, type, 0);\n\tgoto L_008A;\nL_007E:\n\tSystem.Collections.Generic.List`1<Clump>::AddWithResize(v86, v76);\nL_008A:\n\treturn v208;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 87 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Clump AddClump(global::Unity.Mathematics.float2[] pos, int type)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_005f: Expected I, but got O
		//IL_00c4: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_018d: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass155_0 _003C_003Ec__DisplayClass155_1 = new FluidSolver._003C_003Ec__DisplayClass155_0();
		_003C_003Ec__DisplayClass155_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		if (isClumped)
		{
			nint num3 = 0;
			int clumpId = IdGenerator.Next();
			_003C_003Ec__DisplayClass155_1.clumpId = clumpId;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X24_v4 (Il2CppMethodInfo)+D60]");
			global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(_003C_003Ec__DisplayClass155_1, (global::System.IntPtr)0);
			global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(pos, type, onInit);
			Clump clump = default(Clump);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::System.Collections.Generic.List<Clump> list = clumps;
			int version = list._version + 1;
			list._version = version;
			Clump[] items = list._items;
			if (list.Count < items.Length)
			{
				int size = list.Count + 1;
				list._size = size;
				int num4 = list.Count << 4;
				object obj3 = (nint)items + num4;
				object obj4 = (nint)obj3 + 40;
				obj4 = hashSet;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				return clump;
			}
			list.Add(clump);
			return clump;
		}
		global::System.Collections.Generic.HashSet<int> hashSet2 = AddParticles(pos, type);
		return default(Clump);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600028A")]
	[global::Cpp2ILInjected.Address(RVA = "0x1003E30", Offset = "0x1003E30", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0xA00;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, clump, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv59 = Il2CppMethodInfo;\n\tv60 = v59 + 0xC58;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, clump, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AA14]) = v50;\nL_0024:\n\tv58 = FluidSolver::HandleRemove(this, methodInfo, 0, 1, 0.2f);\n\tv64 = UnityEngine.MonoBehaviour::StartCoroutine(this, v58);\n\tv65 = this + 0x3A8;\n\tv68 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Remove(v65, clump);\n\tv84 = System.Collections.Generic.List`1<Clump>::Remove(this.clumps, clump);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemoveClump(Clump clump)
	{
		//IL_002f: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_005a: Expected I4, but got O
		global::System.IntPtr intPtr = default(global::System.IntPtr);
		global::System.Collections.IEnumerator routine = HandleRemove((global::System.Collections.Generic.HashSet<int>)(nint)intPtr);
		global::UnityEngine.Coroutine coroutine = StartCoroutine(routine);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = spongeMidpoints;
		bool flag = nativeParallelHashMap.Remove((int)clump);
		bool flag2 = clumps.Remove(clump);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600028B")]
	[global::Cpp2ILInjected.Address(RVA = "0x1003EF8", Offset = "0x1003EF8", Length = "0x174")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = 0x302A000;\n\tgoto L_0023;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x968;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, particleIds, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x970;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, particleIds, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x978;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, particleIds, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv77 = Il2CppMethodInfo;\n\tv78 = v77 + 0x998;\n\tv79 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, particleIds, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv111 = Il2CppMethodInfo;\n\tv112 = v111 + 0xC28;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v112, particleIds, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302AA15]) = v47;\nL_0023:\n\tv48 = 0;\n\tv52 = v120 == 0;\n\tif (v52) goto L_0059;\n\tv58 = Il2CppMethodInfo;\n\tv60 = Il2CppMethodInfo;\n\tv62 = Il2CppMethodInfo;\n\tv68 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v120);\n\tv75 = this + 0x1F8;\nL_003C:\n\tv99 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v48 @ stack_-58_v1, *([v58 @ X22_v3 (Il2CppMethodInfo)+970]));\n\tv113 = v99 & 1;\n\tv114 = v113 == 0;\n\tif (v114) goto L_004E;\n\tv92 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v75, 0, &v84 @ stack_-5C_v4, *([v60 @ X23_v3 (Il2CppMethodInfo)+C28]));\n\tv137 = v92 & 1;\n\tv94 = v137 == 0;\n\tif (v94) goto L_003C;\n\tv82 = this.isHoneyCoated;\n\t*([v82 @ X9_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+v84 @ stack_-5C_v4]) = 1;\n\tgoto L_003C;\nL_004E:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v48 @ stack_-58_v1, *([v62 @ X21_v4 (Il2CppMethodInfo)+968]));\nL_0058:\n\treturn;\nL_0059:\n\tv69 = new System.NullReferenceException();\n\tgoto L_0065;\nL_0065:\n\tv110 = v120 != 1;\n\tif (v110) goto L_0075;\n\tv116 = 0x274A080(v69, v120, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv134 = 0x274A098(v116, v120, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v161, *([v22 @ X21_v1]));\n\tv125 = *([v116 @ X0_v10]) == 0;\n\tif (v125) goto L_0058;\n\tv123 = new System.OutOfMemoryException();\nL_0075:\n\tv129 = 0xBF092C(&v119 @ stack_-70, *([v22 @ X21_v1]), methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv136 = 0x27498DC(v126, *([v22 @ X21_v1]), methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv182 = 0xD6F8(v136, *([v22 @ X21_v1]), methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\treturn;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddHoneyCoating(global::System.Collections.Generic.HashSet<int> particleIds)
	{
		//IL_0009: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_003a: Expected O, but got I
		object obj = 50503680;
		object obj2 = 0;
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		if (hashSet != null)
		{
			nint num = 0;
			nint num2 = 0;
			nint num3 = 0;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			object obj4 = default(object);
			object obj5 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj4 & 1) == 0)
				{
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
				if ((int)((nint)obj5 & 1) != 0)
				{
					global::Unity.Collections.NativeArray<bool> nativeArray = isHoneyCoated;
					_ = 1;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag = (nint)hashSet != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			object obj7 = obj6;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600028C")]
	[global::Cpp2ILInjected.Address(RVA = "0x100406C", Offset = "0x100406C", Length = "0x1F0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x968;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x970;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv140 = Il2CppMethodInfo;\n\tv141 = v140 + 0x978;\n\tv142 = \"il2cpp_codegen_initialize_runtime_metadata\"(v141, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv146 = Il2CppMethodInfo;\n\tv147 = v146 + 0x998;\n\tv148 = \"il2cpp_codegen_initialize_runtime_metadata\"(v147, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv179 = Il2CppMethodInfo;\n\tv180 = v179 + 0xC28;\n\tv181 = \"il2cpp_codegen_initialize_runtime_metadata\"(v180, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv198 = Il2CppMethodInfo;\n\tv199 = v198 + 0xC80;\n\tv200 = \"il2cpp_codegen_initialize_runtime_metadata\"(v199, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv208 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv209 = v208 + 0xA40;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v209, particleIds, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302AA16]) = v51;\nL_002B:\n\tv52 = 0;\n\tv56 = particleIds == 0;\n\tif (v56) goto L_007E;\n\tv62 = Il2CppMethodInfo;\n\tv64 = Il2CppMethodInfo;\n\tv124 = Il2CppMethodInfo + 0xC80;\n\tv70 = Il2CppMethodInfo;\n\tv122 = Il2CppMethodInfo + 0x968;\n\tv76 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(particleIds);\n\tv145 = this + 0x1F8;\nL_0047:\n\tv167 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v52 @ stack_-68_v1, *([v62 @ X25_v4 (Il2CppMethodInfo)+970]));\n\tv182 = v167 & 1;\n\tv183 = v182 == 0;\n\tif (v183) goto L_0059;\n\tv160 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v145, 0, &v152 @ stack_-6C_v5, *([v64 @ X26_v4 (Il2CppMethodInfo)+C28]));\n\tv210 = v160 & 1;\n\tv162 = v210 == 0;\n\tif (v162) goto L_0047;\n\tv219 = this.isHoneyCoated;\n\t*([v219 @ X9_v6 (Unity.Collections.NativeArray`1<System.Boolean>)+v152 @ stack_-6C_v5]) = 0;\n\tv150 = this.isStatic;\n\t*([v150 @ X9_v7 (Unity.Collections.NativeArray`1<System.Boolean>)+v152 @ stack_-6C_v5]) = 0;\n\tgoto L_0047;\nL_0059:\n\tv188 = *([v70 @ X24_v4 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v52 @ stack_-68_v1, *([v70 @ X24_v4 (Il2CppMethodInfo)+968]));\nL_0060:\n\tgoto L_0063;\n\tv220 = \"il2cpp_codegen_runtime_class_init\"(v215, v120, v110, v112, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\nL_0063:\n\tv132 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X22_v2]));\n\tv134 = v132 == 0;\n\tif (v134) goto L_007E;\n\tCollectionManager::OnRemoveHoney(v132, particleIds);\n\tv261 = this.OnRemoveHoneyCoating;\n\tv259 = this.OnRemoveHoneyCoating == 0;\n\tif (v259) goto L_007D;\n\tv261.invoke_impl(v277, v261.method_code, particleIds, 1, v261.method, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\nL_007D:\n\treturn;\nL_007E:\n\tv139 = new System.NullReferenceException();\n\tgoto L_008A;\nL_008A:\n\tv178 = v188 != 1;\n\tif (v178) goto L_009A;\n\tv185 = 0x274A080(v139, v188, v110, *([v64 @ X26_v4 (Il2CppMethodInfo)+C28]), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv205 = 0x274A098(v185, v188, v110, *([v64 @ X26_v4 (Il2CppMethodInfo)+C28]), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv188 = *([v122 @ X24_v2]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v52 @ stack_-68_v1, *([v122 @ X24_v2]));\n\tv193 = *([v185 @ X0_v11]) == 0;\n\tif (v193) goto L_0060;\n\tv191 = new System.OutOfMemoryException();\nL_009A:\n\tv197 = 0xBF092C(&v118 @ stack_-80 (System.Int32), v188, v110, *([v64 @ X26_v4 (Il2CppMethodInfo)+C28]), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv207 = 0x27498DC(v194, v188, v110, *([v64 @ X26_v4 (Il2CppMethodInfo)+C28]), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv218 = 0xD6F8(v207, v188, v110, *([v64 @ X26_v4 (Il2CppMethodInfo)+C28]), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\treturn;\n// 84 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void RemoveHoneyCoating(global::System.Collections.Generic.HashSet<int> particleIds)
	{
		//IL_0201: Expected O, but got I4
		//IL_001e: Expected O, but got I
		//IL_0030: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_01cb: Expected I4, but got O
		//IL_007e: Expected I, but got O
		//IL_01ea: Expected I4, but got O
		//IL_00b4: Expected I, but got O
		object obj = 0;
		bool flag = particleIds == null;
		global::System.Collections.Generic.HashSet<int> hashSet = particleIds;
		object obj3 = default(object);
		if (!flag)
		{
			nint num = 0;
			nint num2 = 0;
			object obj2 = (nint)0 + (nint)3200;
			nint num3 = 0;
			obj3 = (nint)0 + (nint)2408;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = particleIds.GetEnumerator();
			object obj5 = default(object);
			object obj6 = default(object);
			object obj7 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj5 & 1) == 0)
				{
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
				int num4 = (int)((nint)obj6 & 1);
				bool flag2 = num4 == 0;
				nint num5 = (nint)obj7;
				if (!flag2)
				{
					global::Unity.Collections.NativeArray<bool> nativeArray = isHoneyCoated;
					_ = 0;
					global::Unity.Collections.NativeArray<bool> nativeArray2 = isStatic;
					_ = 0;
					num5 = (nint)obj7;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X24_v4 (Il2CppMethodInfo)+968]");
			hashSet = (global::System.Collections.Generic.HashSet<int>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			int num6 = 0;
			goto IL_00e6;
		}
		goto IL_0152;
		IL_0152:
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag3 = (nint)hashSet != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag3)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			hashSet = (global::System.Collections.Generic.HashSet<int>)obj3;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj8 = default(object);
			bool flag4 = obj8 == null;
			int num6 = (int)obj8;
			if (flag4)
			{
				goto IL_00e6;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num6 = (int)obj8;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
		return;
		IL_00e6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		CollectionManager collectionManager = default(CollectionManager);
		if ((object)collectionManager != null)
		{
			collectionManager.OnRemoveHoney(particleIds);
			global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> onRemoveHoneyCoating = OnRemoveHoneyCoating;
			if (OnRemoveHoneyCoating != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v261.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
		}
		goto IL_0152;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600028D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5028", Offset = "0xFF5028", Length = "0x210")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv28 = System.Collections.Generic.NullableComparer`1;\n\tv30 = Il2CppMethodInfo;\n\tgoto L_0031;\n\tv37 = System.Collections.Generic.NullableComparer`1;\n\tv38 = v37 + 0xD10;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0x570;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0xCF8;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0xE8;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv83 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv84 = v83 + 0xFD8;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv91 = Il2CppMethodInfo;\n\tv92 = v91 + 0xC90;\n\tv93 = \"il2cpp_codegen_initialize_runtime_metadata\"(v92, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv98 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv99 = v98 + 0xA48;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, pos, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv57 = 1;\n\t*([302AA17]) = v57;\nL_0031:\n\tv58 = Il2CppMethodInfo;\n\tv61 = FluidSolver::GetNextUnusedFluidType(this);\n\tv67 = new *([v28 @ X22_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v67, this, *([v30 @ X25_v1 (Il2CppMethodInfo)+570]));\n\tv82 = FluidSolver::AddParticles(this, pos, v61, v67);\n\tgoto L_004A;\n\tv94 = \"il2cpp_codegen_runtime_class_init\"(v87, v79, v80, v81, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_004A:\n\tv97 = Singleton`1::get_Instance /* +1 sharing this address */(*([v58 @ X24_v1 (Il2CppMethodInfo)+C90]));\n\tv103 = Il2CppMethodInfo;\n\tv108 = UnityEngine.Component::get_transform(this);\n\tgoto L_005F;\n\tv149 = \"il2cpp_codegen_runtime_class_init\"(v146, v107, v80, v81, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\nL_005F:\n\tv152 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v97 @ X0_v11+C0]), v108, *([v103 @ X25_v4 (Il2CppMethodInfo)+E8]));\n\tv127 = Singleton`1::get_Instance /* +1 sharing this address */(*([v58 @ X24_v1 (Il2CppMethodInfo)+C90]));\n\tv141 = *([v152 @ X0_v19 (Water)]);\n\tv221 = SpecialFluid::Init(v152, this, v82, v61, *([v127 @ X0_v21+108]));\n\tv128 = Singleton`1::get_Instance /* +1 sharing this address */(*([v58 @ X24_v1 (Il2CppMethodInfo)+C90]));\n\tv129 = *([v128 @ X0_v25+A8]);\n\tv226 = *([v129 @ X0_v26+1C]) + 1;\n\t*([v129 @ X0_v26+1C]) = v226;\n\tv114 = *([v129 @ X0_v26+10]);\n\tv227 = *([v129 @ X0_v26+18]) < *([v114 @ X9_v5+18]);\n\tv182 = ~v227;\n\tif (v182) goto L_0095;\n\tv228 = *([v129 @ X0_v26+18]) + 1;\n\t*([v129 @ X0_v26+18]) = v228;\n\tv229 = *([v129 @ X0_v26+18]) << 3;\n\tv230 = v114 + v229;\n\tv231 = v230 + 0x20;\n\t*([v231 @ X0_v30]) = v152;\n\tv233 = 0xF3F1B4(v231, v152, v82, v61, *([v127 @ X0_v21+108]), *([v141 @ X8_v6 (Il2CppClass<Water>)+1A0]), v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tgoto L_00A6;\nL_0095:\n\t;\n\tSystem.Collections.Generic.List`1<System.Object>::AddWithResize(v129, v152);\nL_00A6:\n\treturn v152;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 106 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Water AddWaterParticles(global::Unity.Mathematics.float2[] pos)
	{
		//IL_000e: Expected I, but got O
		//IL_0079: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0172: Expected O, but got I
		nint num2 = 0;
		nint num3 = 0;
		int nextUnusedFluidType = GetNextUnusedFluidType();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X25_v1 (Il2CppMethodInfo)+570]");
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(this, (global::System.IntPtr)0);
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(pos, nextUnusedFluidType, onInit);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num4 = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		Water water = default(Water);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v21+108]");
		water.Init(this, hashSet, nextUnusedFluidType, (FluidCompute)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v25+A8]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+1C]");
		object obj2 = (nint)0 + (nint)1;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+10]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+18]");
		nint num6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v5+18]");
		if (num6 < 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+18]");
			object obj4 = (nint)0 + (nint)1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+18]");
			int num7 = (int)((nint)0 << 3);
			object obj5 = (nint)obj3 + num7;
			object obj6 = (nint)obj5 + 32;
			obj6 = water;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
		else
		{
			((global::System.Collections.Generic.List<object>)obj).Add((object)water);
		}
		return water;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600028E")]
	[global::Cpp2ILInjected.Address(RVA = "0x100425C", Offset = "0x100425C", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v22);\n\tv35 = this.<ActiveCount>k__BackingField < 1;\n\tif (v35) goto L_0049;\n\tv79 = this.fishIds;\n\tv38 = this.<ActiveCount>k__BackingField << 3;\n\tgoto L_002D;\nL_0021:\n\tv80 = v80 + 8;\n\tv61 = v38 == v80;\n\tif (v61) goto L_0049;\nL_002D:\n\tv79 = v79 + 4;\n\tv51 = *([v79 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)]) != fishId;\n\tif (v51) goto L_0021;\n\tv102 = this.deltaVel + v80;\n\tv105 = impulse + *([v102 @ X11_v5]);\n\tv106 = impulse.y + *([v102 @ X11_v5+4]);\n\t*([v102 @ X11_v5]) = v105;\n\t*([v102 @ X11_v5+4]) = v106;\n\tgoto L_0021;\nL_0049:\n\treturn;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void ApplyImpulseToFish(int fishId, global::Unity.Mathematics.float2 impulse)
	{
		//IL_000c: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00fa: Expected O, but got F4
		_lastJob.Complete();
		if (ActiveCount < 1)
		{
			return;
		}
		global::Unity.Collections.NativeArray<int> nativeArray = fishIds;
		int num = ActiveCount << 3;
		int num2 = 0;
		global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
		do
		{
			nativeArray = (global::Unity.Collections.NativeArray<int>)(nativeArray + 4);
			if ((nint)nativeArray == fishId)
			{
				object obj = deltaVel + num2;
				float num3 = float5.x + (float)obj;
				float num4 = impulse.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X11_v5+4]");
				float num5 = num4 + 0f;
				obj = num3;
			}
			num2 += 8;
		}
		while (num != num2);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600028F")]
	[global::Cpp2ILInjected.Address(RVA = "0x10042E8", Offset = "0x10042E8", Length = "0x5C4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv40 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_003B;\n\tv45 = System.Collections.Generic.NullableComparer`1;\n\tv46 = v45 + 0xD10;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv66 = Il2CppMethodInfo;\n\tv67 = v66 + 0xF50;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv71 = Il2CppMethodInfo;\n\tv72 = v71 + 0xA0;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv75 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv76 = v75 + 0xFD8;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv242 = Il2CppMethodInfo;\n\tv243 = v242 + 0xC90;\n\tv244 = \"il2cpp_codegen_initialize_runtime_metadata\"(v243, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv247 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv248 = v247 + 0xA48;\n\tv249 = \"il2cpp_codegen_initialize_runtime_metadata\"(v248, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv333 = Il2CppMethodInfo;\n\tv334 = v333 + 0xD68;\n\tv335 = \"il2cpp_codegen_initialize_runtime_metadata\"(v334, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv338 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv339 = v338 + 0xBA0;\n\tv340 = \"il2cpp_codegen_initialize_runtime_metadata\"(v339, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv343 = CollectParticleData[];\n\tv344 = v343 + 0x718;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v344, isBig, methodInfo, v49, v50, v51, v52, v53, pos, v0, v54, v55, v56, v57, v58, v59);\n\tv63 = 1;\n\t*([302AA31]) = v63;\nL_003B:\n\tv65 = new *([v40 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BA0])();\n\tFluidSolver+<>c__DisplayClass161_0::.ctor(v65);\n\tv78 = CollectParticleData[];\n\tv81 = v65 + 0x10;\n\tv65.<>4__this = this;\n\tv84 = 0xF3F1B4(v81, this, methodInfo, v49, v50, v51, v52, v53, pos, pos.y, v54, v55, v56, v57, v58, v59);\n\tv246 = IdGenerator::Next();\n\tv65.fishId = v246;\n\tv251 = FluidSolver::GetNextUnusedFluidType(this);\n\tv337 = \"SzArrayNew\"(*([v78 @ X23_v2 (Il2CppClass<CollectParticleData[]>)+718]), 0xA, methodInfo, v49, v50, v51, v52, v53, pos, pos.y, v54, v55, v56, v57, v58, v59);\n\tv342 = UnityEngine.Random::get_insideUnitCircle();\n\tv347 = v342 * 0x3C23D70A;\n\tv348 = v342.y * 0x3C23D70A;\n\tv349 = pos + v347;\n\tv350 = pos.y + v348;\n\t// 94 MakeStruct v183 @ AGG1004424_0_v2 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v349 @ V0_v4 (System.Single), v350 @ V1_v5 (System.Single)\n\tv192 = Unity.Mathematics.float2::op_Implicit(v183);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+20]) = v192;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+24]) = v192.y;\n\tv354 = UnityEngine.Random::get_insideUnitCircle();\n\tv461 = v354 * 0x3C23D70A;\n\tv462 = v354.y * 0x3C23D70A;\n\tv463 = pos + v461;\n\tv464 = pos.y + v462;\n\t// 115 MakeStruct v181 @ AGG1004460_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v463 @ V0_v9 (System.Single), v464 @ V1_v10 (System.Single)\n\tv420 = Unity.Mathematics.float2::op_Implicit(v181);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+28]) = v420;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+2C]) = v420.y;\n\tv466 = UnityEngine.Random::get_insideUnitCircle();\n\tv470 = v466 * 0x3C23D70A;\n\tv471 = v466.y * 0x3C23D70A;\n\tv472 = pos + v470;\n\tv473 = pos.y + v471;\n\t// 138 MakeStruct v161 @ AGG100449C_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v472 @ V0_v13 (System.Single), v473 @ V1_v14 (System.Single)\n\tv421 = Unity.Mathematics.float2::op_Implicit(v161);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+30]) = v421;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+34]) = v421.y;\n\tv476 = UnityEngine.Random::get_insideUnitCircle();\n\tv480 = v476 * 0x3C23D70A;\n\tv481 = v476.y * 0x3C23D70A;\n\tv482 = pos + v480;\n\tv483 = pos.y + v481;\n\t// 166 MakeStruct v137 @ AGG10044D8_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v482 @ V0_v17 (System.Single), v483 @ V1_v18 (System.Single)\n\tv422 = Unity.Mathematics.float2::op_Implicit(v137);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+38]) = v422;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+3C]) = v422.y;\n\tv485 = UnityEngine.Random::get_insideUnitCircle();\n\tv489 = v485 * 0x3C23D70A;\n\tv490 = v485.y * 0x3C23D70A;\n\tv491 = pos + v489;\n\tv492 = pos.y + v490;\n\t// 189 MakeStruct v133 @ AGG1004514_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v491 @ V0_v21 (System.Single), v492 @ V1_v22 (System.Single)\n\tv423 = Unity.Mathematics.float2::op_Implicit(v133);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+40]) = v423;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+44]) = v423.y;\n\tv495 = UnityEngine.Random::get_insideUnitCircle();\n\tv499 = v495 * 0x3C23D70A;\n\tv500 = v495.y * 0x3C23D70A;\n\tv501 = pos + v499;\n\tv502 = pos.y + v500;\n\t// 217 MakeStruct v129 @ AGG1004550_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v501 @ V0_v25 (System.Single), v502 @ V1_v26 (System.Single)\n\tv424 = Unity.Mathematics.float2::op_Implicit(v129);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+48]) = v424;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+4C]) = v424.y;\n\tv506 = UnityEngine.Random::get_insideUnitCircle();\n\tv510 = v506 * 0x3C23D70A;\n\tv511 = v506.y * 0x3C23D70A;\n\tv512 = pos + v510;\n\tv513 = pos.y + v511;\n\t// 246 MakeStruct v125 @ AGG1004590_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v512 @ V0_v29 (System.Single), v513 @ V1_v30 (System.Single)\n\tv425 = Unity.Mathematics.float2::op_Implicit(v125);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+50]) = v425;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+54]) = v425.y;\n\tv516 = UnityEngine.Random::get_insideUnitCircle();\n\tv520 = v516 * 0x3C23D70A;\n\tv521 = v516.y * 0x3C23D70A;\n\tv522 = pos + v520;\n\tv523 = pos.y + v521;\n\t// 274 MakeStruct v121 @ AGG10045CC_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v522 @ V0_v33 (System.Single), v523 @ V1_v34 (System.Single)\n\tv426 = Unity.Mathematics.float2::op_Implicit(v121);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+58]) = v426;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+5C]) = v426.y;\n\tv525 = UnityEngine.Random::get_insideUnitCircle();\n\tv529 = v525 * 0x3C23D70A;\n\tv530 = v525.y * 0x3C23D70A;\n\tv531 = pos + v529;\n\tv532 = pos.y + v530;\n\t// 297 MakeStruct v117 @ AGG1004608_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v531 @ V0_v37 (System.Single), v532 @ V1_v38 (System.Single)\n\tv427 = Unity.Mathematics.float2::op_Implicit(v117);\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+60]) = v427;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+64]) = v427.y;\n\tv535 = UnityEngine.Random::get_insideUnitCircle();\n\tv539 = v535 * 0x3C23D70A;\n\tv540 = v535.y * 0x3C23D70A;\n\tv541 = pos + v539;\n\tv542 = pos.y + v540;\n\t// 325 MakeStruct v113 @ AGG1004644_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v541 @ V0_v41 (System.Single), v542 @ V1_v42 (System.Single)\n\tv193 = Unity.Mathematics.float2::op_Implicit(v113);\n\tv545 = System.Collections.Generic.NullableComparer`1;\n\tv547 = Il2CppMethodInfo;\n\tv550 = Il2CppMethodInfo;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+68]) = v193;\n\t*([v337 @ X0_v13 (Unity.Mathematics.float2[])+6C]) = v193.y;\n\tv552 = new *([v545 @ X8_v37 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v552, v65, *([v547 @ X25_v2 (Il2CppMethodInfo)+D68]));\n\tv560 = FluidSolver::AddParticles(this, v337, v251, v552);\n\tv563 = UnityEngine.Component::get_transform(this);\n\tgoto L_017A;\n\tv567 = \"il2cpp_codegen_runtime_class_init\"(v564, v562, v559, v94, v50, v51, v52, v53, v193, v238, v188, v55, v56, v57, v58, v59);\nL_017A:\n\tv210 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.fishPrefab, v563, *([v550 @ X26_v2 (Il2CppMethodInfo)+A0]));\n\tv211 = UnityEngine.Component::get_transform(v210);\n\tv571 = Il\n// ... truncated")]
	public Fish AddFish(global::UnityEngine.Vector2 pos, bool isBig = false)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_0030: Expected O, but got I
		//IL_0653: Expected I, but got O
		//IL_0774: Expected O, but got I
		//IL_07b4: Expected O, but got I
		//IL_07d9: Expected O, but got I
		//IL_0907: Expected O, but got I
		//IL_0917: Expected O, but got I
		//IL_0927: Expected O, but got I
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_099c: Expected O, but got I
		//IL_087a: Expected O, but got I
		//IL_0889: Expected O, but got I
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		FluidSolver._003C_003Ec__DisplayClass161_0 _003C_003Ec__DisplayClass161_1 = new FluidSolver._003C_003Ec__DisplayClass161_0();
		_003C_003Ec__DisplayClass161_1._003C_003E4__this = this;
		int fishId = IdGenerator.Next();
		_003C_003Ec__DisplayClass161_1.fishId = fishId;
		int nextUnusedFluidType = GetNextUnusedFluidType();
		global::Unity.Mathematics.float2[] spawnPositions = new global::Unity.Mathematics.float2[10];
		for (int k = 0; k < spawnPositions.Length; k++)
		{
			global::UnityEngine.Vector2 insideUnitCircle = global::UnityEngine.Random.insideUnitCircle;
			float x = pos.x + insideUnitCircle.x * 0.01f;
			float y = pos.y + insideUnitCircle.y * 0.01f;
			spawnPositions[k] = new global::Unity.Mathematics.float2(x, y);
		}
		global::System.Action<ParticleInitData> onInit = _003C_003Ec__DisplayClass161_1._003CAddFish_003Eb__0;
		global::System.Collections.Generic.HashSet<int> hashSet = AddParticles(spawnPositions, nextUnusedFluidType, onInit);
		global::UnityEngine.Transform transform = base.transform;
		Fish component = global::UnityEngine.Object.Instantiate(fishPrefab, transform);
		global::UnityEngine.Transform transform2 = component.transform;
		global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
		position.x = pos.x;
		position.y = pos.y;
		position.z = _nextFishZ;
		transform2.position = position;
		_nextFishZ += 0.001f;
		component.Init(this, fishId, hashSet, nextUnusedFluidType, null, fishMaterial, isBig);
		fishes.Add(component);
		return component;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000290")]
	[global::Cpp2ILInjected.Address(RVA = "0x10048AC", Offset = "0x10048AC", Length = "0x6F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv42 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_005D;\n\tv47 = System.Collections.Generic.NullableComparer`1;\n\tv48 = v47 + 0xD10;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv70 = CollectParticleData[];\n\tv71 = v70 + 0xCF8;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0x380;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv79 = Il2CppMethodInfo;\n\tv80 = v79 + 0xB78;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v80, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv273 = Il2CppMethodInfo;\n\tv274 = v273 + 0xB80;\n\tv275 = \"il2cpp_codegen_initialize_runtime_metadata\"(v274, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv349 = Il2CppMethodInfo;\n\tv350 = v349 + 0xB88;\n\tv351 = \"il2cpp_codegen_initialize_runtime_metadata\"(v350, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv406 = Il2CppMethodInfo;\n\tv407 = v406 + 0x990;\n\tv408 = \"il2cpp_codegen_initialize_runtime_metadata\"(v407, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv507 = Il2CppMethodInfo;\n\tv508 = v507 + 0xAB8;\n\tv509 = \"il2cpp_codegen_initialize_runtime_metadata\"(v508, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv525 = Il2CppMethodInfo;\n\tv526 = v525 + 0xAC0;\n\tv527 = \"il2cpp_codegen_initialize_runtime_metadata\"(v526, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv544 = Il2CppMethodInfo;\n\tv545 = v544 + 0xC8;\n\tv546 = \"il2cpp_codegen_initialize_runtime_metadata\"(v545, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv607 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv608 = v607 + 0xFD8;\n\tv609 = \"il2cpp_codegen_initialize_runtime_metadata\"(v608, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv618 = Il2CppMethodInfo;\n\tv619 = v618 + 0xC90;\n\tv620 = \"il2cpp_codegen_initialize_runtime_metadata\"(v619, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv650 = Il2CppMethodInfo;\n\tv651 = v650 + 0xC70;\n\tv652 = \"il2cpp_codegen_initialize_runtime_metadata\"(v651, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv662 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv663 = v662 + 0xA38;\n\tv664 = \"il2cpp_codegen_initialize_runtime_metadata\"(v663, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv732 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv733 = v732 + 0xA48;\n\tv734 = \"il2cpp_codegen_initialize_runtime_metadata\"(v733, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv735 = Il2CppMethodInfo;\n\tv736 = v735 + 0xD70;\n\tv737 = \"il2cpp_codegen_initialize_runtime_metadata\"(v736, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv740 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv741 = v740 + 0xBA8;\n\tv742 = \"il2cpp_codegen_initialize_runtime_metadata\"(v741, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv748 = \"cp420\";\n\tv749 = v748 + 0xFE8;\n\tv750 = \"il2cpp_codegen_initialize_runtime_metadata\"(v749, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv761 = CollectParticleData[];\n\tv762 = v761 + 0x718;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v762, mergeIndex, isBig, methodInfo, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302AA32]) = v64;\nL_005D:\n\tv69 = new *([v42 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BA8])();\n\tFluidSolver+<>c__DisplayClass162_0::.ctor(v69);\n\tv83 = v69 + 0x10;\n\tv69.<>4__this = this;\n\tv86 = 0xF3F1B4(v83, this, isBig, v424, v418, v423, v417, v421, pos, pos.y, v55, v56, v57, v58, v59, v60);\n\tv277 = IdGenerator::Next();\n\tv69.puId = v277;\n\tv414 = System.Collections.Generic.List`1<PowerUp>::GetEnumerator(this.powerUps);\n\tv524 = mergeIndex <= 1;\n\tif (v524) goto L_0183;\nL_008D:\n\tv550 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v413 @ stack_-A8_v8 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv611 = v550 == 0;\n\tv552 = ~v611;\n\tif (v552) goto L_008D;\nL_0092:\n\tv643 = Il2CppMethodInfo;\n\tv597 = *([v643 @ X8_v46 (Il2CppMethodInfo)+B78]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v413 @ stack_-A8_v8 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0097:\n\tv658 = CollectParticleData[];\n\tv660 = FluidSolver::GetNextUnusedFluidType(this);\n\tv229 = \"SzArrayNew\"(*([v658 @ X21_v8 (Il2CppClass<CollectParticleData[]>)+718]), 6, v425, v424, v418, v423, v417, v421, v479, v500, v55, v56, v57, v58, v59, v60);\n\tv492 = v229.Length == 0;\n\tif (v492) goto L_0240;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+20]) = pos;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+24]) = pos.y;\n\tv457 = v229.Length == 1;\n\tif (v457) goto L_0240;\n\tv481 = pos.y + 0x3D8A56FF;\n\tv500 = pos + 0xBD970382;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+28]) = v500;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+2C]) = v481;\n\tv458 = v229.Length == 2;\n\tif (v458) goto L_0240;\n\tv482 = pos.y + 0xBE1042C9;\n\tv500 = pos + 0x3C4A967E;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+30]) = v500;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+34]) = v482;\n\tv459 = v229.Length == 3;\n\tif (v459) goto L_0240;\n\tv483 = pos.y + 0x3E0CC183;\n\tv500 = pos + 0x3DD7D314;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+38]) = v500;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+3C]) = v483;\n\tv460 = v229.Length == 4;\n\tif (v460) goto L_0240;\n\tv484 = pos.y + 0xBD0EB3E1;\n\tv500 = pos + 0xBE49AB34;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+40]) = v500;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+44]) = v484;\n\tv180 = v229.Length == 5;\n\tif (v180) goto L_0240;\n\tv786 = System.Collections.Generic.NullableComparer`1;\n\tv788 = Il2CppMethodInfo;\n\tv792 = Il2CppMethodInfo;\n\tv210 = pos.y + 0xBDF5C904;\n\tv500 = pos + 0x3E41332E;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+48]) = v500;\n\t*([v229 @ X0_v27 (Unity.Mathematics.float2[])+4C]) = v210;\n\tv800 = new *([v786 @ X8_v12 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v800, v69, *([v788 @ X26_v6 (Il2CppMethodInfo)+D70]));\n\tv809 = FluidSolver::AddParticles(this, v229, v660, v800);\n\tv813 = UnityEngine.Component::get_transform(this);\n\tgoto L_0130;\n\tv819 = \"il2cpp_codegen_runtime_class_init\"(v815, v812, v808, v122, v99, v118, v96, v110, v210, v271, v55, v56, v57, v58, v59, v60);\nL_0130:\n\tv821 = Il2CppMethodInfo;\n\tv425 = *([v792 @ X27_v6 (Il2CppMethodInfo)+C8]);\n\tv823 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.powerUpPrefab, v813, *([v792 @ X27_v6 (Il2CppMethodInfo)+C8]));\n\tgoto L_013E;\n\tv827 = \"il2cpp_codegen_runtime_class_init\"(v824, v223, v127, v122, v99, v118, v96, v110, v210, v271, v55, v56, v57, v58, v59, v60);\nL_013E:\n\t;\n\tv230 = Singleton`1::get_Instance /* +1 sharing this address */(*([v821 @ X28_v8 (Il2CppMethodInfo)+C90]));\n\tv252 = this.powerUpMaterials;\n\tv830 = v252.Length < mergeIndex;\n\tv199 = ~v830;\n\tv193 = v252.Length - mergeIndex;\n\tv181 = v193 == 0;\n\tv831 = ~v199;\n\tv152 = v831 | v181;\n\tif (v152) goto L_0240;\n\tPowerUp::Init(v823, this, v69.puId, v809, v660, *([v230 @ X0_v41+108]), mergeIndex, v252[v498 @ X20_v2 (System.Int32)], isBig);\n\tv231 = this.powerUps;\n\tv837 = v231._version + 1;\n\tv231._version = v837;\n\tv148 = v231._items;\n\tv838 = v231._size < v148.Leng\n// ... truncated")]
	public unsafe PowerUp AddPowerUp(global::Unity.Mathematics.float2 pos, int mergeIndex, bool isBig = false)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0578: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_01c0: Expected O, but got F4
		//IL_01c9: Expected O, but got I4
		//IL_0869: Expected O, but got I
		//IL_0889: Expected I4, but got O
		//IL_0224: Expected O, but got F4
		//IL_022d: Expected O, but got I4
		//IL_08a8: Expected I4, but got O
		//IL_0288: Expected O, but got F4
		//IL_0291: Expected O, but got I4
		//IL_0641: Expected I8, but got I4
		//IL_02ec: Expected O, but got F4
		//IL_02f5: Expected O, but got I4
		//IL_0674: Expected I8, but got I
		//IL_0311: Expected I, but got O
		//IL_06ab: Expected I8, but got I
		//IL_06f2: Expected I8, but got I4
		//IL_043a: Expected I, but got O
		//IL_0442: Expected O, but got F4
		//IL_0494: Expected O, but got I
		//IL_0749: Expected I, but got O
		//IL_0546: Expected O, but got I
		//IL_0555: Expected O, but got I
		//IL_097b: Expected I, but got O
		//IL_099a: Expected O, but got I
		//IL_07e8: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass162_0 _003C_003Ec__DisplayClass162_1 = new FluidSolver._003C_003Ec__DisplayClass162_0();
		_003C_003Ec__DisplayClass162_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int puId = IdGenerator.Next();
		_003C_003Ec__DisplayClass162_1.puId = puId;
		global::System.Collections.Generic.List<PowerUp>.Enumerator enumerator = powerUps.GetEnumerator();
		global::System.Collections.Generic.List<object>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<object>.Enumerator);
		nint num7;
		bool flag;
		if (mergeIndex <= 1)
		{
			global::Unity.Collections.NativeHashMap<ulong, byte> nativeParallelHashMap = ignorePairs;
			nint num2 = 0;
			nint num3 = 0;
			flag = isBig;
			object obj2 = default(object);
			while (enumerator2.MoveNext())
			{
				if (obj2 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ stack_-98+B0]");
					if ((nint)0 != mergeIndex)
					{
						continue;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X28_v11 (Il2CppMethodInfo)+990]");
					flag = false;
					global::System.Collections.Generic.HashSet<int> hashSet = exploding;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ stack_-98+6C]");
					if (hashSet.Contains(0))
					{
						continue;
					}
					int num4 = _003C_003Ec__DisplayClass162_1.puId;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ stack_-98+6C]");
					if ((nint)num4 == 0)
					{
						continue;
					}
					long num5 = _003C_003Ec__DisplayClass162_1.puId + 1;
					if (num5 != 0)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ stack_-98+6C]");
						long num6 = (nint)0 + (nint)1;
						if (num6 != 0)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ stack_-98+6C]");
							ulong key = (ulong)(nint)((nuint)0u | (nuint)_003C_003Ec__DisplayClass162_1.puId);
							bool flag2 = nativeParallelHashMap.TryAdd(key, 1);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X24_v9 (Il2CppMethodInfo)+CA0]");
							num7 = 0;
							bool flag3 = nativeParallelHashMap.TryAdd((ulong)_003C_003Ec__DisplayClass162_1.puId, 1);
							flag = true;
						}
					}
					continue;
				}
				goto IL_07ed;
			}
		}
		else
		{
			bool flag6;
			do
			{
				bool flag4 = enumerator2.MoveNext();
				bool flag5 = !flag4;
				flag6 = !flag5;
				flag = isBig;
			}
			while (flag6);
		}
		nint num8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v46 (Il2CppMethodInfo)+B78]");
		global::UnityEngine.Transform transform = (global::UnityEngine.Transform)0;
		enumerator2.Dispose();
		global::System.Collections.Generic.List<object>.Enumerator enumerator3 = enumerator2;
		int num9 = 0;
		int num10 = mergeIndex;
		float y = pos.y;
		goto IL_00d6;
		IL_0906:
		global::System.IndexOutOfRangeException ex = new global::System.IndexOutOfRangeException();
		bool flag7 = (nint)transform != 1;
		global::System.IndexOutOfRangeException ex2 = ex;
		if (!flag7)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num11 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v5 (Il2CppMethodInfo)+B78]");
			transform = (global::UnityEngine.Transform)0;
			enumerator2.Dispose();
			object obj3 = default(object);
			bool flag8 = obj3 == null;
			num9 = (int)obj3;
			if (flag8)
			{
				goto IL_00d6;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num9 = (int)obj3;
			ex2 = (global::System.IndexOutOfRangeException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0DEC");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
		PowerUp result = default(PowerUp);
		return result;
		IL_00d6:
		nint num12 = (nint)typeof(CollectParticleData[]);
		int nextUnusedFluidType = GetNextUnusedFluidType();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::Unity.Mathematics.float2[] array = default(global::Unity.Mathematics.float2[]);
		bool flag9 = array.Length == 0;
		transform = (global::UnityEngine.Transform)6;
		if (!flag9)
		{
			_ = pos.y;
			bool flag10 = array.Length == 1;
			enumerator3 = (global::System.Collections.Generic.List<object>.Enumerator)pos;
			transform = (global::UnityEngine.Transform)6;
			y = pos.y;
			if (!flag10)
			{
				float num13 = pos.y + 0.067548744f;
				global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
				y = float5.x + -0.07373716f;
				bool flag11 = array.Length == 2;
				enumerator3 = (global::System.Collections.Generic.List<object>.Enumerator)num13;
				transform = (global::UnityEngine.Transform)6;
				if (!flag11)
				{
					float num14 = pos.y + -0.14087977f;
					y = float5.x + 0.012364982f;
					bool flag12 = array.Length == 3;
					enumerator3 = (global::System.Collections.Generic.List<object>.Enumerator)num14;
					transform = (global::UnityEngine.Transform)6;
					if (!flag12)
					{
						float num15 = pos.y + 0.13745694f;
						y = float5.x + 0.10538307f;
						bool flag13 = array.Length == 4;
						enumerator3 = (global::System.Collections.Generic.List<object>.Enumerator)num15;
						transform = (global::UnityEngine.Transform)6;
						if (!flag13)
						{
							float num16 = pos.y + -0.034839515f;
							y = float5.x + -0.19694215f;
							bool flag14 = array.Length == 5;
							enumerator3 = (global::System.Collections.Generic.List<object>.Enumerator)num16;
							transform = (global::UnityEngine.Transform)6;
							if (!flag14)
							{
								nint num18 = 0;
								nint num19 = 0;
								float num20 = pos.y + -0.12001231f;
								y = float5.x + 0.1886718f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X26_v6 (Il2CppMethodInfo)+D70]");
								global::System.Action<ParticleInitData> action = new global::System.Action<ParticleInitData>(_003C_003Ec__DisplayClass162_1, (global::System.IntPtr)0);
								global::System.Collections.Generic.HashSet<int> hashSet2 = AddParticles(array, nextUnusedFluidType, action);
								global::UnityEngine.Transform transform2 = base.transform;
								nint num21 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X27_v6 (Il2CppMethodInfo)+C8]");
								flag = false;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
								global::UnityEngine.Material[] array2 = powerUpMaterials;
								bool flag15 = array2.Length < mergeIndex;
								bool flag16 = !flag15;
								int num22 = array2.Length - mergeIndex;
								bool flag17 = num22 == 0;
								bool flag18 = !flag16;
								bool flag19 = flag18 || flag17;
								num7 = (nint)action;
								enumerator3 = (global::System.Collections.Generic.List<object>.Enumerator)num20;
								transform = transform2;
								if (!flag19)
								{
									int id = _003C_003Ec__DisplayClass162_1.puId;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v41+108]");
									PowerUp powerUp = default(PowerUp);
									powerUp.Init(this, id, hashSet2, nextUnusedFluidType, (FluidCompute)0, mergeIndex, array2[num10], isBig);
									global::System.Collections.Generic.List<PowerUp> list = powerUps;
									list.Add(powerUp);
									nint num24 = 0;
									powerUpById[_003C_003Ec__DisplayClass162_1.puId] = powerUp;
									nint num26 = 0;
									nint num27 = (nint)typeof(CollectParticleData[]);
									object obj6 = new object();
									_ = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
									global::UnityEngine.Coroutine coroutine = powerUp.StartCoroutine((global::System.Collections.IEnumerator)obj6);
									global::System.Collections.IEnumerator routine = powerUp.RotateBlob();
									global::UnityEngine.Coroutine coroutine2 = powerUp.StartCoroutine(routine);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
									AudioClipSettings audioClipSettings = new AudioClipSettings();
									audioClipSettings.pitch = 1.5f;
									audioClipSettings.pitchVariance = 0.2f;
									string text = "cp420";
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v29 (System.String)+FE8]");
									AudioManager audioManager = default(AudioManager);
									audioManager.PlayClip((string)0, audioClipSettings);
									return powerUp;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0906;
		IL_07ed:
		global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
		global::System.IntPtr intPtr = default(global::System.IntPtr);
		num7 = intPtr;
		bool flag20 = default(bool);
		flag = flag20;
		goto IL_0906;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000291")]
	[global::Cpp2ILInjected.Address(RVA = "0x100504C", Offset = "0x100504C", Length = "0x58")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv14 = UnityEngine.Mathf::Sqrt(index);\n\tv18 = index * 0x4309820C;\n\tv22 = v18 * 0x3C8EFA35;\n\tv23 = 0x274A170(this, index, methodInfo, v26, v27, v28, v29, v30, v22, 0x3C8EFA35, v31, v32, v33, v34, v35, v36);\n\tv37 = v14 * radius;\n\treturnVal1 = v37 * 0x3C8EFA35;\n\treturn returnVal1;\n// 21 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::Unity.Mathematics.float2 GetEvenlySpacedPosition(int index, float radius)
	{
		float num = global::UnityEngine.Mathf.Sqrt(index);
		float num2 = (float)index * 137.508f;
		float num3 = num2 * ((float)global::System.Math.PI / 180f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
		float num4 = num * radius;
		float x = num4 * ((float)global::System.Math.PI / 180f);
		global::Unity.Mathematics.float2 result = default(global::Unity.Mathematics.float2);
		result.x = x;
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000292")]
	[global::Cpp2ILInjected.Address(RVA = "0x1000464", Offset = "0x1000464", Length = "0x33C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0029;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0x578;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x598;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv66 = Il2CppMethodInfo;\n\tv67 = v66 + 0x990;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv290 = Il2CppMethodInfo;\n\tv291 = v290 + 0xAD0;\n\tv292 = \"il2cpp_codegen_initialize_runtime_metadata\"(v291, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv308 = Il2CppMethodInfo;\n\tv309 = v308 + 0xAD8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v309, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302AA33]) = v58;\nL_0029:\n\tv60 = UnityEngine.Time::get_time();\n\tv304 = this.powerUps;\n\tv77 = v60 << 0x20;\n\tv78 = this + 0x3F0;\n\tgoto L_0049;\nL_003A:\n\tv288 = v288 + 1;\n\tv304 = this.powerUps;\n\tv246 = v246 + 1;\nL_0049:\n\tv166 = v288 >= v304._size;\n\tif (v166) goto L_0140;\n\tv255 = System.Collections.Generic.List`1<PowerUp>::get_Item(v304, v288);\n\tv359 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(this.exploding, v255.id);\n\tv361 = v359 == 0;\n\tv362 = ~v361;\n\tif (v362) goto L_003A;\n\tv392 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::ContainsKey(this.merging, v255.id);\n\tv407 = v392 == 0;\n\tv397 = ~v407;\n\tif (v397) goto L_003A;\n\tv167 = v255.mergeIndex > 1;\n\tif (v167) goto L_003A;\n\tv393 = this.powerUps;\n\tv410 = this.powerUps == 0;\n\tv270 = ~v410;\n\tif (v270) goto L_009B;\n\tgoto L_0141;\nL_007B:\n\tv457 = v255.position - v260.position;\n\tv458 = v457 * v457;\n\t// 125 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv126 = UnityEngine.Mathf::Sqrt(v458);\n\tv171 = v126 <= this.powerUpMergeDistance;\n\tif (v171) goto L_00E8;\nL_008D:\n\tv393 = this.powerUps;\n\tv132 = v132 + 1;\nL_009B:\n\tv169 = v132 >= v393._size;\n\tif (v169) goto L_003A;\n\tv260 = System.Collections.Generic.List`1<PowerUp>::get_Item(v393, v132);\n\tv422 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(this.exploding, v260.id);\n\tv424 = v422 == 0;\n\tv425 = ~v424;\n\tif (v425) goto L_008D;\n\tv170 = v255.mergeIndex != v260.mergeIndex;\n\tif (v170) goto L_008D;\n\tv429 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::ContainsKey(this.merging, v260.id);\n\tv436 = v429 == 0;\n\tv432 = ~v436;\n\tif (v432) goto L_008D;\n\tv439 = *([2DD4425]) == 0;\n\tif (v439) goto L_00D9;\n\tgoto L_007B;\n\tgoto L_FFFFFFFF;\nL_00D9:\n\t*([2DD4425]) = 1;\n\tgoto L_007B;\n\tgoto L_007B;\nL_00E8:\n\tv162 = v77 | v260.id;\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::set_Item(this.merging, v255.id, v162);\n\tv373 = v77 | v255.id;\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::set_Item(this.merging, v260.id, v373);\n\tFluidSolver::RemoveAllPairsWith(this, v255.id);\n\tFluidSolver::RemoveAllPairsWith(this, v260.id);\n\tgoto L_010E;\n\tv477 = Il2CppMethodInfo;\n\tv478 = v477 + 0xCA0;\n\tv479 = \"il2cpp_codegen_initialize_runtime_metadata\"(v478, v370, v373, v363, v43, v44, v45, v46, v126, v120, v49, v50, v51, v52, v53, v54);\n\tv481 = 1;\n\t*([302AA36]) = v481;\nL_010E:\n\tv383 = v255.id == v260.id;\n\tif (v383) goto L_003A;\n\tv399 = v255.id + 1;\n\tv381 = v399 == 0;\n\tif (v381) goto L_003A;\n\tv400 = v260.id + 1;\n\tv382 = v400 == 0;\n\tif (v382) goto L_003A;\n\tv483 = v260.id | v255.id;\n\tv489 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::TryAdd(v78, v483, 1);\n\t// 296 NotImplemented \"Instruction BFI not yet implemented.\"\n\tv395 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::TryAdd(v78, v255.id, 1);\n\tgoto L_003A;\nL_0140:\n\treturn;\nL_0141:\n\tthrow System.NullReferenceException;\n// 224 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void DetectPowerUpMerges()
	{
		//IL_0017: Expected O, but got F4
		//IL_0023: Expected O, but got I
		//IL_0338: Expected O, but got I
		//IL_0368: Expected O, but got I
		//IL_03bb: Expected I8, but got I4
		//IL_03eb: Expected I8, but got I4
		//IL_041f: Expected I8, but got I4
		//IL_0458: Expected I8, but got I4
		float time = global::UnityEngine.Time.time;
		global::System.Collections.Generic.List<PowerUp> list = powerUps;
		object obj = time << 32;
		global::Unity.Collections.NativeHashMap<ulong, byte> nativeParallelHashMap = ignorePairs;
		int num = 1;
		int num2 = 0;
		while (true)
		{
			if (num2 >= list.Count)
			{
				return;
			}
			PowerUp powerUp = list[num2];
			if (!exploding.Contains(powerUp.id) && !merging.ContainsKey(powerUp.id) && powerUp.mergeIndex <= 1)
			{
				global::System.Collections.Generic.List<PowerUp> list2 = powerUps;
				bool flag = powerUps == null;
				bool flag2 = !flag;
				int i = num;
				if (!flag2)
				{
					break;
				}
				for (; i < list2.Count; i++)
				{
					PowerUp powerUp2 = list2[i];
					if (!exploding.Contains(powerUp2.id) && powerUp.mergeIndex == powerUp2.mergeIndex && !merging.ContainsKey(powerUp2.id))
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4425]");
						if ((nint)0 == 0)
						{
							_ = 1;
						}
						float num3 = powerUp.position.x - powerUp2.position.x;
						float f = num3 * num3;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						float num4 = global::UnityEngine.Mathf.Sqrt(f);
						if (!(num4 > powerUpMergeDistance))
						{
							FluidSolver.PowerUpMergeData value = (FluidSolver.PowerUpMergeData)((nint)obj | powerUp2.id);
							merging[powerUp.id] = value;
							FluidSolver.PowerUpMergeData value2 = (FluidSolver.PowerUpMergeData)((nint)obj | powerUp.id);
							merging[powerUp2.id] = value2;
							RemoveAllPairsWith(powerUp.id);
							RemoveAllPairsWith(powerUp2.id);
							if (powerUp.id == powerUp2.id)
							{
								break;
							}
							long num5 = powerUp.id + 1;
							if (num5 != 0)
							{
								long num6 = powerUp2.id + 1;
								if (num6 != 0)
								{
									ulong key = (ulong)(powerUp2.id | powerUp.id);
									bool flag3 = nativeParallelHashMap.TryAdd(key, 1);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
									bool flag4 = nativeParallelHashMap.TryAdd((ulong)powerUp.id, 1);
								}
							}
							break;
						}
					}
					list2 = powerUps;
				}
			}
			num2++;
			list = powerUps;
			num++;
		}
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000293")]
	[global::Cpp2ILInjected.Address(RVA = "0x10007A0", Offset = "0x10007A0", Length = "0x510")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv50 = Il2CppMethodInfo;\n\tgoto L_005F;\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0x580;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0x378;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv95 = Il2CppMethodInfo;\n\tv96 = v95 + 0x1E8;\n\tv97 = \"il2cpp_codegen_initialize_runtime_metadata\"(v96, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x5F0;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv106 = Il2CppMethodInfo;\n\tv107 = v106 + 0x1F0;\n\tv108 = \"il2cpp_codegen_initialize_runtime_metadata\"(v107, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv111 = Il2CppMethodInfo;\n\tv112 = v111 + 0x5F8;\n\tv113 = \"il2cpp_codegen_initialize_runtime_metadata\"(v112, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv290 = Il2CppMethodInfo;\n\tv291 = v290 + 0x1F8;\n\tv292 = \"il2cpp_codegen_initialize_runtime_metadata\"(v291, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv298 = Il2CppMethodInfo;\n\tv299 = v298 + 0x600;\n\tv300 = \"il2cpp_codegen_initialize_runtime_metadata\"(v299, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv415 = Il2CppMethodInfo;\n\tv416 = v415 + 0xEB0;\n\tv417 = \"il2cpp_codegen_initialize_runtime_metadata\"(v416, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv436 = Il2CppMethodInfo;\n\tv437 = v436 + 0xEB8;\n\tv438 = \"il2cpp_codegen_initialize_runtime_metadata\"(v437, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv448 = Il2CppMethodInfo;\n\tv449 = v448 + 0x5C0;\n\tv450 = \"il2cpp_codegen_initialize_runtime_metadata\"(v449, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv458 = Il2CppMethodInfo;\n\tv459 = v458 + 0x5C8;\n\tv460 = \"il2cpp_codegen_initialize_runtime_metadata\"(v459, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv470 = Il2CppMethodInfo;\n\tv471 = v470 + 0x5B8;\n\tv472 = \"il2cpp_codegen_initialize_runtime_metadata\"(v471, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv484 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv485 = v484 + 0xE40;\n\tv486 = \"il2cpp_codegen_initialize_runtime_metadata\"(v485, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv574 = Il2CppMethodInfo;\n\tv575 = v574 + 0xC48;\n\tv576 = \"il2cpp_codegen_initialize_runtime_metadata\"(v575, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv579 = Il2CppMethodInfo;\n\tv580 = v579 + 0xC68;\n\tv581 = \"il2cpp_codegen_initialize_runtime_metadata\"(v580, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv601 = Il2CppMethodInfo;\n\tv602 = v601 + 0xC70;\n\tv603 = \"il2cpp_codegen_initialize_runtime_metadata\"(v602, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv606 = Il2CppMethodInfo;\n\tv607 = v606 + 0x5B0;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v607, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72);\n\tv76 = 1;\n\t*([302AA18]) = v76;\nL_005F:\n\tv81 = 0;\n\tv84 = 0;\n\tv85 = 0;\n\tv87 = this + 0x410;\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::Clear(v87);\n\tv269 = UnityEngine.Time::get_time();\n\tv100 = new *([v48 @ X20_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+E40])();\n\tv424 = *([v50 @ X22_v1 (Il2CppMethodInfo)+5B8]);\n\tSystem.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>::.ctor(v100);\n\tv110 = this.merging == 0;\n\tif (v110) goto L_0180;\n\tv116 = Il2CppMethodInfo;\n\tv118 = Il2CppMethodInfo;\n\tv125 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::GetEnumerator(this.merging);\n\tv279 = this + 0x378;\n\tgoto L_0090;\nL_0089:\n\tv683 = v100._size + 1;\n\tv100._size = v683;\n\tv375 = v100._size << 3;\n\tv399 = v304 + v375;\n\t*([v399 @ X8_v30+20]) = v306;\nL_0090:\n\tv403 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>+Enumerator<System.Int32, FluidSolver+PowerUpMergeData>::MoveNext(&v124 @ stack_-128_v6 (System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>+Enumerator<System.Int32, FluidSolver+PowerUpMergeData>));\n\tv419 = v403 == 0;\n\tif (v419) goto L_0144;\n\tv441 = this.powerUpById == 0;\n\tif (v441) goto L_017A;\n\tv223 = *([v118 @ X27_v4 (Il2CppMethodInfo)+378]);\n\tv389 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, v295, &v81 @ stack_-E8_v1 (System.Object));\n\tv395 = v389 == 0;\n\tif (v395) goto L_0090;\n\tv474 = this.powerUpById == 0;\n\tif (v474) goto L_017C;\n\tv223 = *([v118 @ X27_v4 (Il2CppMethodInfo)+378]);\n\tv390 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, v451, &v84 @ stack_-F0_v1 (System.Object));\n\tv396 = v390 == 0;\n\tif (v396) goto L_0090;\n\tv585 = v269 - v439;\n\tv586 = v585 / this.mergeDuration;\n\tv589 = v586 - v376;\n\tv590 = v589 < 0;\n\tv591 = v589 == 0;\n\tv592 = v586 ^ v376;\n\tv593 = v586 ^ v589;\n\tv594 = v592 & v593;\n\tv595 = v594 < 0;\n\tv596 = v590 == v595;\n\tv328 = ~v591;\n\tv597 = v596 & v328;\n\tv598 = ~v597;\n\tif (v598) goto L_FFFFFFFF;\n\tgoto L_00CE;\nL_00CE:\n\tv619 = v586 >= 0;\n\tif (v619) goto L_FFFFFFFF;\n\tgoto L_00D4;\nL_00D4:\n\t;\n\tv627 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v279, v295);\n\tv632 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v279, v451);\n\tv634 = v324 * v324;\n\tv635 = v324 * v634;\n\tv636 = v627 + v632;\n\tv637 = v627.y + v632.y;\n\tv314 = v636 * 0.5f;\n\tv312 = v637 * 0.5f;\n\tv638 = v314 - v627;\n\tv639 = v312 - v627.y;\n\tv640 = v635 * v638;\n\tv641 = v635 * v639;\n\tv642 = Il2CppMethodInfo;\n\t// 244 MakeStruct v310 @ AGG1000A80_2_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), v640 @ V0_v17 (System.Single), v641 @ V1_v12 (System.Single)\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v87, v295, v310);\n\tv646 = v312 - v632.y;\n\tv254 = v635 * v646;\n\tv647 = v314 - v632;\n\tv386 = v635 * v647;\n\tv220 = *([v642 @ X28_v9 (Il2CppMethodInfo)+C70]);\n\t// 253 MakeStruct v308 @ AGG1000AA0_2_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), v386 @ V0_v20 (System.Single), v254 @ V1_v5 (System.Single)\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v87, v451, v308);\n\tv326 = v324 < 1f;\n\tif (v326) goto L_FFFFFFFF;\n\tv660 = v295 - v451;\n\tv349 = v660 < 0;\n\tv663 = v295 ^ v451;\n\tv664 = v295 ^ v660;\n\tv665 = v663 & v664;\n\tv334 = v665 < 0;\n\tgoto L_011B;\nL_011B:\n\tv331 = v349 == v334;\n\tif (v331) goto L_0090;\n\tv672 = Il2CppMethodInfo;\n\tv222 = *([v672 @ X8_v21 (Il2CppMethodInfo)+5B0]);\n\tSystem.ValueTuple`2<System.Int32, System.Int32>::.ctor(&v306 @ stack_-130_v6 (System.ValueTuple`2<System.Int32, System.Int32>), v295, v451);\n\tv676 = Il2CppMethodInfo;\n\tv678 = *([v676 @ X8_v24 (Il2CppMethodInfo)+5C0]);\n\tv680 = v100._version + 1;\n\tv100._version = v680;\n\tv304 = v100._items;\n\tv681 = v100._size < v304.Length;\n\tv354 = ~v681;\n\tv330 = ~v354;\n\tif (v330) goto L_0089;\n\tv682 = *([v678 @ X8_v26+20]);\n\tv400 = *([v682 @ X8_v27+C0]);\n\tv220 = *([v400 @ X8_v28+70]);\n\tSystem.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>::AddWithResize(v100, v306);\n\tgoto L_0090;\nL_0144:\n\tv442 = Il2CppMethodInfo;\n\tv424 = *([v442 @ X8_v18 (Il2CppMethodInfo)+1E8]);\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>+Enumerator<System.Int32, FluidSolver+PowerUpMergeData>::Dispose(&v124 @ stack_-128_v6 (System.Collec\n// ... truncated")]
	private unsafe void UpdateMergeDeltasAndFinish()
	{
		//IL_000f: Expected I, but got O
		//IL_070f: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0540: Expected O, but got Ref
		//IL_0551: Expected F4, but got O
		//IL_06a9: Expected I4, but got O
		//IL_05c7: Expected O, but got F4
		//IL_06c8: Expected I4, but got O
		//IL_0603: Expected O, but got Ref
		//IL_062c: Expected F4, but got O
		//IL_0145: Expected O, but got I
		//IL_05e5: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_024a: Expected O, but got F4
		//IL_0257: Expected O, but got F4
		//IL_08c8: Expected O, but got F4
		//IL_040d: Expected O, but got I
		//IL_0439: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_0111: Expected O, but got F4
		//IL_04b5: Expected O, but got I
		//IL_04c5: Expected O, but got I
		//IL_04fb: Expected O, but got I
		//IL_0514: Expected O, but got F4
		nint num2 = 0;
		PowerUp value = null;
		PowerUp value2 = null;
		global::System.Collections.Generic.List<(int, int)>.Enumerator enumerator = default(global::System.Collections.Generic.List<(int, int)>.Enumerator);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = mergeDeltas;
		nativeParallelHashMap.Clear();
		float time = global::UnityEngine.Time.time;
		global::System.Collections.Generic.List<(int, int)> list = new global::System.Collections.Generic.List<(int, int)>();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v1 (Il2CppMethodInfo)+5B8]");
		int num3 = 0;
		global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator enumerator5 = default(global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator);
		if (merging != null)
		{
			nint num4 = 0;
			nint num5 = 0;
			global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator enumerator2 = merging.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap2 = powerUpMidpoints;
			float num6 = 1f;
			int num8 = default(int);
			float num7 = num8;
			global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator enumerator4 = default(global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator);
			global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator enumerator3 = enumerator4;
			int num10 = default(int);
			object obj2 = default(object);
			global::Unity.Mathematics.float2 value3 = default(global::Unity.Mathematics.float2);
			float num27 = default(float);
			float num29 = default(float);
			global::Unity.Mathematics.float2 value4 = default(global::Unity.Mathematics.float2);
			object obj5 = default(object);
			int num38;
			while (enumerator4.MoveNext())
			{
				object obj;
				if (powerUpById != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X27_v4 (Il2CppMethodInfo)+378]");
					obj = 0;
					bool flag = powerUpById.TryGetValue(num8, out value);
					bool flag2 = !flag;
					if (flag2)
					{
						continue;
					}
					if (powerUpById != null)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X27_v4 (Il2CppMethodInfo)+378]");
						obj = 0;
						bool flag3 = powerUpById.TryGetValue(num10, out value2);
						bool flag4 = !flag3;
						if (flag4)
						{
							continue;
						}
						float num11 = time - (float)obj2;
						float num12 = num11 / mergeDuration;
						float num13 = num12 - num6;
						bool flag5 = num13 < 0f;
						bool flag6 = num13 == 0f;
						object obj3 = num12 ^ num6;
						object obj4 = num12 ^ num13;
						int num14 = (int)((nint)obj3 & (nint)obj4);
						bool flag7 = num14 < 0;
						bool flag8 = flag5 == flag7;
						bool flag9 = !flag6;
						float num15 = ((!(flag8 && flag9)) ? num12 : num6);
						float num16 = ((!(num12 < 0f)) ? num15 : 0f);
						global::Unity.Mathematics.float2 float5 = nativeParallelHashMap2[num8];
						global::Unity.Mathematics.float2 float6 = nativeParallelHashMap2[num10];
						float num17 = num16 * num16;
						float num18 = num16 * num17;
						float num19 = float5.x + float6.x;
						float num20 = float5.y + float6.y;
						float num21 = num19 * 0.5f;
						float num22 = num20 * 0.5f;
						float num23 = num21 - float5.x;
						float num24 = num22 - float5.y;
						float x = num18 * num23;
						float y = num18 * num24;
						nint num25 = 0;
						value3.x = x;
						value3.y = y;
						nativeParallelHashMap[num8] = value3;
						float num26 = num22 - float6.y;
						num27 = num18 * num26;
						float num28 = num21 - float6.x;
						num29 = num18 * num28;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X28_v9 (Il2CppMethodInfo)+C70]");
						num9 = 0;
						value4.x = num29;
						value4.y = num27;
						nativeParallelHashMap[num10] = value4;
						bool flag10;
						bool flag11;
						if (!(num16 < 1f))
						{
							int num30 = num8 - num10;
							flag10 = num30 < 0;
							int num31 = num8 ^ num10;
							int num32 = num8 ^ num30;
							int num33 = num31 & num32;
							flag11 = num33 < 0;
						}
						else
						{
							flag11 = false;
							flag10 = false;
						}
						bool flag12 = flag10 == flag11;
						float num34 = 0.5f;
						num6 = 1f;
						num7 = num27;
						enumerator3 = (global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator)num29;
						if (!flag12)
						{
							nint num35 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v21 (Il2CppMethodInfo)+5B0]");
							obj5 = 0;
							(int, int) item = (num8, num10);
							nint num36 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v24 (Il2CppMethodInfo)+5C0]");
							object obj6 = 0;
							int version = list._version + 1;
							list._version = version;
							(int, int)[] items = list._items;
							if (list.Count < items.Length)
							{
								int size = list.Count + 1;
								list._size = size;
								int num37 = list.Count << 3;
								object obj7 = (nint)items + num37;
								num34 = 0.5f;
								num9 = num10;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v21 (Il2CppMethodInfo)+5B0]");
								obj = 0;
								num6 = 1f;
								num7 = num27;
								enumerator3 = (global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator)num29;
							}
							else
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v26+20]");
								object obj8 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27+C0]");
								object obj9 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v28+70]");
								num9 = 0;
								list.Add(item);
								num34 = 0.5f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v21 (Il2CppMethodInfo)+5B0]");
								obj = 0;
								num6 = 1f;
								num7 = num27;
								enumerator3 = (global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator)num29;
							}
						}
						continue;
					}
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X27_v4 (Il2CppMethodInfo)+378]");
					obj5 = 0;
					num27 = num7;
				}
				else
				{
					global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
					float num34 = 0.5f;
					int num9 = num10;
					enumerator3 = (global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator)num29;
				}
				obj = obj5;
				enumerator5 = (global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator)(&enumerator4);
				num7 = num27;
				num38 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v4 (Il2CppMethodInfo)+1F0]");
				num3 = 0;
				time = (float)enumerator3;
				goto IL_072f;
			}
			nint num39 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v18 (Il2CppMethodInfo)+1E8]");
			num3 = 0;
			enumerator4.Dispose();
			enumerator5 = (global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>.Enumerator)(&enumerator4);
			num38 = 0;
			time = (float)enumerator3;
			goto IL_0556;
		}
		goto IL_072f;
		IL_0556:
		if (list != null)
		{
			global::System.Collections.Generic.List<(int, int)>.Enumerator enumerator6 = list.GetEnumerator();
			int bId = default(int);
			while (enumerator.MoveNext())
			{
				FinishMerge(0, bId);
			}
			enumerator.Dispose();
			return;
		}
		goto IL_072f;
		IL_072f:
		global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
		bool flag13 = num3 != 1;
		global::System.NullReferenceException ex4 = ex3;
		if (!flag13)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num40 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v5 (Il2CppMethodInfo)+1E8]");
			num3 = 0;
			enumerator5.Dispose();
			object obj10 = default(object);
			bool flag14 = obj10 == null;
			int num38 = (int)obj10;
			if (flag14)
			{
				goto IL_0556;
			}
			global::System.OutOfMemoryException ex5 = new global::System.OutOfMemoryException();
			num38 = (int)obj10;
			ex4 = (global::System.NullReferenceException)(object)ex5;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0E2C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000294")]
	[global::Cpp2ILInjected.Address(RVA = "0x10052AC", Offset = "0x10052AC", Length = "0x218")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0027;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0x588;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, aId, bId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x378;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, aId, bId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv164 = Il2CppMethodInfo;\n\tv165 = v164 + 0x990;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v165, aId, bId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302AA34]) = v56;\nL_0027:\n\t;\n\tv68 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(this.exploding, aId);\n\tv167 = v68 == 0;\n\tv168 = ~v167;\n\tif (v168) goto L_00AE;\n\tv196 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(this.exploding, bId);\n\tv250 = v196 == 0;\n\tv199 = ~v250;\n\tif (v199) goto L_00AE;\n\tv251 = Il2CppMethodInfo;\n\tv197 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, aId, &v121 @ stack_-68_v4 (System.Object));\n\tv200 = ~v197;\n\tif (v200) goto L_00AE;\n\tv143 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, bId, &v119 @ stack_-70_v4 (System.Object));\n\tv201 = ~v143;\n\tif (v201) goto L_00AE;\n\tv111 = *([v121 @ stack_-68_v4 (System.Object)+B0]) + 1;\n\tv257 = v111 == 2;\n\tif (v257) goto L_FFFFFFFF;\n\tv263 = *([v121 @ stack_-68_v4 (System.Object)+F0]) == 0;\n\tif (v263) goto L_00B4;\nL_0069:\n\tFluidSolver::RemovePowerUp(this, aId, 0f);\n\tFluidSolver::RemovePowerUp(this, bId, 0f);\n\tv287 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_007C;\n\tv291 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv292 = v291 + 0xBD8;\n\tv293 = \"il2cpp_codegen_initialize_runtime_metadata\"(v292, v284, v135, v124, v41, v42, v43, v44, v82, v46, v47, v48, v49, v50, v51, v52);\n\tv295 = 1;\n\t*([302AA35]) = v295;\nL_007C:\n\tv144 = new *([v287 @ X25_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BD8])();\n\tFluidSolver+<SpawnMergedPowerUp>d__168::.ctor(v144, 0);\n\tv83 = *([v121 @ stack_-68_v4 (System.Object)+60]) + *([v119 @ stack_-70_v4 (System.Object)+60]);\n\tv76 = v83 * 0x3F;\n\tv298 = v144 + 0x28;\n\tv144.<>4__this = this;\n\tv300 = 0xF3F1B4(v298, this, 0, *([v251 @ X22_v7 (Il2CppMethodInfo)+378]), v41, v42, v43, v44, v83, 0x3F, v47, v48, v49, v50, v51, v52);\n\tv144.pos = v76;\n\tv144.layer = v111;\n\tv144.delay = 0f;\n\tv144.isBig = v85;\n\tv302 = UnityEngine.MonoBehaviour::StartCoroutine(this, v144);\n\tv304 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::Remove(this.merging, aId);\n\tv195 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::Remove(this.merging, bId);\nL_00AE:\n\treturn;\nL_00B4:\n\tv272 = *([v119 @ stack_-70_v4 (System.Object)+F0]) == 0;\n\tv277 = ~v272;\n\tgoto L_0069;\n\tthrow System.NullReferenceException;\n\treturn;\n// 128 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void FinishMerge(int aId, int bId)
	{
		//IL_0280: Expected I, but got O
		//IL_0165: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0183: Expected O, but got I
		if (exploding.Contains(aId) || exploding.Contains(bId))
		{
			return;
		}
		nint num = 0;
		PowerUp value;
		PowerUp value2;
		if (!powerUpById.TryGetValue(aId, out value) || !powerUpById.TryGetValue(bId, out value2))
		{
			return;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ stack_-68_v4 (System.Object)+B0]");
		int num2 = (int)((nint)0 + (nint)1);
		bool isBig;
		if (num2 != 2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ stack_-68_v4 (System.Object)+F0]");
			if ((nint)0 == 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ stack_-70_v4 (System.Object)+F0]");
				bool flag = (nint)0 == 0;
				bool flag2 = !flag;
				isBig = flag2;
				goto IL_0254;
			}
		}
		isBig = true;
		goto IL_0254;
		IL_0254:
		RemovePowerUp(aId, 0f);
		RemovePowerUp(bId, 0f);
		FluidSolver._003CSpawnMergedPowerUp_003Ed__168 _003CSpawnMergedPowerUp_003Ed__169 = new FluidSolver._003CSpawnMergedPowerUp_003Ed__168(0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ stack_-68_v4 (System.Object)+60]");
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ stack_-70_v4 (System.Object)+60]");
		object obj = num4 + 0;
		global::UnityEngine.Vector2 pos = (global::UnityEngine.Vector2)((nint)obj * 63);
		_003CSpawnMergedPowerUp_003Ed__169._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CSpawnMergedPowerUp_003Ed__169.pos = pos;
		_003CSpawnMergedPowerUp_003Ed__169.layer = num2;
		_003CSpawnMergedPowerUp_003Ed__169.delay = 0f;
		_003CSpawnMergedPowerUp_003Ed__169.isBig = isBig;
		global::UnityEngine.Coroutine coroutine = StartCoroutine(_003CSpawnMergedPowerUp_003Ed__169);
		bool flag3 = merging.Remove(aId);
		bool flag4 = merging.Remove(bId);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FluidSolver._003CSpawnMergedPowerUp_003Ed__168))]
	[global::Cpp2ILInjected.Token(Token = "0x6000295")]
	[global::Cpp2ILInjected.Address(RVA = "0x10057E0", Offset = "0x10057E0", Length = "0xBC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv40 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0023;\n\tv45 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv46 = v45 + 0xBD8;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, layer, isBig, methodInfo, v49, v50, v51, v52, pos, v0, delay, v53, v54, v55, v56, v57);\n\tv60 = 1;\n\t*([302AA35]) = v60;\nL_0023:\n\tv62 = new *([v40 @ X23_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BD8])();\n\tFluidSolver+<SpawnMergedPowerUp>d__168::.ctor(v62, 0);\n\tv68 = v62 + 0x28;\n\tv62.<>4__this = this;\n\tv70 = 0xF3F1B4(v68, this, 0, methodInfo, v49, v50, v51, v52, pos, pos.y, delay, v53, v54, v55, v56, v57);\n\tv62.pos = pos;\n\tv62.pos.y = pos.y;\n\tv62.layer = layer;\n\tv62.delay = delay;\n\tv62.isBig = isBig;\n\treturn v62;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator SpawnMergedPowerUp(global::UnityEngine.Vector2 pos, int layer, float delay, bool isBig)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		FluidSolver._003CSpawnMergedPowerUp_003Ed__168 _003CSpawnMergedPowerUp_003Ed__169 = new FluidSolver._003CSpawnMergedPowerUp_003Ed__168(0);
		_003CSpawnMergedPowerUp_003Ed__169._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CSpawnMergedPowerUp_003Ed__169.pos = pos;
		_003CSpawnMergedPowerUp_003Ed__169.pos.y = pos.y;
		_003CSpawnMergedPowerUp_003Ed__169.layer = layer;
		_003CSpawnMergedPowerUp_003Ed__169.delay = delay;
		_003CSpawnMergedPowerUp_003Ed__169.isBig = isBig;
		return _003CSpawnMergedPowerUp_003Ed__169;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000296")]
	[global::Cpp2ILInjected.Address(RVA = "0x10054C4", Offset = "0x10054C4", Length = "0x31C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_003B;\n\tv35 = System.Collections.Generic.NullableComparer`1;\n\tv36 = v35 + 0xC48;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x370;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0x378;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv66 = Il2CppMethodInfo;\n\tv67 = v66 + 0x980;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv193 = Il2CppMethodInfo;\n\tv194 = v193 + 0x9A0;\n\tv195 = \"il2cpp_codegen_initialize_runtime_metadata\"(v194, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv198 = Il2CppMethodInfo;\n\tv199 = v198 + 0x968;\n\tv200 = \"il2cpp_codegen_initialize_runtime_metadata\"(v199, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv246 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv247 = v246 + 0x5D8;\n\tv248 = \"il2cpp_codegen_initialize_runtime_metadata\"(v247, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv249 = Il2CppMethodInfo;\n\tv250 = v249 + 0xAC8;\n\tv251 = \"il2cpp_codegen_initialize_runtime_metadata\"(v250, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv262 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv263 = v262 + 0xFD8;\n\tv264 = \"il2cpp_codegen_initialize_runtime_metadata\"(v263, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv303 = Il2CppMethodInfo;\n\tv304 = v303 + 0xD78;\n\tv305 = \"il2cpp_codegen_initialize_runtime_metadata\"(v304, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv311 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv312 = v311 + 0xBB0;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v312, puId, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AA19]) = v54;\nL_003B:\n\tv56 = new *([v30 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BB0])();\n\tFluidSolver+<>c__DisplayClass169_0::.ctor(v56);\n\tv69 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv74 = v56 + 0x10;\n\tv56.<>4__this = this;\n\tv77 = 0xF3F1B4(v74, this, methodInfo, v39, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\n\tv56.puId = puId;\n\tv196 = this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v196);\n\tv166 = new *([v69 @ X23_v2 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v166);\n\tv302 = this.<ActiveCount>k__BackingField;\n\tv108 = this.<ActiveCount>k__BackingField < 1;\n\tif (v108) goto L_00BB;\n\tv173 = v166 == 0;\n\tif (v173) goto L_0088;\n\tgoto L_0073;\nL_0067:\n\tv327 = v327 + 1;\n\tv270 = v327 >= v302;\n\tif (v270) goto L_00BB;\nL_0073:\n\tv329 = this.powerUpIds;\n\tv339 = *([v329 @ X9_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v327 @ X22_v13 (System.Int32)*4]) != v56.puId;\n\tif (v339) goto L_0067;\n\tv342 = this.particleIds;\n\tv346 = System.Collections.Generic.HashSet`1<System.Int32>::Add(v166, *([v342 @ X8_v20 (Unity.Collections.NativeArray`1<System.Int32>)+v327 @ X22_v13 (System.Int32)*4]));\n\tv302 = this.<ActiveCount>k__BackingField;\n\tgoto L_0067;\nL_0088:\n\tv104 = this.powerUpIds;\n\tv133 = *([v104 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)]) == v56.puId;\n\tif (v133) goto L_0123;\n\tv340 = this.<ActiveCount>k__BackingField < 2;\n\tv295 = ~v340;\n\tv271 = ~v295;\n\tif (v271) goto L_00BB;\nL_00A6:\n\tv134 = *([v104 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v90 @ X11_v5 (System.Int32)*4]) == v56.puId;\n\tif (v134) goto L_0123;\n\tv90 = v90 + 1;\n\tv387 = v90 < v302;\n\tv293 = ~v387;\n\tv269 = ~v293;\n\tif (v269) goto L_00A6;\nL_00BB:\n\t;\n\tv181 = v56 + 0x18;\n\tv310 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, v56.puId, v181);\n\tv341 = ~v310;\n\tif (v341) goto L_00F7;\n\tv383 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::Remove(this.powerUpById, v56.puId);\n\tv395 = System.Collections.Generic.List`1<PowerUp>::Remove(this.powerUps, *([v181 @ X22_v7 (System.Object&)]));\n\tv399 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv400 = *([v399 @ X24_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv401 = *([v400 @ X0_v28+E0]) == 0;\n\tif (v401) goto L_00E5;\n\tv358 = UnityEngine.Object::op_Implicit(*([v181 @ X22_v7 (System.Object&)]));\n\tv405 = ~v358;\n\tv362 = ~v405;\n\tif (v362) goto L_00EC;\n\tgoto L_00F7;\nL_00E5:\n\tv359 = UnityEngine.Object::op_Implicit(*([v181 @ X22_v7 (System.Object&)]));\n\tv363 = ~v359;\n\tif (v363) goto L_00F7;\nL_00EC:\n\tv411 = UnityEngine.Component::get_gameObject(*([v181 @ X22_v7 (System.Object&)]));\n\tgoto L_00F6;\n\tv414 = \"il2cpp_codegen_runtime_class_init\"(v412, v410, v96, v85, v40, v41, v42, v43, delay, v44, v45, v46, v47, v48, v49, v50);\nL_00F6:\n\tUnityEngine.Object::Destroy(v411);\nL_00F7:\n\tv368 = System.Collections.Generic.NullableComparer`1;\n\tv369 = Il2CppMethodInfo;\n\tv371 = new *([v368 @ X8_v9 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+C48])();\n\tSystem.Action`1<System.Collections.Generic.HashSet`1<System.Int32>>::.ctor(v371, v56, *([v369 @ X23_v6 (Il2CppMethodInfo)+D78]));\n\tv391 = FluidSolver::HandleRemove(this, v166, v371, 0, delay);\n\tv398 = UnityEngine.MonoBehaviour::StartCoroutine(this, v391);\n\tFluidSolver::RemoveAllPairsWith(this, v56.puId);\n\tv230 = System.Collections.Generic.HashSet`1<System.Int32>::Remove(this.exploding, v56.puId);\n\treturn;\nL_0123:\n\tthrow System.NullReferenceException;\n// 182 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemovePowerUp(int puId, float delay = 0.3f)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0360: Expected I, but got O
		//IL_0299: Expected I, but got O
		//IL_02a9: Expected O, but got I
		FluidSolver._003C_003Ec__DisplayClass169_0 _003C_003Ec__DisplayClass169_1 = new FluidSolver._003C_003Ec__DisplayClass169_0();
		_003C_003Ec__DisplayClass169_1._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003C_003Ec__DisplayClass169_1.puId = puId;
		_lastJob.Complete();
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		int activeCount = ActiveCount;
		if (ActiveCount >= 1)
		{
			if (hashSet == null)
			{
				global::Unity.Collections.NativeArray<int> nativeArray = powerUpIds;
				if ((nint)nativeArray != _003C_003Ec__DisplayClass169_1.puId)
				{
					if (ActiveCount < 2)
					{
						goto IL_0213;
					}
					int num3 = 1;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v90 @ X11_v5 (System.Int32)*4]");
						if ((nint)0 == _003C_003Ec__DisplayClass169_1.puId)
						{
							break;
						}
						num3++;
						if (num3 < activeCount)
						{
							continue;
						}
						goto IL_0213;
					}
				}
				throw new global::System.NullReferenceException();
			}
			int num4 = 0;
			do
			{
				global::Unity.Collections.NativeArray<int> nativeArray2 = powerUpIds;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X9_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v327 @ X22_v13 (System.Int32)*4]");
				if ((nint)0 == _003C_003Ec__DisplayClass169_1.puId)
				{
					global::Unity.Collections.NativeArray<int> nativeArray3 = particleIds;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20 (Unity.Collections.NativeArray`1<System.Int32>)+v327 @ X22_v13 (System.Int32)*4]");
					bool flag = hashSet.Add(0);
					activeCount = ActiveCount;
				}
				num4++;
			}
			while (num4 < activeCount);
		}
		goto IL_0213;
		IL_0331:
		ref object reference;
		global::UnityEngine.GameObject obj2 = ((global::UnityEngine.Component)reference).gameObject;
		global::UnityEngine.Object.Destroy(obj2);
		goto IL_0352;
		IL_0213:
		reference = ref *(object*)((nint)_003C_003Ec__DisplayClass169_1 + 24);
		if (powerUpById.TryGetValue(_003C_003Ec__DisplayClass169_1.puId, out global::System.Runtime.CompilerServices.Unsafe.As<object, PowerUp>(ref reference)))
		{
			bool flag2 = powerUpById.Remove(_003C_003Ec__DisplayClass169_1.puId);
			bool flag3 = powerUps.Remove((PowerUp)reference);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X24_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v28+E0]");
			if ((nint)0 != 0)
			{
				if ((bool)(global::UnityEngine.Object)reference)
				{
					goto IL_0331;
				}
			}
			else if ((bool)(global::UnityEngine.Object)reference)
			{
				goto IL_0331;
			}
		}
		goto IL_0352;
		IL_0352:
		nint num7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X23_v6 (Il2CppMethodInfo)+D78]");
		global::System.Action<global::System.Collections.Generic.HashSet<int>> onRemove = new global::System.Action<global::System.Collections.Generic.HashSet<int>>(_003C_003Ec__DisplayClass169_1, (global::System.IntPtr)0);
		global::System.Collections.IEnumerator routine = HandleRemove(hashSet, onRemove, explode: false, delay);
		global::UnityEngine.Coroutine coroutine = StartCoroutine(routine);
		RemoveAllPairsWith(_003C_003Ec__DisplayClass169_1.puId);
		bool flag4 = exploding.Remove(_003C_003Ec__DisplayClass169_1.puId);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000297")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFFB94", Offset = "0xFFFB94", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xB78;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0xB80;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0xB88;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0xAC0;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA1A]) = v46;\nL_0022:\n\tv47 = 0;\n\tv51 = this.powerUps == 0;\n\tif (v51) goto L_005A;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv86 = Il2CppMethodInfo + 0xB78;\n\tv66 = System.Collections.Generic.List`1<PowerUp>::GetEnumerator(this.powerUps);\n\tv96 = this + 0x378;\nL_0037:\n\tv136 = *([v57 @ X23_v4 (Il2CppMethodInfo)+B80]);\n\tv116 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv131 = v116 == 0;\n\tif (v131) goto L_004D;\n\tv94 = 0;\n\tv74 = FluidSolver::GetAveragePositionFromIDs(this, *([v94 @ X8_v9 (System.Int32)+88]));\n\tv72 = v74.y;\n\tv70 = *([v59 @ X24_v4 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v96, *([v94 @ X8_v9 (System.Int32)+6C]), v74);\n\tgoto L_0037;\nL_004D:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0057:\n\treturn;\n\tv90 = new System.NullReferenceException();\nL_005A:\n\tv97 = new System.NullReferenceException();\n\tgoto L_0068;\n\tgoto L_0068;\n\tgoto L_0068;\nL_0068:\n\tv127 = v136 != 1;\n\tif (v127) goto L_0078;\n\tv133 = 0x274A080(v97, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv149 = 0x274A098(v133, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv136 = *([v86 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv141 = *([v133 @ X0_v12]) == 0;\n\tif (v141) goto L_0057;\n\tv139 = new System.OutOfMemoryException();\nL_0078:\n\tv145 = 0xBF0DEC(&v81 @ stack_-68_v1 (System.Int32), v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv151 = 0x27498DC(v142, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv197 = 0xD6F8(v151, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdatePowerUpMidpoints()
	{
		//IL_001f: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0142: Expected I4, but got O
		global::System.Collections.Generic.List<object>.Enumerator enumerator = default(global::System.Collections.Generic.List<object>.Enumerator);
		bool flag = powerUps == null;
		int num = 0;
		nint num4 = default(nint);
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			object obj = (nint)0 + (nint)2936;
			global::System.Collections.Generic.List<PowerUp>.Enumerator enumerator2 = powerUps.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = powerUpMidpoints;
			object obj3 = default(object);
			object obj2 = obj3;
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = float6;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4 (Il2CppMethodInfo)+B80]");
				num4 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+88]");
				float5 = GetAveragePositionFromIDs((global::System.Collections.Generic.HashSet<int>)0);
				float y = float5.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C70]");
				obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+6C]");
				nativeParallelHashMap[0] = float5;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag2 = num4 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			object obj = default(object);
			num4 = (nint)obj;
			enumerator.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num = (int)obj4;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0DEC");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000298")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFFD10", Offset = "0xFFFD10", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x668;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x670;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0x678;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x958;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA1B]) = v46;\nL_0022:\n\tv47 = 0;\n\tv51 = this.caterpillars == 0;\n\tif (v51) goto L_005A;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv86 = Il2CppMethodInfo + 0x668;\n\tv66 = System.Collections.Generic.List`1<Caterpillar>::GetEnumerator(this.caterpillars);\n\tv96 = this + 0x308;\nL_0037:\n\tv136 = *([v57 @ X23_v4 (Il2CppMethodInfo)+670]);\n\tv116 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv131 = v116 == 0;\n\tif (v131) goto L_004D;\n\tv94 = 0;\n\tv74 = FluidSolver::GetAveragePositionFromIDs(this, *([v94 @ X8_v9 (System.Int32)+88]));\n\tv72 = v74.y;\n\tv70 = *([v59 @ X24_v4 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v96, *([v94 @ X8_v9 (System.Int32)+6C]), v74);\n\tgoto L_0037;\nL_004D:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0057:\n\treturn;\n\tv90 = new System.NullReferenceException();\nL_005A:\n\tv97 = new System.NullReferenceException();\n\tgoto L_0068;\n\tgoto L_0068;\n\tgoto L_0068;\nL_0068:\n\tv127 = v136 != 1;\n\tif (v127) goto L_0078;\n\tv133 = 0x274A080(v97, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv149 = 0x274A098(v133, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv136 = *([v86 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv141 = *([v133 @ X0_v12]) == 0;\n\tif (v141) goto L_0057;\n\tv139 = new System.OutOfMemoryException();\nL_0078:\n\tv145 = 0xBF0EAC(&v81 @ stack_-68_v1 (System.Int32), v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv151 = 0x27498DC(v142, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv197 = 0xD6F8(v151, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateCaterpillarMidpoints()
	{
		//IL_001f: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0142: Expected I4, but got O
		global::System.Collections.Generic.List<object>.Enumerator enumerator = default(global::System.Collections.Generic.List<object>.Enumerator);
		bool flag = caterpillars == null;
		int num = 0;
		nint num4 = default(nint);
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			object obj = (nint)0 + (nint)1640;
			global::System.Collections.Generic.List<Caterpillar>.Enumerator enumerator2 = caterpillars.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = caterpillarMidpoints;
			object obj3 = default(object);
			object obj2 = obj3;
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = float6;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4 (Il2CppMethodInfo)+670]");
				num4 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+88]");
				float5 = GetAveragePositionFromIDs((global::System.Collections.Generic.HashSet<int>)0);
				float y = float5.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C70]");
				obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+6C]");
				nativeParallelHashMap[0] = float5;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag2 = num4 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			object obj = default(object);
			num4 = (nint)obj;
			enumerator.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num = (int)obj4;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0EAC");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000299")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFFE8C", Offset = "0xFFFE8C", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x620;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x628;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0x630;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x7E0;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA1C]) = v46;\nL_0022:\n\tv47 = 0;\n\tv51 = this.bees == 0;\n\tif (v51) goto L_005A;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv86 = Il2CppMethodInfo + 0x620;\n\tv66 = System.Collections.Generic.List`1<Bee>::GetEnumerator(this.bees);\n\tv96 = this + 0x330;\nL_0037:\n\tv136 = *([v57 @ X23_v4 (Il2CppMethodInfo)+628]);\n\tv116 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv131 = v116 == 0;\n\tif (v131) goto L_004D;\n\tv94 = 0;\n\tv74 = FluidSolver::GetAveragePositionFromIDs(this, *([v94 @ X8_v9 (System.Int32)+88]));\n\tv72 = v74.y;\n\tv70 = *([v59 @ X24_v4 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v96, *([v94 @ X8_v9 (System.Int32)+6C]), v74);\n\tgoto L_0037;\nL_004D:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0057:\n\treturn;\n\tv90 = new System.NullReferenceException();\nL_005A:\n\tv97 = new System.NullReferenceException();\n\tgoto L_0068;\n\tgoto L_0068;\n\tgoto L_0068;\nL_0068:\n\tv127 = v136 != 1;\n\tif (v127) goto L_0078;\n\tv133 = 0x274A080(v97, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv149 = 0x274A098(v133, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv136 = *([v86 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv141 = *([v133 @ X0_v12]) == 0;\n\tif (v141) goto L_0057;\n\tv139 = new System.OutOfMemoryException();\nL_0078:\n\tv145 = 0xBF0EEC(&v81 @ stack_-68_v1 (System.Int32), v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv151 = 0x27498DC(v142, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv197 = 0xD6F8(v151, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateBeeMidpoints()
	{
		//IL_001f: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0142: Expected I4, but got O
		global::System.Collections.Generic.List<object>.Enumerator enumerator = default(global::System.Collections.Generic.List<object>.Enumerator);
		bool flag = bees == null;
		int num = 0;
		nint num4 = default(nint);
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			object obj = (nint)0 + (nint)1568;
			global::System.Collections.Generic.List<Bee>.Enumerator enumerator2 = bees.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = beeMidpoints;
			object obj3 = default(object);
			object obj2 = obj3;
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = float6;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4 (Il2CppMethodInfo)+628]");
				num4 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+88]");
				float5 = GetAveragePositionFromIDs((global::System.Collections.Generic.HashSet<int>)0);
				float y = float5.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C70]");
				obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+6C]");
				nativeParallelHashMap[0] = float5;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag2 = num4 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			object obj = default(object);
			num4 = (nint)obj;
			enumerator.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num = (int)obj4;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0EEC");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600029A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFFA18", Offset = "0xFFFA18", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x788;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x790;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0x798;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0xF58;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA1D]) = v46;\nL_0022:\n\tv47 = 0;\n\tv51 = this.fishes == 0;\n\tif (v51) goto L_005A;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv86 = Il2CppMethodInfo + 0x788;\n\tv66 = System.Collections.Generic.List`1<Fish>::GetEnumerator(this.fishes);\n\tv96 = this + 0x388;\nL_0037:\n\tv136 = *([v57 @ X23_v4 (Il2CppMethodInfo)+790]);\n\tv116 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv131 = v116 == 0;\n\tif (v131) goto L_004D;\n\tv94 = 0;\n\tv74 = FluidSolver::GetAveragePositionFromIDs(this, *([v94 @ X8_v9 (System.Int32)+88]));\n\tv72 = v74.y;\n\tv70 = *([v59 @ X24_v4 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v96, *([v94 @ X8_v9 (System.Int32)+6C]), v74);\n\tgoto L_0037;\nL_004D:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0057:\n\treturn;\n\tv90 = new System.NullReferenceException();\nL_005A:\n\tv97 = new System.NullReferenceException();\n\tgoto L_0068;\n\tgoto L_0068;\n\tgoto L_0068;\nL_0068:\n\tv127 = v136 != 1;\n\tif (v127) goto L_0078;\n\tv133 = 0x274A080(v97, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv149 = 0x274A098(v133, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv136 = *([v86 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv141 = *([v133 @ X0_v12]) == 0;\n\tif (v141) goto L_0057;\n\tv139 = new System.OutOfMemoryException();\nL_0078:\n\tv145 = 0xBF0F2C(&v81 @ stack_-68_v1 (System.Int32), v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv151 = 0x27498DC(v142, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv197 = 0xD6F8(v151, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateFishMidpoints()
	{
		//IL_001f: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0142: Expected I4, but got O
		global::System.Collections.Generic.List<object>.Enumerator enumerator = default(global::System.Collections.Generic.List<object>.Enumerator);
		bool flag = fishes == null;
		int num = 0;
		nint num4 = default(nint);
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			object obj = (nint)0 + (nint)1928;
			global::System.Collections.Generic.List<Fish>.Enumerator enumerator2 = fishes.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = fishMidpoints;
			object obj3 = default(object);
			object obj2 = obj3;
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = float6;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4 (Il2CppMethodInfo)+790]");
				num4 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+88]");
				float5 = GetAveragePositionFromIDs((global::System.Collections.Generic.HashSet<int>)0);
				float y = float5.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C70]");
				obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+6C]");
				nativeParallelHashMap[0] = float5;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag2 = num4 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			object obj = default(object);
			num4 = (nint)obj;
			enumerator.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num = (int)obj4;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0F2C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600029B")]
	[global::Cpp2ILInjected.Address(RVA = "0x100589C", Offset = "0x100589C", Length = "0x1BC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0x968;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, ids, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x970;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, ids, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv83 = Il2CppMethodInfo;\n\tv84 = v83 + 0x978;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, ids, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0x998;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, ids, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv129 = Il2CppMethodInfo;\n\tv130 = v129 + 0xC28;\n\tv131 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, ids, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv149 = System.Xml.ValidateNames;\n\tv150 = v149 + 0xD40;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v150, ids, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302AA1E]) = v55;\nL_002A:\n\tv56 = 0;\n\tv60 = v139 == 0;\n\tif (v60) goto L_006F;\n\tv64 = System.Xml.ValidateNames;\n\tv68 = Il2CppMethodInfo;\n\tv70 = Il2CppMethodInfo;\n\tv72 = Il2CppMethodInfo;\n\tv74 = *([v64 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv75 = *([v74 @ X8_v6+B8]);\n\tv186 = *([v75 @ X8_v7]);\n\tv81 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v139);\n\tv89 = this + 0x1F8;\nL_0048:\n\tv117 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v56 @ stack_-78_v1, *([v68 @ X23_v3 (Il2CppMethodInfo)+970]));\n\tv132 = v117 & 1;\n\tv133 = v132 == 0;\n\tif (v133) goto L_005C;\n\tv108 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v89, 0, &v96 @ stack_-7C_v4, *([v70 @ X24_v3 (Il2CppMethodInfo)+C28]));\n\tv158 = v108 & 1;\n\tv110 = v158 == 0;\n\tif (v110) goto L_0048;\n\tv106 = this.positions;\n\tv186 = v186 + *([v106 @ X9_v5 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v96 @ stack_-7C_v4*8]);\n\tv196 = v196 + 1;\n\tgoto L_0048;\nL_005C:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v56 @ stack_-78_v1, *([v72 @ X22_v3 (Il2CppMethodInfo)+968]));\nL_005E:\n\t// 94 NotImplemented \"Instruction DUP not yet implemented.\"\n\treturnVal1 = v186 / v196;\n\treturn returnVal1;\nL_006F:\n\tv82 = new System.NullReferenceException();\n\tgoto L_007B;\nL_007B:\n\tv128 = v139 != 1;\n\tif (v128) goto L_008B;\n\tv135 = 0x274A080(v82, v139, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv155 = 0x274A098(v135, v139, methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v182, *([v13 @ X22]));\n\tv144 = *([v135 @ X0_v10]) == 0;\n\tif (v144) goto L_005E;\n\tv142 = new System.OutOfMemoryException();\nL_008B:\n\tv148 = 0xBF092C(&v138 @ stack_-90, *([v13 @ X22]), methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv157 = 0x27498DC(v145, *([v13 @ X22]), methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\tv215 = 0xD6F8(v157, *([v13 @ X22]), methodInfo, v39, v40, v41, v42, v43, returnVal2, v45, v46, v47, v48, v49, v50, v51);\n\treturn returnVal2;\n// 81 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::Unity.Mathematics.float2 GetAveragePositionFromIDs(global::System.Collections.Generic.HashSet<int> ids)
	{
		//IL_01b5: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_0036: Expected O, but got I
		//IL_0046: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_00cb: Expected O, but got I
		object obj = 0;
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		object obj4 = default(object);
		int num5;
		if (hashSet != null)
		{
			nint num2 = 0;
			nint num3 = 0;
			nint num4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+B8]");
			object obj3 = 0;
			obj4 = obj3;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			num5 = 0;
			object obj6 = default(object);
			object obj7 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj6 & 1) == 0)
				{
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
				if ((int)((nint)obj7 & 1) != 0)
				{
					global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray = positions;
					nint num6 = (nint)obj4;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v5 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v96 @ stack_-7C_v4*8]");
					obj4 = num6 + 0;
					num5++;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			goto IL_00ed;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag = (nint)hashSet != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj8 = default(object);
			bool flag2 = obj8 == null;
			num5 = 50503680;
			if (flag2)
			{
				goto IL_00ed;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			object obj9 = obj8;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
		global::Unity.Mathematics.float2 result = default(global::Unity.Mathematics.float2);
		return result;
		IL_00ed:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		return (global::Unity.Mathematics.float2)((nint)obj4 / num5);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600029C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1000008", Offset = "0x1000008", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xAD0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0xAD8;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0xAE0;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x938;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA1F]) = v46;\nL_0022:\n\tv47 = 0;\n\tv51 = this.octopi == 0;\n\tif (v51) goto L_005A;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv86 = Il2CppMethodInfo + 0xAD0;\n\tv66 = System.Collections.Generic.List`1<Octopus>::GetEnumerator(this.octopi);\n\tv96 = this + 0x3B8;\nL_0037:\n\tv136 = *([v57 @ X23_v4 (Il2CppMethodInfo)+AD8]);\n\tv116 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv131 = v116 == 0;\n\tif (v131) goto L_004D;\n\tv94 = 0;\n\tv74 = FluidSolver::GetAveragePositionFromIDs(this, *([v94 @ X8_v9 (System.Int32)+B0]));\n\tv72 = v74.y;\n\tv70 = *([v59 @ X24_v4 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v96, *([v94 @ X8_v9 (System.Int32)+6C]), v74);\n\tgoto L_0037;\nL_004D:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0057:\n\treturn;\n\tv90 = new System.NullReferenceException();\nL_005A:\n\tv97 = new System.NullReferenceException();\n\tgoto L_0068;\n\tgoto L_0068;\n\tgoto L_0068;\nL_0068:\n\tv127 = v136 != 1;\n\tif (v127) goto L_0078;\n\tv133 = 0x274A080(v97, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv149 = 0x274A098(v133, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv136 = *([v86 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv141 = *([v133 @ X0_v12]) == 0;\n\tif (v141) goto L_0057;\n\tv139 = new System.OutOfMemoryException();\nL_0078:\n\tv145 = 0xBF0F6C(&v81 @ stack_-68_v1 (System.Int32), v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv151 = 0x27498DC(v142, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv197 = 0xD6F8(v151, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateOctopusHeadMidpoints()
	{
		//IL_001f: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0142: Expected I4, but got O
		global::System.Collections.Generic.List<object>.Enumerator enumerator = default(global::System.Collections.Generic.List<object>.Enumerator);
		bool flag = octopi == null;
		int num = 0;
		nint num4 = default(nint);
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			object obj = (nint)0 + (nint)2768;
			global::System.Collections.Generic.List<Octopus>.Enumerator enumerator2 = octopi.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = octopusHeadMidpoints;
			object obj3 = default(object);
			object obj2 = obj3;
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = float6;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4 (Il2CppMethodInfo)+AD8]");
				num4 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+B0]");
				float5 = GetAveragePositionFromIDs((global::System.Collections.Generic.HashSet<int>)0);
				float y = float5.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C70]");
				obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+6C]");
				nativeParallelHashMap[0] = float5;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag2 = num4 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			object obj = default(object);
			num4 = (nint)obj;
			enumerator.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num = (int)obj4;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0F6C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600029D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1000184", Offset = "0x1000184", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xCC8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0xCD0;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv98 = Il2CppMethodInfo;\n\tv99 = v98 + 0xCD8;\n\tv100 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x278;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA20]) = v46;\nL_0022:\n\tv47 = 0;\n\tv51 = this.sponges == 0;\n\tif (v51) goto L_005A;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv86 = Il2CppMethodInfo + 0xCC8;\n\tv66 = System.Collections.Generic.List`1<Sponge>::GetEnumerator(this.sponges);\n\tv96 = this + 0x3A8;\nL_0037:\n\tv136 = *([v57 @ X23_v4 (Il2CppMethodInfo)+CD0]);\n\tv116 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv131 = v116 == 0;\n\tif (v131) goto L_004D;\n\tv94 = 0;\n\tv74 = FluidSolver::GetAveragePositionFromIDs(this, *([v94 @ X8_v9 (System.Int32)+88]));\n\tv72 = v74.y;\n\tv70 = *([v59 @ X24_v4 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v96, *([v94 @ X8_v9 (System.Int32)+6C]), v74);\n\tgoto L_0037;\nL_004D:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0057:\n\treturn;\n\tv90 = new System.NullReferenceException();\nL_005A:\n\tv97 = new System.NullReferenceException();\n\tgoto L_0068;\n\tgoto L_0068;\n\tgoto L_0068;\nL_0068:\n\tv127 = v136 != 1;\n\tif (v127) goto L_0078;\n\tv133 = 0x274A080(v97, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv149 = 0x274A098(v133, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv136 = *([v86 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v47 @ stack_-58_v1 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv141 = *([v133 @ X0_v12]) == 0;\n\tif (v141) goto L_0057;\n\tv139 = new System.OutOfMemoryException();\nL_0078:\n\tv145 = 0xBF0FAC(&v81 @ stack_-68_v1 (System.Int32), v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv151 = 0x27498DC(v142, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\tv197 = 0xD6F8(v151, v136, v70, v30, v31, v32, v33, v34, v74, v72, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateSpongeMidpoints()
	{
		//IL_001f: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0142: Expected I4, but got O
		global::System.Collections.Generic.List<object>.Enumerator enumerator = default(global::System.Collections.Generic.List<object>.Enumerator);
		bool flag = sponges == null;
		int num = 0;
		nint num4 = default(nint);
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			object obj = (nint)0 + (nint)3272;
			global::System.Collections.Generic.List<Sponge>.Enumerator enumerator2 = sponges.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = spongeMidpoints;
			object obj3 = default(object);
			object obj2 = obj3;
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = float6;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X23_v4 (Il2CppMethodInfo)+CD0]");
				num4 = 0;
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+88]");
				float5 = GetAveragePositionFromIDs((global::System.Collections.Generic.HashSet<int>)0);
				float y = float5.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C70]");
				obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (System.Int32)+6C]");
				nativeParallelHashMap[0] = float5;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag2 = num4 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			object obj = default(object);
			num4 = (nint)obj;
			enumerator.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			num = (int)obj4;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0FAC");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600029E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1000300", Offset = "0x1000300", Length = "0x164")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x680;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x688;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0x690;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0x9F8;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv108 = Il2CppMethodInfo;\n\tv109 = v108 + 0xC70;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA21]) = v46;\nL_0023:\n\tv48 = 0;\n\tv51 = this.clumps == 0;\n\tif (v51) goto L_0055;\n\tv59 = Il2CppMethodInfo;\n\tv66 = System.Collections.Generic.List`1<Clump>::GetEnumerator(this.clumps);\n\tv73 = this + 0x398;\nL_0037:\n\t;\n\tv96 = System.Collections.Generic.List`1<Clump>+Enumerator<Clump>::MoveNext(&v48 @ stack_-60_v1 (System.Collections.Generic.List`1<Clump>+Enumerator<Clump>));\n\tv93 = v96 == 0;\n\tif (v93) goto L_004A;\n\tv85 = FluidSolver::GetAveragePositionFromIDs(this, v127);\n\tv80 = *([v59 @ X24_v3 (Il2CppMethodInfo)+C70]);\n\tUnity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::set_Item(v73, 0, v85);\n\tgoto L_0037;\nL_004A:\n\tSystem.Collections.Generic.List`1<Clump>+Enumerator<Clump>::Dispose(&v48 @ stack_-60_v1 (System.Collections.Generic.List`1<Clump>+Enumerator<Clump>));\nL_0054:\n\treturn;\nL_0055:\n\tv67 = new System.NullReferenceException();\n\tgoto L_0062;\n\tgoto L_0062;\nL_0062:\n\tv107 = v116 != 1;\n\tif (v107) goto L_0072;\n\tv112 = 0x274A080(v67, v116, v80, v30, v31, v32, v33, v34, 0, v36, v37, v38, v39, v40, v41, v42);\n\tv132 = 0x274A098(v112, v116, v80, v30, v31, v32, v33, v34, 0, v36, v37, v38, v39, v40, v41, v42);\n\tSystem.Collections.Generic.List`1<Clump>+Enumerator<Clump>::Dispose(v159);\n\tv121 = *([v112 @ X0_v11]) == 0;\n\tif (v121) goto L_0054;\n\tv119 = new System.OutOfMemoryException();\nL_0072:\n\tv125 = 0xBF0FEC(&v115 @ stack_-70, *([v5 @ X22]), v80, v30, v31, v32, v33, v34, 0, v36, v37, v38, v39, v40, v41, v42);\n\tv134 = 0x27498DC(v122, *([v5 @ X22]), v80, v30, v31, v32, v33, v34, 0, v36, v37, v38, v39, v40, v41, v42);\n\tv179 = 0xD6F8(v134, *([v5 @ X22]), v80, v30, v31, v32, v33, v34, 0, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 70 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateClumpMidpoints()
	{
		//IL_0029: Expected O, but got I
		//IL_004c: Expected O, but got I
		global::System.Collections.Generic.List<Clump>.Enumerator enumerator = default(global::System.Collections.Generic.List<Clump>.Enumerator);
		if (clumps != null)
		{
			nint num = 0;
			global::System.Collections.Generic.List<Clump>.Enumerator enumerator2 = clumps.GetEnumerator();
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = clumpMidpoints;
			global::System.Collections.Generic.HashSet<int> ids = default(global::System.Collections.Generic.HashSet<int>);
			while (enumerator.MoveNext())
			{
				global::Unity.Mathematics.float2 averagePositionFromIDs = GetAveragePositionFromIDs(ids);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v3 (Il2CppMethodInfo)+C70]");
				object obj = 0;
				nativeParallelHashMap[0] = averagePositionFromIDs;
			}
			enumerator.Dispose();
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		global::System.IntPtr intPtr = default(global::System.IntPtr);
		bool flag = intPtr != (global::System.IntPtr)1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			global::System.Collections.Generic.List<Clump>.Enumerator enumerator3 = default(global::System.Collections.Generic.List<Clump>.Enumerator);
			enumerator3.Dispose();
			object obj2 = default(object);
			if (obj2 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			object obj3 = obj2;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0FEC");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600029F")]
	[global::Cpp2ILInjected.Address(RVA = "0x1005A58", Offset = "0x1005A58", Length = "0x6C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0019;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x378;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, id, pu, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA22]) = v43;\nL_0019:\n\t;\n\treturnVal1 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, id, pu);\n\treturn returnVal1;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public bool TryGetPowerUp(int id, out PowerUp pu)
	{
		pu = null;
		return powerUpById.TryGetValue(id, out pu);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
	[global::Cpp2ILInjected.Address(RVA = "0x1004FA0", Offset = "0x1004FA0", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xCA0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, a, b, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA36]) = v43;\nL_001A:\n\tv48 = a == b;\n\tif (v48) goto L_004A;\n\tv53 = a + 1;\n\tv55 = v53 == 0;\n\tif (v55) goto L_004A;\n\tv67 = b + 1;\n\tv63 = v67 == 0;\n\tif (v63) goto L_004A;\n\tv103 = this + 0x3F0;\n\tv105 = b | a;\n\tv109 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::TryAdd(v103, v105, 1);\n\tv81 = a | b;\n\tv87 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::TryAdd(v103, v81, 1);\n\treturn;\nL_004A:\n\treturn;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void AddIgnorePair(int a, int b)
	{
		//IL_0068: Expected O, but got I
		//IL_0075: Expected I8, but got I4
		//IL_0098: Expected I8, but got I4
		if (a != b && a + 1 != 0 && b + 1 != 0)
		{
			global::Unity.Collections.NativeHashMap<ulong, byte> nativeParallelHashMap = ignorePairs;
			ulong key = (ulong)(b | a);
			bool flag = nativeParallelHashMap.TryAdd(key, 1);
			ulong key2 = (ulong)(a | b);
			bool flag2 = nativeParallelHashMap.TryAdd(key2, 1);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
	[global::Cpp2ILInjected.Address(RVA = "0x10050A4", Offset = "0x10050A4", Length = "0x208")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv28 = Il2CppMethodInfo;\n\tv30 = Il2CppMethodInfo;\n\tv32 = Il2CppMethodInfo;\n\tgoto L_0031;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0xE48;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0xE50;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0xE58;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv86 = Il2CppMethodInfo;\n\tv87 = v86 + 0xB10;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv107 = Il2CppMethodInfo;\n\tv108 = v107 + 0xB18;\n\tv109 = \"il2cpp_codegen_initialize_runtime_metadata\"(v108, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv160 = Il2CppMethodInfo;\n\tv161 = v160 + 0xC90;\n\tv162 = \"il2cpp_codegen_initialize_runtime_metadata\"(v161, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv193 = Il2CppMethodInfo;\n\tv194 = v193 + 0xC98;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v194, puId, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53);\n\tv57 = 1;\n\t*([302AA23]) = v57;\nL_0031:\n\t;\n\tv63 = this + 0x3F0;\n\tv66 = Unity.Collections.AllocatorManager+AllocatorHandle::op_Implicit(2);\n\tv147 = *([v28 @ X24_v1 (Il2CppMethodInfo)+C90]);\n\tv73 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::GetKeyArray(v63, v66);\n\tv178 = *([v30 @ X23_v1 (Il2CppMethodInfo)+B18]);\n\tv85 = Unity.Collections.NativeArray`1<System.UInt64>::GetEnumerator(&v73 @ X0_v5 (Unity.Collections.NativeArray`1<System.UInt64>));\n\tv183 = *([v32 @ X22_v1 (Il2CppMethodInfo)+E50]);\n\tv106 = 1 >= v94;\n\tif (v106) goto L_009A;\n\tv110 = Il2CppMethodInfo;\n\tgoto L_006B;\nL_005A:\n\tv183 = *([v32 @ X22_v1 (Il2CppMethodInfo)+E50]);\n\tv182 = v175 + 1;\n\tv121 = v182 >= v94;\n\tif (v121) goto L_009A;\nL_006B:\n\tthis = *([v183 @ X8_v8+20]);\n\tv185 = *([v183 @ X8_v8+20]) + 0x135;\n\tv187 = *([v185 @ X8_v9]) & 1;\n\tv188 = v187 == 0;\n\tv151 = ~v188;\n\tif (v151) goto L_0073;\n\tthis = 0xF7055C(this, v178, v147, v41, v42, v43, v44, v45, 0, v47, v48, v49, v50, v51, v52, v53);\nL_0073:\n\tv178 = *([v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>)+v182 @ X24_v6*8]);\n\tv197 = *([v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>)+v182 @ X24_v6*8]) >> 0x20;\n\tv200 = *([v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>)+v182 @ X24_v6*8]) - puId;\n\tv202 = v200 == 0;\n\tv207 = ~v202;\n\tv114 = ~v207;\n\tif (v114) goto L_FFFFFFFF;\n\tv220 = v197 - puId;\n\tv235 = v220 == 0;\n\tgoto L_0091;\nL_0091:\n\tv239 = ~v235;\n\tif (v239) goto L_005A;\n\tv147 = *([v110 @ X23_v6 (Il2CppMethodInfo)+C98]);\n\tv242 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::Remove(v63, v178);\n\tgoto L_005A;\nL_009A:\n\tUnity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>::Dispose(&v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>));\nL_009B:\n\t;\n\tUnity.Collections.NativeArray`1<System.UInt64>::Dispose(&v73 @ X0_v5 (Unity.Collections.NativeArray`1<System.UInt64>));\n\treturn;\n\tgoto L_00AD;\nL_00AD:\n\tX19 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_00C6;\n\tX0 = X19;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = *([X0]);\n\tstack[0] = X19;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = stack[8];\n\tX1 = *([X21]);\n\tUnity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>::Dispose(X0, X1);\n\tif (TEMP) goto L_009B;\n\tX0 = X19;\n\tX0 = OutOfMemoryException /* throw helper */(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\nL_00C6:\n\tX0 = &stack[0];\n\tX0 = 0xBF102C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = X19;\n\tX0 = 0x27498DC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 0xD6F8(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn;\n// 105 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void RemoveAllPairsWith(int puId)
	{
		//IL_01fe: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_023d: Expected I8, but got I
		//IL_0027: Expected O, but got I
		//IL_0056: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_00ba: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected I4, but got Unknown
		//IL_0125: Expected I8, but got I
		//IL_013b: Expected I8, but got I
		//IL_0150: Expected I8, but got I
		//IL_0074: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_01c2: Expected O, but got I
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		global::Unity.Collections.NativeHashMap<ulong, byte> nativeParallelHashMap = ignorePairs;
		global::Unity.Collections.AllocatorManager.AllocatorHandle allocator = global::Unity.Collections.Allocator.Temp;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X24_v1 (Il2CppMethodInfo)+C90]");
		object obj = 0;
		global::Unity.Collections.NativeArray<ulong> keyArray = nativeParallelHashMap.GetKeyArray(allocator);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X23_v1 (Il2CppMethodInfo)+B18]");
		ulong num4 = 0uL;
		global::Unity.Collections.NativeArray<ulong>.Enumerator enumerator = keyArray.GetEnumerator();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X22_v1 (Il2CppMethodInfo)+E50]");
		object obj2 = 0;
		object obj3 = default(object);
		if (1 < (nint)obj3)
		{
			nint num5 = 0;
			object obj4 = 1;
			object obj5 = 1;
			bool flag3;
			do
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v8+20]");
				FluidSolver fluidSolver = (FluidSolver)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v8+20]");
				object obj6 = (nint)0 + (nint)309;
				if ((obj6 & 1) == 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7055C");
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>)+v182 @ X24_v6*8]");
				num4 = 0uL;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>)+v182 @ X24_v6*8]");
				long num6 = (nint)0 >> 32;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ stack_-80_v3 (Unity.Collections.NativeArray`1<System.UInt64>+Enumerator<System.UInt64>)+v182 @ X24_v6*8]");
				long num7 = -puId;
				bool flag;
				if (num7 != 0)
				{
					long num8 = num6 - puId;
					flag = num8 == 0;
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X23_v6 (Il2CppMethodInfo)+C98]");
					obj = 0;
					bool flag2 = nativeParallelHashMap.Remove(num4);
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X22_v1 (Il2CppMethodInfo)+E50]");
				obj2 = 0;
				obj5 = (nint)obj4 + 1;
				flag3 = global::System.Runtime.CompilerServices.Unsafe.As<object, global::System.UIntPtr>(ref obj5) >= global::System.Runtime.CompilerServices.Unsafe.As<object, global::System.UIntPtr>(ref obj3);
				obj4 = obj5;
			}
			while (!flag3);
		}
		global::Unity.Collections.NativeArray<ulong>.Enumerator enumerator2 = default(global::Unity.Collections.NativeArray<ulong>.Enumerator);
		enumerator2.Dispose();
		keyArray.Dispose();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x1005AC4", Offset = "0x1005AC4", Length = "0x29C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002F;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0xCF8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv48 = Il2CppMethodInfo;\n\tv49 = v48 + 0x588;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v49, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x378;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv123 = Il2CppMethodInfo;\n\tv124 = v123 + 0x590;\n\tv125 = \"il2cpp_codegen_initialize_runtime_metadata\"(v124, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv127 = Il2CppMethodInfo;\n\tv128 = v127 + 0x980;\n\tv129 = \"il2cpp_codegen_initialize_runtime_metadata\"(v128, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv178 = Il2CppMethodInfo;\n\tv179 = v178 + 0x878;\n\tv180 = \"il2cpp_codegen_initialize_runtime_metadata\"(v179, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv181 = Il2CppMethodInfo;\n\tv182 = v181 + 0xC70;\n\tv183 = \"il2cpp_codegen_initialize_runtime_metadata\"(v182, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv184 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv185 = v184 + 0xA38;\n\tv186 = \"il2cpp_codegen_initialize_runtime_metadata\"(v185, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv188 = \"__sort-indicator\";\n\tv189 = v188 + 0xC30;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v189, puId, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302AA37]) = v43;\nL_002F:\n\tv46 = this + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v46);\n\tv62 = System.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::TryGetValue(this.powerUpById, puId, &v60 @ stack_-38_v3 (System.Object));\n\tv126 = ~v62;\n\tif (v126) goto L_00A0;\n\tPowerUp::Activate(v60);\n\tv140 = System.Collections.Generic.HashSet`1<System.Int32>::Add(this.exploding, puId);\n\tv143 = ~v140;\n\tif (v143) goto L_00A0;\n\tgoto L_0054;\n\tv196 = \"il2cpp_codegen_runtime_class_init\"(v192, v135, v81, v58, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0054:\n\tv198 = Il2CppMethodInfo;\n\tv201 = Singleton`1::get_Instance /* +1 sharing this address */(*([v198 @ X8_v12 (Il2CppMethodInfo)+C70]));\n\tv202 = CollectParticleData[];\n\tv93 = new *([v202 @ X8_v14 (Il2CppClass<CollectParticleData[]>)+CF8])();\n\tAudioClipSettings::.ctor(v93);\n\tv93.pitchVariance = 3.051758515084657E-05d;\n\tv204 = \"__sort-indicator\";\n\tAudioManager::PlayClip(v201, *([v204 @ X8_v17 (System.String)+C30]), v93);\n\tv206 = Il2CppMethodInfo;\n\tv207 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::TryGetValue(this.merging, puId, &v64 @ stack_-40_v4 (FluidSolver+PowerUpMergeData));\n\tv208 = ~v207;\n\tif (v208) goto L_008D;\n\tv217 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::Remove(this.merging, puId);\n\tv221 = System.Collections.Generic.Dictionary`2<System.Int32, FluidSolver+PowerUpMergeData>::Remove(this.merging, v64);\n\tFluidSolver::RemoveAllPairsWith(this, v64);\nL_008D:\n\tFluidSolver::RemoveAllPairsWith(this, puId);\n\tSystem.Collections.Generic.Queue`1<System.Int32>::Enqueue(this.explosionQueue, puId);\n\tv142 = ~this.isProcessing;\n\tif (v142) goto L_00A3;\nL_00A0:\n\treturn;\nL_00A3:\n\tv224 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_00AF;\n\tv228 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv229 = v228 + 0xBC8;\n\tv230 = \"il2cpp_codegen_initialize_runtime_metadata\"(v229, v134, v137, v89, v28, v29, v30, v31, v66, v33, v34, v35, v36, v37, v38, v39);\n\tv232 = 1;\n\t*([302AA38]) = v232;\nL_00AF:\n\tv98 = new *([v224 @ X21_v7 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BC8])();\n\tFluidSolver+<ProcessExplosionQueue>d__182::.ctor(v98, 0);\n\tv235 = v98 + 0x20;\n\tv98.<>4__this = this;\n\tv237 = 0xF3F1B4(v235, this, 0, *([v206 @ X8_v19 (Il2CppMethodInfo)+590]), v28, v29, v30, v31, 3.051758515084657E-05d, v33, v34, v35, v36, v37, v38, v39);\n\tv167 = UnityEngine.MonoBehaviour::StartCoroutine(this, v98);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 124 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RadialDestroy(int puId)
	{
		//IL_01f4: Expected O, but got I
		//IL_0094: Expected I, but got O
		//IL_00eb: Expected O, but got I
		//IL_01ac: Expected I, but got O
		//IL_0150: Expected I4, but got O
		//IL_015e: Expected I4, but got O
		//IL_01c0: Expected O, but got I
		_lastJob.Complete();
		PowerUp value;
		if (!powerUpById.TryGetValue(puId, out value))
		{
			return;
		}
		value.Activate();
		if (exploding.Add(puId))
		{
			nint num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			nint num2 = (nint)typeof(CollectParticleData[]);
			AudioClipSettings audioClipSettings = new AudioClipSettings();
			audioClipSettings.pitchVariance = 0.1f;
			audioClipSettings.volume = 0.5f;
			string text = "__sort-indicator";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v17 (System.String)+C30]");
			AudioManager audioManager = default(AudioManager);
			audioManager.PlayClip((string)0, audioClipSettings);
			nint num3 = 0;
			if (merging.TryGetValue(puId, out var value2))
			{
				bool flag = merging.Remove(puId);
				bool flag2 = merging.Remove((int)value2);
				RemoveAllPairsWith((int)value2);
			}
			RemoveAllPairsWith(puId);
			explosionQueue.Enqueue(puId);
			if (!isProcessing)
			{
				FluidSolver._003CProcessExplosionQueue_003Ed__182 _003CProcessExplosionQueue_003Ed__183 = new FluidSolver._003CProcessExplosionQueue_003Ed__182(0);
				_003CProcessExplosionQueue_003Ed__183._003C_003E4__this = this;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				global::UnityEngine.Coroutine coroutine = StartCoroutine(_003CProcessExplosionQueue_003Ed__183);
			}
		}
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FluidSolver._003CProcessExplosionQueue_003Ed__182))]
	[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x1005D60", Offset = "0x1005D60", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xBC8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA38]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BC8])();\n\tFluidSolver+<ProcessExplosionQueue>d__182::.ctor(v45, 0);\n\tv51 = v45 + 0x20;\n\tv45.<>4__this = this;\n\tv53 = 0xF3F1B4(v51, this, 0, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator ProcessExplosionQueue()
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		FluidSolver._003CProcessExplosionQueue_003Ed__182 _003CProcessExplosionQueue_003Ed__183 = new FluidSolver._003CProcessExplosionQueue_003Ed__182(0);
		_003CProcessExplosionQueue_003Ed__183._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return _003CProcessExplosionQueue_003Ed__183;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FluidSolver._003CRadialDestroyRoutine_003Ed__183))]
	[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x1005DE0", Offset = "0x1005DE0", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0018;\n\tv25 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv26 = v25 + 0xBD0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, rootId, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AA24]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BD0])();\n\tFluidSolver+<RadialDestroyRoutine>d__183::.ctor(v46, 0);\n\tv52 = v46 + 0x20;\n\tv46.<>4__this = this;\n\tv54 = 0xF3F1B4(v52, this, 0, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv46.rootId = rootId;\n\treturn v46;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 32 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator RadialDestroyRoutine(int rootId)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		FluidSolver._003CRadialDestroyRoutine_003Ed__183 _003CRadialDestroyRoutine_003Ed__184 = new FluidSolver._003CRadialDestroyRoutine_003Ed__183(0);
		_003CRadialDestroyRoutine_003Ed__184._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CRadialDestroyRoutine_003Ed__184.rootId = rootId;
		return _003CRadialDestroyRoutine_003Ed__184;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x1005E68", Offset = "0x1005E68", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xC28;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, pid, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AA25]) = v44;\nL_0018:\n\tv46 = this + 0x1F8;\n\tv51 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v46, pid, &v49 @ stack_-34_v2, *([v20 @ X21_v1 (Il2CppMethodInfo)+C28]));\n\tv52 = v51 == 0;\n\tif (v52) goto L_002C;\n\tv55 = v49 << 4;\n\tv56 = this.emissionColors + v55;\n\t*([v56 @ X8_v5]) = 0;\n\t*([v56 @ X8_v5+8]) = 0;\nL_002C:\n\treturn;\n// 29 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void ClearHighlight(int pid)
	{
		//IL_0049: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0032: Expected O, but got I4
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = default(object);
			int num2 = (int)((nint)obj3 << 4);
			object obj4 = emissionColors + num2;
			obj4 = 0;
			_ = 0;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x1002930", Offset = "0x1002930", Length = "0x340")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = Il2CppMethodInfo;\n\tv38 = Il2CppMethodInfo;\n\tgoto L_0043;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x6F0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv72 = Il2CppMethodInfo;\n\tv73 = v72 + 0x968;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv82 = Il2CppMethodInfo;\n\tv83 = v82 + 0x970;\n\tv84 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv86 = Il2CppMethodInfo;\n\tv87 = v86 + 0x978;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv128 = Il2CppMethodInfo;\n\tv129 = v128 + 0x578;\n\tv130 = \"il2cpp_codegen_initialize_runtime_metadata\"(v129, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv213 = Il2CppMethodInfo;\n\tv214 = v213 + 0x580;\n\tv215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v214, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv283 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv284 = v283 + 0x1D8;\n\tv285 = \"il2cpp_codegen_initialize_runtime_metadata\"(v284, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv287 = Il2CppMethodInfo;\n\tv288 = v287 + 0x998;\n\tv289 = \"il2cpp_codegen_initialize_runtime_metadata\"(v288, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv333 = Il2CppMethodInfo;\n\tv334 = v333 + 0x968;\n\tv335 = \"il2cpp_codegen_initialize_runtime_metadata\"(v334, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv353 = Il2CppMethodInfo;\n\tv354 = v353 + 0x9B0;\n\tv355 = \"il2cpp_codegen_initialize_runtime_metadata\"(v354, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv361 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv362 = v361 + 0x5D8;\n\tv363 = \"il2cpp_codegen_initialize_runtime_metadata\"(v362, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv376 = Il2CppMethodInfo;\n\tv377 = v376 + 0xC28;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v377, ids, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv63 = 1;\n\t*([302AA26]) = v63;\nL_0043:\n\tv65 = 0;\n\tthis = System.Linq.Enumerable::First /* +1 sharing this address */(v263, *([v36 @ X21_v1 (Il2CppMethodInfo)+6F0]));\n\tv76 = this + 0x1F8;\n\tthis = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v76, this, &v79 @ stack_-74_v2, *([v38 @ X23_v1 (Il2CppMethodInfo)+C28]));\n\tv85 = this == 0;\n\tif (v85) goto L_0060;\n\tv90 = this.particleTypes;\n\tv97 = *([v90 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v79 @ stack_-74_v2*4]) == this.snowFluidType;\n\tif (v97) goto L_00E4;\nL_0060:\n\tv121 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv123 = Il2CppMethodInfo;\n\tthis = *([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]);\n\tv127 = new *([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8])();\n\tSystem.Func`2<System.Int32, System.Boolean>::.ctor(v127, *([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]), *([v123 @ X25_v3 (Il2CppMethodInfo)+578]));\n\tv282 = FluidSolver::CollectNearbyParticles(*([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]), v263, this.splashDestroyRadius, v127);\n\tv286 = v282 == 0;\n\tif (v286) goto L_00E5;\n\tv291 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv295 = Il2CppMethodInfo;\n\tv308 = v282._count < 1;\n\tif (v308) goto L_0092;\n\tv342 = FluidSolver::HandleRemove(*([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]), v282, 0, 1, 0.2f);\n\tv350 = UnityEngine.MonoBehaviour::StartCoroutine(*([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]), v342);\nL_0092:\n\tthis = *([v291 @ X27_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8]);\n\tv352 = new *([v291 @ X27_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v352);\n\tthis = *([v291 @ X27_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8]);\n\tv365 = new *([v291 @ X27_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v365);\n\tthis = *([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]);\n\tv385 = new *([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8])();\n\tSystem.Func`2<System.Int32, System.Boolean>::.ctor(v385, *([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]), *([v295 @ X25_v7 (Il2CppMethodInfo)+580]));\n\tv327 = FluidSolver::CollectNearbyParticles(*([v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]), v263, this.splashDestroyRadius, v385);\n\tv329 = v327 == 0;\n\tif (v329) goto L_00E5;\n\tv409 = Il2CppMethodInfo;\n\tv410 = Il2CppMethodInfo;\n\tv413 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v327);\nL_00BB:\n\tthis = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v65 @ stack_-A0_v1, *([v409 @ X20_v9 (Il2CppMethodInfo)+970]));\n\tv433 = this & 1;\n\tv403 = v433 == 0;\n\tif (v403) goto L_00D1;\n\tthis = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v76, 0, &v415 @ stack_-A4_v5 (System.Int32), *([v38 @ X23_v1 (Il2CppMethodInfo)+C28]));\n\tv435 = this & 1;\n\tv428 = v435 == 0;\n\tif (v428) goto L_00BB;\n\tv429 = this.beeIds;\n\tFluidSolver::OnHitBeeParticle(this, v415, *([v429 @ X8_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v415 @ stack_-A4_v5 (System.Int32)*4]), &v143 @ stack_-88 (System.Collections.Generic.HashSet`1<System.Int32>), &v352 @ X0_v29 (System.Collections.Generic.HashSet`1<System.Int32>));\n\tgoto L_00BB;\nL_00D1:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v65 @ stack_-A0_v1, *([v410 @ X22_v10 (Il2CppMethodInfo)+968]));\nL_00D4:\n\tFluidSolver::RemoveHoneyCoating(this, v143);\nL_00E4:\n\treturn;\nL_00E5:\n\tv332 = new System.NullReferenceException();\n\tgoto L_00F2;\n\tgoto L_00F2;\nL_00F2:\n\tv229 = v263 != 1;\n\tif (v229) goto L_0102;\n\tthis = 0x274A080(v332, v263, v180, v261, v48, v49, v50, v51, v235, v53, v54, v55, v56, v57, v58, v59);\n\tthis = 0x274A098(this, v263, v180, v261, v48, v49, v50, v51, v235, v53, v54, v55, v56, v57, v58, v59);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v137, *([v273 @ X22_v5 (System.Func`2<System.Int32, System.Boolean>)]));\n\tv372 = *([this @ X0 (FluidSolver)]) == 0;\n\tif (v372) goto L_00D4;\n\tv371 = new System.OutOfMemoryException();\nL_0102:\n\tthis = 0xBF092C(&v140 @ stack_-B8, *([v273 @ X22_v5 (System.Func`2<System.Int32, System.Boolean>)]), v180, v261, v48, v49, v50, v51, v235, v53, v54, v55, v56, v57, v58, v59);\n\tthis = 0x27498DC(v276, *([v273 @ X22_v5 (System.Func`2<System.Int32, System.Boolean>)]), v180, v261, v48, v49, v50, v51, v235, v53, v54, v55, v56, v57, v58, v59);\n\tthis = 0xD6F8(this, *([v273 @ X22_v5 (System.Func`2<System.Int32, System.Boolean>)]), v180, v261, v48, v49, v50, v51, v235, v53, v54, v55, v56, v57, v58, v59);\n\treturn;\n// 155 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void HandleSplashDestroy(global::System.Collections.Generic.HashSet<int> ids)
	{
		//IL_03a6: Expected O, but got I4
		//IL_03bc: Expected O, but got I
		//IL_004f: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_00fd: Expected I, but got O
		//IL_0178: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d3: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_0232: Expected O, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_02ea: Expected O, but got I
		nint num = 0;
		nint num2 = 0;
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @112F158 (System.Linq.Enumerable::First, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
		if ((object)this != null)
		{
			global::Unity.Collections.NativeArray<int> nativeArray = particleTypes;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v79 @ stack_-74_v2*4]");
			if ((nint)0 == snowFluidType)
			{
				return;
			}
		}
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
		FluidSolver fluidSolver = (FluidSolver)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X25_v3 (Il2CppMethodInfo)+578]");
		global::System.Func<int, bool> func = new global::System.Func<int, bool>(num5, (global::System.IntPtr)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
		global::System.Collections.Generic.HashSet<int> hashSet2 = default(global::System.Collections.Generic.HashSet<int>);
		global::System.Collections.Generic.HashSet<int> hashSet = ((FluidSolver)0).CollectNearbyParticles(hashSet2, splashDestroyRadius, func);
		bool flag = hashSet == null;
		float num6 = splashDestroyRadius;
		global::System.Func<int, bool> func2 = func;
		object obj3 = 0;
		global::System.Func<int, bool> func3 = func;
		global::System.Collections.Generic.HashSet<int> dehoneyedParticleIds = default(global::System.Collections.Generic.HashSet<int>);
		if (!flag)
		{
			nint num8 = 0;
			if (hashSet.Count >= 1)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
				global::System.Collections.IEnumerator routine = ((FluidSolver)0).HandleRemove(hashSet);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
				global::UnityEngine.Coroutine coroutine = ((global::UnityEngine.MonoBehaviour)0).StartCoroutine(routine);
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X27_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8]");
			fluidSolver = (FluidSolver)0;
			global::System.Collections.Generic.HashSet<int> dehoneyedBeeIds = new global::System.Collections.Generic.HashSet<int>();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X27_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8]");
			fluidSolver = (FluidSolver)0;
			global::System.Collections.Generic.HashSet<int> hashSet3 = new global::System.Collections.Generic.HashSet<int>();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
			fluidSolver = (FluidSolver)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
			nint num9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X25_v7 (Il2CppMethodInfo)+580]");
			global::System.Func<int, bool> func4 = new global::System.Func<int, bool>(num9, (global::System.IntPtr)0);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X24_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1D8]");
			global::System.Collections.Generic.HashSet<int> hashSet4 = ((FluidSolver)0).CollectNearbyParticles(hashSet2, splashDestroyRadius, func4);
			bool flag2 = hashSet4 == null;
			dehoneyedParticleIds = hashSet3;
			num6 = splashDestroyRadius;
			func2 = func4;
			obj3 = 0;
			func3 = func4;
			if (!flag2)
			{
				nint num10 = 0;
				nint num11 = 0;
				global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet4.GetEnumerator();
				dehoneyedParticleIds = hashSet3;
				func2 = func4;
				int num13 = default(int);
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					if ((int)((nint)this & 1) == 0)
					{
						break;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num12 = (int)((nint)this & 1);
					bool flag3 = num12 == 0;
					func2 = (global::System.Func<int, bool>)num13;
					if (!flag3)
					{
						global::Unity.Collections.NativeArray<int> nativeArray2 = beeIds;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v415 @ stack_-A4_v5 (System.Int32)*4]");
						OnHitBeeParticle(num13, 0, ref dehoneyedParticleIds, ref dehoneyedBeeIds);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v415 @ stack_-A4_v5 (System.Int32)*4]");
						func2 = (global::System.Func<int, bool>)0;
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				goto IL_02fe;
			}
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag4 = (nint)hashSet2 != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag4)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			if ((object)this == null)
			{
				goto IL_02fe;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
		return;
		IL_02fe:
		RemoveHoneyCoating(dehoneyedParticleIds);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
	[global::Cpp2ILInjected.Address(RVA = "0x1005EEC", Offset = "0x1005EEC", Length = "0xA30")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = &v33 @ stack_-10_v2;\n\tv44 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = Il2CppMethodInfo;\n\tgoto L_005B;\n\tv51 = Il2CppMethodInfo;\n\tv52 = v51 + 0x2C0;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv83 = Il2CppMethodInfo;\n\tv84 = v83 + 0x2B8;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv89 = Il2CppMethodInfo;\n\tv90 = v89 + 0x2C8;\n\tv91 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv107 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv108 = v107 + 0x810;\n\tv109 = \"il2cpp_codegen_initialize_runtime_metadata\"(v108, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv184 = Il2CppMethodInfo;\n\tv185 = v184 + 0x980;\n\tv186 = \"il2cpp_codegen_initialize_runtime_metadata\"(v185, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv266 = Il2CppMethodInfo;\n\tv267 = v266 + 0x968;\n\tv268 = \"il2cpp_codegen_initialize_runtime_metadata\"(v267, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv394 = Il2CppMethodInfo;\n\tv395 = v394 + 0x970;\n\tv396 = \"il2cpp_codegen_initialize_runtime_metadata\"(v395, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv615 = Il2CppMethodInfo;\n\tv616 = v615 + 0x988;\n\tv617 = \"il2cpp_codegen_initialize_runtime_metadata\"(v616, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv631 = Il2CppMethodInfo;\n\tv632 = v631 + 0x978;\n\tv633 = \"il2cpp_codegen_initialize_runtime_metadata\"(v632, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv707 = Il2CppMethodInfo;\n\tv708 = v707 + 0x990;\n\tv709 = \"il2cpp_codegen_initialize_runtime_metadata\"(v708, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv728 = Il2CppMethodInfo;\n\tv729 = v728 + 0x980;\n\tv730 = \"il2cpp_codegen_initialize_runtime_metadata\"(v729, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv915 = Il2CppMethodInfo;\n\tv916 = v915 + 0x998;\n\tv917 = \"il2cpp_codegen_initialize_runtime_metadata\"(v916, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv939 = Il2CppMethodInfo;\n\tv940 = v939 + 0x968;\n\tv941 = \"il2cpp_codegen_initialize_runtime_metadata\"(v940, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv969 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv970 = v969 + 0x5D8;\n\tv971 = \"il2cpp_codegen_initialize_runtime_metadata\"(v970, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv1035 = Il2CppMethodInfo;\n\tv1036 = v1035 + 0x410;\n\tv1037 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1036, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv1061 = Il2CppMethodInfo;\n\tv1062 = v1061 + 0x438;\n\tv1063 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1062, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv1072 = Il2CppMethodInfo;\n\tv1073 = v1072 + 0x3F8;\n\tv1074 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1073, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv1101 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1102 = v1101 + 0x110;\n\tv1103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1102, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv1127 = Il2CppMethodInfo;\n\tv1128 = v1127 + 0xC28;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1128, sources, includeId, methodInfo, v55, v56, v57, v58, r, v59, v60, v61, v62, v63, v64, v65);\n\tv69 = 1;\n\t*([302AA27]) = v69;\nL_005B:\n\t*([v32 @ X29_v1-80]) = 0;\n\tv81 = 1f / r;\n\tv82 = new *([v44 @ X20_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+810])();\n\tv246 = *([v46 @ X23_v1 (Il2CppMethodInfo)+2B8]);\n\tSystem.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::.ctor(v82, this.<ActiveCount>k__BackingField);\n\tv161 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv106 = this.<ActiveCount>k__BackingField < 1;\n\tif (v106) goto L_0136;\n\tgoto L_009A;\nL_0085:\n\tv1161 = *([v259 @ X8_v121+20]);\n\tv424 = *([v1161 @ X8_v124+C0]);\n\tv246 = *([v424 @ X8_v125+70]);\n\tSystem.Collections.Generic.List`1<System.Int32>::AddWithResize(v248, v214);\nL_008A:\n\tv214 = v214 + 1;\n\tv262 = v262 + 8;\n\tv143 = v214 >= this.<ActiveCount>k__BackingField;\n\tif (v143) goto L_0136;\nL_009A:\n\tv246 = includeId.method;\n\tincludeId.invoke_impl(v290, includeId.method_code, v214, includeId.method, v121, v55, v56, v57, v58, v128, v126, v60, v61, v62, v63, v64, v65);\n\tv291 = v290 & 1;\n\tv292 = v291 == 0;\n\tif (v292) goto L_008A;\n\tv398 = this.positions + v262;\n\tv401 = *([2DD4414]) == 0;\n\tif (v401) goto L_00B6;\n\tv634 = v81 * *([v398 @ X8_v110]);\n\tv619 = *([v161 @ X25_v16]);\n\tv621 = *([v619 @ X0_v130+E0]) == 0;\n\tif (v621) goto L_00BF;\nL_00AC:\n\tv642 = UnityEngine.Mathf::Floor(v634);\n\tgoto L_00C9;\n\tgoto L_FFFFFFFF;\nL_00B6:\n\t*([2DD4414]) = 1;\n\tv634 = v81 * *([v398 @ X8_v110]);\n\tv637 = *([v161 @ X25_v16]);\n\tv649 = *([v637 @ X0_v127+E0]) == 0;\n\tv639 = ~v649;\n\tif (v639) goto L_00AC;\nL_00BF:\n\tv210 = UnityEngine.Mathf::Floor(v643);\n\tv745 = *([2DD4414]) == 0;\n\tif (v745) goto L_012F;\n\tgoto L_00C9;\nL_00C9:\n\tv744 = v81 * *([v398 @ X8_v110+4]);\n\tv126 = UnityEngine.Mathf::Floor(v744);\n\tv260 = v744 << 0x20;\n\tv930 = v126 != 0x7F800000;\n\tif (v930) goto L_00E6;\n\tgoto L_00E6;\nL_00E6:\n\tv199 = v210 != 0x7F800000;\n\tif (v199) goto L_FFFFFFFF;\n\tgoto L_00EE;\nL_00EE:\n\tv234 = v260 | v205;\n\tv1075 = Il2CppMethodInfo;\n\tv121 = *([v1075 @ X8_v116 (Il2CppMethodInfo)+2C0]);\n\tv245 = &v33 @ stack_-10_v2 - 0x80;\n\tv1081 = System.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::TryGetValue(v82, v234, v245);\n\tv1105 = v1081 == 0;\n\tv1106 = ~v1105;\n\tif (v1106) goto L_010C;\n\tv1129 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1132 = new *([v1129 @ X8_v126 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+110])();\n\tSystem.Collections.Generic.List`1<System.Int32>::.ctor(v1132);\n\t*([v32 @ X29_v1-80]) = v1132;\n\tv1156 = Il2CppMethodInfo;\n\tv121 = *([v1156 @ X8_v130 (Il2CppMethodInfo)+2C8]);\n\tSystem.Collections.Generic.Dictionary`2<UnityEngine.Vector2Int, System.Object>::set_Item(v82, v234, v1132);\nL_010C:\n\tv248 = *([v32 @ X29_v1-80]);\n\tv1150 = Il2CppMethodInfo;\n\tv259 = *([v1150 @ X8_v119 (Il2CppMethodInfo)+410]);\n\tv1153 = v248._version + 1;\n\tv248._version = v1153;\n\tv206 = v248._items;\n\tv161 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv404 = v248._size;\n\tv1157 = v248._size < v206.Length;\n\tv420 = ~v1157;\n\tif (v420) goto L_0085;\n\tv1160 = v248._size + 1;\n\tv248._size = v1160;\n\tv206[v404 @ X10_v11 (System.Int32)] = v214;\n\tgoto L_008A;\nL_012F:\n\t*([2DD4414]) = 1;\n\tgoto L_00C9;\n\tgoto L_FFFFFFFF;\nL_0136:\n\tv178 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv183 = new *([v178 @ X8_v13 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v183);\n\tv609 = Il2CppMethodInfo;\n\tv610 = Il2CppMethodInfo;\n\tv391 = r * r;\n\tv614 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(sources);\n\tv630 = this + 0x1F8;\nL_0155:\n\tv702 = Il2CppMethodInfo;\n\tv706 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v613 @ stack_-F8_v5 (System.Collections.Generic.List`1<System.Int32>+Enumerator<System.Int32>), *([v702 @ X8_v20 (Il2CppMethodInfo)+970]));\n\tv726 = v706 & 1;\n\tv727 = v726 == 0;\n\tif (v727) go\n// ... truncated")]
	private unsafe global::System.Collections.Generic.HashSet<int> CollectNearbyParticles(global::System.Collections.Generic.HashSet<int> sources, float r, global::System.Func<int, bool> includeId)
	{
		//IL_0016: Expected I, but got O
		//IL_14cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Expected O, but got Unknown
		//IL_04ab: Expected I, but got O
		//IL_04f0: Expected O, but got I
		//IL_1435: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0565: Expected O, but got I4
		//IL_0633: Expected I, but got O
		//IL_0643: Expected O, but got I
		//IL_0289: Expected O, but got F4
		//IL_05b0: Expected I, but got O
		//IL_05c0: Expected O, but got I
		//IL_06ea: Expected O, but got F4
		//IL_02b8: Expected O, but got I8
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0719: Expected O, but got I8
		//IL_03af: Expected O, but got I
		//IL_03ca: Expected O, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_0356: Expected I, but got O
		//IL_0759: Expected O, but got I8
		//IL_076c: Expected O, but got I8
		//IL_0775: Expected O, but got I4
		//IL_0782: Expected O, but got I8
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected O, but got Unknown
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected O, but got Unknown
		//IL_0796: Expected O, but got I
		//IL_136c: Expected F4, but got I
		//IL_1140: Expected O, but got I
		//IL_0a52: Expected O, but got F4
		//IL_0abf: Expected F4, but got I
		//IL_0dca: Expected O, but got F4
		//IL_0e37: Expected F4, but got I
		//IL_13fa: Expected I4, but got O
		//IL_0919: Expected O, but got F4
		//IL_0986: Expected F4, but got I
		//IL_11b5: Expected O, but got F4
		//IL_1222: Expected F4, but got I
		//IL_0c91: Expected O, but got F4
		//IL_0cfe: Expected F4, but got I
		//IL_0b06: Expected I, but got O
		//IL_106c: Expected O, but got F4
		//IL_10d9: Expected F4, but got I
		//IL_0e89: Expected F4, but got I
		//IL_0ea1: Expected O, but got I
		//IL_09af: Expected O, but got I
		//IL_09d8: Expected F4, but got I
		//IL_127c: Expected F4, but got I
		//IL_1294: Expected O, but got I
		//IL_0d27: Expected O, but got I
		//IL_0d50: Expected F4, but got I
		//IL_1102: Expected O, but got I
		//IL_112b: Expected F4, but got I
		object obj2 = default(object);
		object obj = obj2;
		nint num2 = 0;
		_ = 0;
		float num3 = 1f / r;
		object obj3 = new global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector2Int, object>(ActiveCount);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X23_v1 (Il2CppMethodInfo)+2B8]");
		nint num4 = 0;
		object obj4 = (nint)0 + 2328;
		if (ActiveCount >= 1)
		{
			nint num6 = default(nint);
			nint num5 = num6;
			float num8 = default(float);
			float num7 = num8;
			float num9 = 1f;
			int num10 = 0;
			int num11 = 0;
			object obj5 = default(object);
			float num14 = default(float);
			bool flag4;
			float num22 = default(float);
			do
			{
				num4 = includeId.method;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: includeId.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				if ((int)((nint)obj5 & 1) == 0)
				{
					goto IL_009c;
				}
				object obj6 = positions + num11;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4414]");
				float num12;
				float f;
				if ((nint)0 != 0)
				{
					num12 = num3 * (float)obj6;
					object obj7 = obj4;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v130+E0]");
					bool flag = (nint)0 == 0;
					f = num12;
					if (!flag)
					{
						goto IL_01a4;
					}
				}
				else
				{
					_ = 1;
					num12 = num3 * (float)obj6;
					object obj8 = obj4;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v127+E0]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					f = num12;
					if (flag3)
					{
						goto IL_01a4;
					}
				}
				float num13 = global::UnityEngine.Mathf.Floor(f);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4414]");
				if ((nint)0 != 0)
				{
					num13 = num14;
				}
				else
				{
					_ = 1;
				}
				goto IL_0257;
				IL_0257:
				float num15 = num3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v110+4]");
				float num16 = num15 * 0f;
				num7 = global::UnityEngine.Mathf.Floor(num16);
				object obj9 = num16 << 32;
				if (num7 == float.PositiveInfinity)
				{
					obj9 = long.MinValue;
				}
				float num17 = ((num13 != float.PositiveInfinity) ? num13 : -0f);
				global::UnityEngine.Vector2Int key = (global::UnityEngine.Vector2Int)((nint)obj9 | num17);
				nint num18 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X8_v116 (Il2CppMethodInfo)+2C0]");
				num5 = 0;
				ref object reference = ref *(object*)((nint)obj2 - 128);
				if (!((global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector2Int, object>)obj3).TryGetValue(key, out reference))
				{
					global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
					nint num20 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v130 (Il2CppMethodInfo)+2C8]");
					num5 = 0;
					((global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector2Int, object>)obj3)[key] = list;
					reference = ref *(object*)list;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-80]");
				global::System.Collections.Generic.List<int> list2 = (global::System.Collections.Generic.List<int>)0;
				nint num21 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v119 (Il2CppMethodInfo)+410]");
				object obj10 = 0;
				int version = list2._version + 1;
				list2._version = version;
				int[] items = list2._items;
				obj4 = (nint)0 + 2328;
				int count = list2.Count;
				if (list2.Count >= items.Length)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v121+20]");
					object obj11 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X8_v124+C0]");
					object obj12 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v125+70]");
					num4 = 0;
					list2.Add(num10);
					num9 = float.PositiveInfinity;
				}
				else
				{
					int size = list2.Count + 1;
					list2._size = size;
					items[count] = num10;
					num9 = float.PositiveInfinity;
					num4 = (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				}
				goto IL_009c;
				IL_009c:
				num10++;
				num11 += 8;
				flag4 = num10 >= ActiveCount;
				num6 = num5;
				num8 = num7;
				continue;
				IL_01a4:
				num14 = global::UnityEngine.Mathf.Floor(num12);
				num13 = num22;
				goto IL_0257;
			}
			while (!flag4);
		}
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		nint num24 = 0;
		nint num25 = 0;
		float num26 = r * r;
		global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = sources.GetEnumerator();
		global::System.Collections.Generic.List<int>.Enumerator enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
		global::System.Collections.Generic.List<int>.Enumerator enumerator2 = enumerator3;
		object obj14 = default(object);
		object obj16 = default(object);
		object obj17 = default(object);
		float num38 = default(float);
		object obj21 = default(object);
		object obj22 = default(object);
		nint num39 = default(nint);
		global::System.Collections.Generic.HashSet<int> hashSet2 = default(global::System.Collections.Generic.HashSet<int>);
		float num42 = default(float);
		object obj23 = default(object);
		global::System.Collections.Generic.List<int>.Enumerator enumerator4 = default(global::System.Collections.Generic.List<int>.Enumerator);
		global::UnityEngine.Vector2Int vector2Int = default(global::UnityEngine.Vector2Int);
		global::System.OutOfMemoryException ex4 = default(global::System.OutOfMemoryException);
		global::System.Collections.Generic.List<int>.Enumerator enumerator11 = default(global::System.Collections.Generic.List<int>.Enumerator);
		global::System.NullReferenceException ex5 = default(global::System.NullReferenceException);
		global::System.NullReferenceException ex6 = default(global::System.NullReferenceException);
		global::System.NullReferenceException ex7 = default(global::System.NullReferenceException);
		global::System.Collections.Generic.List<int>.Enumerator enumerator8 = default(global::System.Collections.Generic.List<int>.Enumerator);
		global::System.NullReferenceException ex8 = default(global::System.NullReferenceException);
		global::System.IntPtr intPtr = default(global::System.IntPtr);
		float num71 = default(float);
		global::System.Collections.Generic.List<int>.Enumerator enumerator14 = default(global::System.Collections.Generic.List<int>.Enumerator);
		global::UnityEngine.Vector2Int vector2Int3 = default(global::UnityEngine.Vector2Int);
		object obj30 = default(object);
		while (true)
		{
			IL_1512:
			nint num27 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
			int num28 = (int)((nint)obj14 & 1);
			bool flag5 = num28 == 0;
			object obj15 = enumerator3;
			int num29 = 0;
			global::System.Collections.Generic.HashSet<int> result = hashSet;
			float num33;
			float num37;
			nint num6;
			if (!flag5)
			{
				nint num30 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v22 (Il2CppMethodInfo)+C28]");
				num6 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
				int num31 = (int)((nint)obj16 & 1);
				bool flag6 = num31 == 0;
				num4 = (nint)obj17;
				if (flag6)
				{
					continue;
				}
				global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray = positions;
				object obj18 = 48054272;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4414]");
				float f2;
				if ((nint)0 != 0)
				{
					float num32 = num3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
					num33 = num32 * 0f;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X8_v104 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj19 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X0_v105+E0]");
					bool flag7 = (nint)0 == 0;
					f2 = num33;
					if (!flag7)
					{
						goto IL_05ee;
					}
				}
				else
				{
					_ = 1;
					float num35 = num3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
					num33 = num35 * 0f;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v97 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj20 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X0_v102+E0]");
					bool flag8 = (nint)0 == 0;
					bool flag9 = !flag8;
					f2 = num33;
					if (flag9)
					{
						goto IL_05ee;
					}
				}
				num37 = global::UnityEngine.Mathf.Floor(f2);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4414]");
				if ((nint)0 != 0)
				{
					num37 = num38;
				}
				else
				{
					_ = 1;
				}
				goto IL_06c0;
			}
			goto IL_141f;
			IL_13d6:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			obj15 = obj21;
			num29 = (int)obj22;
			num6 = num39;
			float num40;
			float num8 = num40;
			enumerator2 = enumerator4;
			result = hashSet2;
			goto IL_141f;
			IL_141f:
			nint num41 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v6 (Il2CppMethodInfo)+968]");
			vector2Int = (global::UnityEngine.Vector2Int)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			if (num29 == 0)
			{
				return result;
			}
			global::System.OutOfMemoryException ex = new global::System.OutOfMemoryException();
			global::System.OutOfMemoryException ex2 = ex;
			break;
			IL_05ee:
			num38 = global::UnityEngine.Mathf.Floor(num33);
			num37 = num42;
			goto IL_06c0;
			IL_06c0:
			float num43 = num3 * (float)obj23;
			num40 = global::UnityEngine.Mathf.Floor(num43);
			object obj24 = num43 << 32;
			object obj25 = ((num40 != float.PositiveInfinity) ? obj24 : ((object)long.MinValue));
			float num44 = ((num37 != float.PositiveInfinity) ? num37 : -0f);
			object obj26 = (nint)obj25 + -4294967296L;
			object obj27 = (nint)obj25 + 4294967296L;
			global::System.Collections.Generic.List<int>.Enumerator enumerator5 = (global::System.Collections.Generic.List<int>.Enumerator)2139095040;
			object obj28 = 4294967295L;
			while (true)
			{
				float num45 = (float)obj28 + num44;
				global::UnityEngine.Vector2Int vector2Int2 = (global::UnityEngine.Vector2Int)((nint)obj26 | num45);
				nint num46 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v36 (Il2CppMethodInfo)+2C0]");
				num6 = 0;
				nint num47;
				if (((global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector2Int, object>)obj3).TryGetValue(vector2Int2, out object value))
				{
					bool flag10 = value == null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v36 (Il2CppMethodInfo)+2C0]");
					num47 = 0;
					num4 = (nint)value;
					if (flag10)
					{
						goto IL_1338;
					}
					global::System.Collections.Generic.List<int>.Enumerator enumerator6 = ((global::System.Collections.Generic.List<int>)value).GetEnumerator();
					bool flag11 = hashSet == null;
					num8 = num40;
					enumerator2 = enumerator3;
					object obj29 = value;
					float num48 = num40;
					global::System.Collections.Generic.List<int>.Enumerator enumerator7 = enumerator3;
					if (!flag11)
					{
						while (enumerator3.MoveNext())
						{
							global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray2 = positions;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X9_v36 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v629 @ stack_-E8*8]");
							float num49 = 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
							float num50 = num49 - 0f;
							enumerator2 = (global::System.Collections.Generic.List<int>.Enumerator)(num50 * num50);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							bool flag12 = (float)enumerator2 < num26;
							bool flag13 = !flag12;
							float num51 = (float)enumerator2 - num26;
							bool flag14 = num51 == 0f;
							bool flag15 = !flag14;
							bool flag16 = flag13 && flag15;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
							num8 = 0f;
							if (!flag16)
							{
								global::Unity.Collections.NativeArray<int> nativeArray3 = particleIds;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X28_v8 (Il2CppMethodInfo)+980]");
								obj29 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X9_v37 (Unity.Collections.NativeArray`1<System.Int32>)+v629 @ stack_-E8*4]");
								bool flag17 = hashSet.Add(0);
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								num8 = 0f;
							}
						}
					}
					else
					{
						while (true)
						{
							bool flag18 = enumerator3.MoveNext();
							bool flag19 = !flag18;
							num8 = num48;
							enumerator2 = enumerator7;
							obj29 = value;
							if (flag19)
							{
								break;
							}
							global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray4 = positions;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X9_v34 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v629 @ stack_-E8*8]");
							float num52 = 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
							float num53 = num52 - 0f;
							enumerator8 = (global::System.Collections.Generic.List<int>.Enumerator)(num53 * num53);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							bool flag20 = (float)enumerator8 < num26;
							bool flag21 = !flag20;
							float num54 = (float)enumerator8 - num26;
							bool flag22 = num54 == 0f;
							bool flag23 = !flag22;
							bool flag24 = flag21 && flag23;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
							num48 = 0f;
							enumerator7 = enumerator8;
							if (flag24)
							{
								continue;
							}
							goto IL_0ad5;
						}
					}
					enumerator3.Dispose();
					enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
				}
				else
				{
					vector2Int2 = (global::UnityEngine.Vector2Int)((nint)obj25 | num45);
					nint num55 = 0;
					if (((global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector2Int, object>)obj3).TryGetValue(vector2Int2, out value))
					{
						bool flag25 = value == null;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v41 (Il2CppMethodInfo)+2C0]");
						num47 = 0;
						num4 = (nint)value;
						if (flag25)
						{
							goto IL_1338;
						}
						global::System.Collections.Generic.List<int>.Enumerator enumerator9 = ((global::System.Collections.Generic.List<int>)value).GetEnumerator();
						bool flag26 = hashSet == null;
						num8 = num40;
						enumerator2 = enumerator3;
						object obj29 = value;
						float num56 = num40;
						global::System.Collections.Generic.List<int>.Enumerator enumerator10 = enumerator3;
						if (!flag26)
						{
							while (enumerator3.MoveNext())
							{
								global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray5 = positions;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v30 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v629 @ stack_-E8*8]");
								float num57 = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								float num58 = num57 - 0f;
								enumerator2 = (global::System.Collections.Generic.List<int>.Enumerator)(num58 * num58);
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								bool flag27 = (float)enumerator2 < num26;
								bool flag28 = !flag27;
								float num59 = (float)enumerator2 - num26;
								bool flag29 = num59 == 0f;
								bool flag30 = !flag29;
								bool flag31 = flag28 && flag30;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								num8 = 0f;
								if (!flag31)
								{
									global::Unity.Collections.NativeArray<int> nativeArray6 = particleIds;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X28_v8 (Il2CppMethodInfo)+980]");
									obj29 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ X9_v31 (Unity.Collections.NativeArray`1<System.Int32>)+v629 @ stack_-E8*4]");
									bool flag32 = hashSet.Add(0);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
									num8 = 0f;
								}
							}
						}
						else
						{
							while (true)
							{
								bool flag33 = enumerator3.MoveNext();
								bool flag34 = !flag33;
								num8 = num56;
								enumerator2 = enumerator10;
								obj29 = value;
								if (flag34)
								{
									break;
								}
								global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray7 = positions;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v28 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v629 @ stack_-E8*8]");
								float num60 = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								float num61 = num60 - 0f;
								enumerator11 = (global::System.Collections.Generic.List<int>.Enumerator)(num61 * num61);
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								bool flag35 = (float)enumerator11 < num26;
								bool flag36 = !flag35;
								float num62 = (float)enumerator11 - num26;
								bool flag37 = num62 == 0f;
								bool flag38 = !flag37;
								bool flag39 = flag36 && flag38;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								num56 = 0f;
								enumerator10 = enumerator11;
								if (flag39)
								{
									continue;
								}
								goto IL_0e4d;
							}
						}
						enumerator3.Dispose();
						enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v41 (Il2CppMethodInfo)+2C0]");
						num6 = 0;
					}
					else
					{
						vector2Int2 = (global::UnityEngine.Vector2Int)((nint)obj27 | num45);
						nint num63 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v45 (Il2CppMethodInfo)+2C0]");
						num39 = 0;
						bool flag40 = ((global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector2Int, object>)obj3).TryGetValue(vector2Int2, out value);
						bool flag41 = !flag40;
						num4 = (nint)value;
						if (flag41)
						{
							obj28 = (nint)obj28 + 1;
							bool flag42 = (nint)obj28 == 2;
							num6 = num39;
							num8 = num40;
							enumerator2 = enumerator5;
							if (!flag42)
							{
								continue;
							}
							goto IL_1512;
						}
						bool flag43 = value == null;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v45 (Il2CppMethodInfo)+2C0]");
						num47 = 0;
						num4 = (nint)value;
						if (flag43)
						{
							goto IL_1338;
						}
						global::System.Collections.Generic.List<int>.Enumerator enumerator12 = ((global::System.Collections.Generic.List<int>)value).GetEnumerator();
						bool flag44 = hashSet == null;
						num8 = num40;
						enumerator2 = enumerator3;
						object obj29 = value;
						float num64 = num40;
						global::System.Collections.Generic.List<int>.Enumerator enumerator13 = enumerator3;
						if (!flag44)
						{
							while (enumerator3.MoveNext())
							{
								global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray8 = positions;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1465 @ X9_v23 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v629 @ stack_-E8*8]");
								float num65 = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								float num66 = num65 - 0f;
								enumerator2 = (global::System.Collections.Generic.List<int>.Enumerator)(num66 * num66);
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								bool flag45 = (float)enumerator2 < num26;
								bool flag46 = !flag45;
								float num67 = (float)enumerator2 - num26;
								bool flag47 = num67 == 0f;
								bool flag48 = !flag47;
								bool flag49 = flag46 && flag48;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								num8 = 0f;
								if (!flag49)
								{
									global::Unity.Collections.NativeArray<int> nativeArray9 = particleIds;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X28_v8 (Il2CppMethodInfo)+980]");
									obj29 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X9_v24 (Unity.Collections.NativeArray`1<System.Int32>)+v629 @ stack_-E8*4]");
									bool flag50 = hashSet.Add(0);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
									num8 = 0f;
								}
							}
						}
						else
						{
							while (true)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X25_v10 (Il2CppMethodInfo)+988]");
								vector2Int = (global::UnityEngine.Vector2Int)0;
								bool flag51 = enumerator3.MoveNext();
								bool flag52 = !flag51;
								num8 = num64;
								enumerator2 = enumerator13;
								obj29 = value;
								if (flag52)
								{
									break;
								}
								global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray10 = positions;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X9_v21 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v629 @ stack_-E8*8]");
								float num68 = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								float num69 = num68 - 0f;
								enumerator4 = (global::System.Collections.Generic.List<int>.Enumerator)(num69 * num69);
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								bool flag53 = (float)enumerator4 < num26;
								bool flag54 = !flag53;
								float num70 = (float)enumerator4 - num26;
								bool flag55 = num70 == 0f;
								bool flag56 = !flag55;
								bool flag57 = flag54 && flag56;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
								num64 = 0f;
								enumerator13 = enumerator4;
								if (flag57)
								{
									continue;
								}
								goto IL_1238;
							}
						}
						enumerator3.Dispose();
						enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
						num6 = num39;
					}
				}
				global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
				obj21 = enumerator3;
				num29 = 0;
				num39 = num47;
				enumerator4 = enumerator5;
				vector2Int = vector2Int2;
				ex4 = (global::System.OutOfMemoryException)(object)ex5;
				hashSet2 = hashSet;
				goto IL_1589;
				IL_1589:
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0D6C");
				bool flag58 = (nint)vector2Int != 1;
				num6 = num39;
				num8 = num40;
				enumerator2 = enumerator4;
				ex2 = ex4;
				if (flag58)
				{
					break;
				}
				goto IL_13d6;
				IL_1238:
				ex6 = new global::System.NullReferenceException();
				obj21 = enumerator3;
				num29 = 0;
				enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v41 (Il2CppMethodInfo)+2C0]");
				num39 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
				num40 = 0f;
				enumerator4 = enumerator11;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X25_v10 (Il2CppMethodInfo)+988]");
				vector2Int = (global::UnityEngine.Vector2Int)0;
				num4 = (nint)value;
				ex4 = (global::System.OutOfMemoryException)(object)ex7;
				hashSet2 = hashSet;
				goto IL_1589;
				IL_1338:
				ex5 = new global::System.NullReferenceException();
				obj21 = enumerator3;
				num29 = 0;
				enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
				num40 = 0f;
				num4 = (nint)value;
				ex4 = (global::System.OutOfMemoryException)(object)ex6;
				hashSet2 = hashSet;
				goto IL_1589;
				IL_0e4d:
				ex7 = new global::System.NullReferenceException();
				obj21 = enumerator3;
				num29 = 0;
				enumerator3 = default(global::System.Collections.Generic.List<int>.Enumerator);
				num39 = num6;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v312 @ stack_-B4_v7*8]");
				num40 = 0f;
				enumerator4 = enumerator8;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X25_v10 (Il2CppMethodInfo)+988]");
				vector2Int = (global::UnityEngine.Vector2Int)0;
				num4 = (nint)value;
				ex4 = (global::System.OutOfMemoryException)(object)ex8;
				hashSet2 = hashSet;
				goto IL_1589;
				IL_0ad5:
				ex8 = new global::System.NullReferenceException();
				num39 = intPtr;
				num40 = num71;
				enumerator4 = enumerator14;
				vector2Int = vector2Int3;
				num4 = (nint)obj30;
				goto IL_1589;
			}
			break;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
		global::System.Collections.Generic.HashSet<int> result2 = default(global::System.Collections.Generic.HashSet<int>);
		return result2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
	[global::Cpp2ILInjected.Address(RVA = "0x100691C", Offset = "0x100691C", Length = "0x24C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002D;\n\tv41 = Il2CppMethodInfo;\n\tv42 = v41 + 0x980;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, idx, beeId, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x990;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, idx, beeId, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv184 = Il2CppMethodInfo;\n\tv185 = v184 + 0x7F0;\n\tv186 = \"il2cpp_codegen_initialize_runtime_metadata\"(v185, idx, beeId, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv202 = Il2CppMethodInfo;\n\tv203 = v202 + 0x7F8;\n\tv204 = \"il2cpp_codegen_initialize_runtime_metadata\"(v203, idx, beeId, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv305 = Il2CppMethodInfo;\n\tv306 = v305 + 0xC80;\n\tv307 = \"il2cpp_codegen_initialize_runtime_metadata\"(v306, idx, beeId, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv308 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv309 = v308 + 0xA40;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v309, idx, beeId, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302AA28]) = v58;\nL_002D:\n\tv198 = this.bees;\nL_003D:\n\tv71 = v141 >= v198._size;\n\tif (v71) goto L_00CA;\n\tv146 = System.Collections.Generic.List`1<Bee>::get_Item(v198, v141);\n\tv101 = v146.id == beeId;\n\tif (v101) goto L_0056;\n\tv141 = v141 + 1;\n\tv198 = this.bees;\n\tv311 = this.bees == 0;\n\tv156 = ~v311;\n\tif (v156) goto L_003D;\n\tgoto L_00EF;\nL_0056:\n\tv312 = this.isHoneyCoated;\n\tv313 = *([v312 @ X8_v8 (Unity.Collections.NativeArray`1<System.Boolean>)+idx @ X1 (System.Int32)]) == 0;\n\tif (v313) goto L_00B5;\n\tv182 = v146.solverIds;\n\tv325 = v182.Length < 1;\n\tif (v325) goto L_0093;\n\tgoto L_0084;\nL_0071:\n\tv175 = v175 + 1;\n\tv330 = v175 >= v182.Length;\n\tif (v330) goto L_0093;\nL_0084:\n\tv357 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(*([dehoneyedParticleIds @ X3 (System.Collections.Generic.HashSet`1<System.Int32>&)]), v182[v175 @ X24_v11 (System.Int32)]);\n\tv365 = v357 == 0;\n\tv366 = ~v365;\n\tif (v366) goto L_0071;\n\tv369 = System.Collections.Generic.HashSet`1<System.Int32>::Add(*([dehoneyedParticleIds @ X3 (System.Collections.Generic.HashSet`1<System.Int32>&)]), v182[v175 @ X24_v11 (System.Int32)]);\n\tgoto L_0071;\nL_0093:\n\t;\n\tv221 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(*([dehoneyedBeeIds @ X4 (System.Collections.Generic.HashSet`1<System.Int32>&)]), beeId);\n\tv359 = v221 == 0;\n\tv224 = ~v359;\n\tif (v224) goto L_00CA;\n\tv279 = System.Collections.Generic.HashSet`1<System.Int32>::Add(*([dehoneyedBeeIds @ X4 (System.Collections.Generic.HashSet`1<System.Int32>&)]), beeId);\n\treturn;\nL_00B5:\n\t;\n\tv220 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(*([dehoneyedBeeIds @ X4 (System.Collections.Generic.HashSet`1<System.Int32>&)]), beeId);\n\tv223 = v220 == 0;\n\tif (v223) goto L_00D1;\nL_00CA:\n\treturn;\nL_00D1:\n\tgoto L_00D3;\n\tv360 = \"il2cpp_codegen_runtime_class_init\"(v353, v129, v136, dehoneyedParticleIds, dehoneyedBeeIds, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\nL_00D3:\n\tv362 = Il2CppMethodInfo;\n\tv153 = Singleton`1::get_Instance /* +1 sharing this address */(*([v362 @ X8_v15 (Il2CppMethodInfo)+C80]));\n\t// 220 MakeStruct v244 @ AGG1006B3C_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v146.position (UnityEngine.Vector2), v146.position.y (System.Single)\n\tCollectionManager::OnCollectBee(v153, v244);\n\tFluidSolver::RemoveBee(this, v146);\n\treturn;\nL_00EF:\n\tthrow System.NullReferenceException;\n// 171 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnHitBeeParticle(int idx, int beeId, ref global::System.Collections.Generic.HashSet<int> dehoneyedParticleIds, ref global::System.Collections.Generic.HashSet<int> dehoneyedBeeIds)
	{
		global::System.Collections.Generic.List<Bee> list = bees;
		int num = 0;
		global::UnityEngine.Vector2 pos = default(global::UnityEngine.Vector2);
		CollectionManager collectionManager = default(CollectionManager);
		do
		{
			if (num >= list.Count)
			{
				return;
			}
			Bee bee = list[num];
			if (bee.id != beeId)
			{
				num++;
				list = bees;
				continue;
			}
			global::Unity.Collections.NativeArray<bool> nativeArray = isHoneyCoated;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v8 (Unity.Collections.NativeArray`1<System.Boolean>)+idx @ X1 (System.Int32)]");
			if ((nint)0 != 0)
			{
				int[] solverIds = bee.solverIds;
				if (solverIds.Length >= 1)
				{
					int num2 = 0;
					do
					{
						if (!dehoneyedParticleIds.Contains(solverIds[num2]))
						{
							bool flag = dehoneyedParticleIds.Add(solverIds[num2]);
						}
						num2++;
					}
					while (num2 < solverIds.Length);
				}
				if (!dehoneyedBeeIds.Contains(beeId))
				{
					bool flag2 = dehoneyedBeeIds.Add(beeId);
				}
			}
			else if (!dehoneyedBeeIds.Contains(beeId))
			{
				nint num3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
				pos.x = bee.position.x;
				pos.y = bee.position.y;
				collectionManager.OnCollectBee(pos);
				RemoveBee(bee);
			}
			return;
		}
		while (bees != null);
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x1006B68", Offset = "0x1006B68", Length = "0xC4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv19 = this.rejectFlash == 0;\n\tif (v19) goto L_0012;\n\tUnityEngine.MonoBehaviour::StopCoroutine(this, this.rejectFlash);\nL_0012:\n\tv27 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_001E;\n\tv32 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv33 = v32 + 0xBB8;\n\tv34 = \"il2cpp_codegen_initialize_runtime_metadata\"(v33, v18, v22, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv49 = 1;\n\t*([302AA29]) = v49;\nL_001E:\n\tv52 = new *([v27 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BB8])();\n\tFluidSolver+<HandleRejectFlash>d__190::.ctor(v52, 0);\n\tv57 = this + 0x490;\n\tv59 = v52 + 0x28;\n\tv52.<>4__this = this;\n\tv61 = 0xF3F1B4(v59, this, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv64 = v52 + 0x20;\n\tv52.ids = ids;\n\tv66 = 0xF3F1B4(v64, ids, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tthis.rejectFlash = v52;\n\tv69 = 0xF3F1B4(v57, v52, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv79 = UnityEngine.MonoBehaviour::StartCoroutine(this, this.rejectFlash);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void StartRejectFlash(global::System.Collections.Generic.HashSet<int> ids)
	{
		//IL_003e: Expected I, but got O
		//IL_004f: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0081: Expected O, but got I
		if (rejectFlash != null)
		{
			StopCoroutine(rejectFlash);
		}
		FluidSolver._003CHandleRejectFlash_003Ed__190 _003CHandleRejectFlash_003Ed__191 = new FluidSolver._003CHandleRejectFlash_003Ed__190(0);
		_003CHandleRejectFlash_003Ed__191._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CHandleRejectFlash_003Ed__191.ids = ids;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		rejectFlash = _003CHandleRejectFlash_003Ed__191;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.Coroutine coroutine = StartCoroutine(rejectFlash);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FluidSolver._003CHandleRejectFlash_003Ed__190))]
	[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
	[global::Cpp2ILInjected.Address(RVA = "0x1006C2C", Offset = "0x1006C2C", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0018;\n\tv25 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv26 = v25 + 0xBB8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, ids, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AA29]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+BB8])();\n\tFluidSolver+<HandleRejectFlash>d__190::.ctor(v46, 0);\n\tv52 = v46 + 0x28;\n\tv46.<>4__this = this;\n\tv54 = 0xF3F1B4(v52, this, 0, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv57 = v46 + 0x20;\n\tv46.ids = ids;\n\tv59 = 0xF3F1B4(v57, ids, 0, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\treturn v46;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleRejectFlash(global::System.Collections.Generic.HashSet<int> ids)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0045: Expected O, but got I
		FluidSolver._003CHandleRejectFlash_003Ed__190 _003CHandleRejectFlash_003Ed__191 = new FluidSolver._003CHandleRejectFlash_003Ed__190(0);
		_003CHandleRejectFlash_003Ed__191._003C_003E4__this = this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_003CHandleRejectFlash_003Ed__191.ids = ids;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return _003CHandleRejectFlash_003Ed__191;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
	[global::Cpp2ILInjected.Address(RVA = "0x1006CC0", Offset = "0x1006CC0", Length = "0x520")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv35 = CollectParticleData[];\n\tv37 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv41 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tgoto L_0073;\n\tv48 = Il2CppMethodInfo;\n\tv49 = v48 + 0x368;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v49, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0x570;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv81 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv82 = v81 + 0x480;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv88 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv89 = v88 + 0x500;\n\tv90 = \"il2cpp_codegen_initialize_runtime_metadata\"(v89, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv108 = Il2CppMethodInfo;\n\tv109 = v108 + 0x968;\n\tv110 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv114 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv115 = v114 + 0x5D8;\n\tv116 = \"il2cpp_codegen_initialize_runtime_metadata\"(v115, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv119 = Il2CppMethodInfo;\n\tv120 = v119 + 0x268;\n\tv121 = \"il2cpp_codegen_initialize_runtime_metadata\"(v120, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv124 = Il2CppMethodInfo;\n\tv125 = v124 + 0x928;\n\tv126 = \"il2cpp_codegen_initialize_runtime_metadata\"(v125, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv130 = Il2CppMethodInfo;\n\tv131 = v130 + 0x7D0;\n\tv132 = \"il2cpp_codegen_initialize_runtime_metadata\"(v131, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv135 = Il2CppMethodInfo;\n\tv136 = v135 + 0xF48;\n\tv137 = \"il2cpp_codegen_initialize_runtime_metadata\"(v136, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv140 = Il2CppMethodInfo;\n\tv141 = v140 + 0x948;\n\tv142 = \"il2cpp_codegen_initialize_runtime_metadata\"(v141, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv146 = Il2CppMethodInfo;\n\tv147 = v146 + 0x9E8;\n\tv148 = \"il2cpp_codegen_initialize_runtime_metadata\"(v147, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv153 = Il2CppMethodInfo;\n\tv154 = v153 + 0x108;\n\tv155 = \"il2cpp_codegen_initialize_runtime_metadata\"(v154, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv160 = Il2CppMethodInfo;\n\tv161 = v160 + 0xAB0;\n\tv162 = \"il2cpp_codegen_initialize_runtime_metadata\"(v161, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv166 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv167 = v166 + 0x70;\n\tv168 = \"il2cpp_codegen_initialize_runtime_metadata\"(v167, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv178 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv179 = v178 + 0xEF8;\n\tv180 = \"il2cpp_codegen_initialize_runtime_metadata\"(v179, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv185 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv186 = v185 + 0x200;\n\tv187 = \"il2cpp_codegen_initialize_runtime_metadata\"(v186, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv191 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv192 = v191 + 0x250;\n\tv193 = \"il2cpp_codegen_initialize_runtime_metadata\"(v192, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv198 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv199 = v198 + 0x3A8;\n\tv200 = \"il2cpp_codegen_initialize_runtime_metadata\"(v199, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv205 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv206 = v205 + 0x20;\n\tv207 = \"il2cpp_codegen_initialize_runtime_metadata\"(v206, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv211 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv212 = v211 + 0xF18;\n\tv213 = \"il2cpp_codegen_initialize_runtime_metadata\"(v212, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv218 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv219 = v218 + 0xEA8;\n\tv220 = \"il2cpp_codegen_initialize_runtime_metadata\"(v219, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv225 = CollectParticleData[];\n\tv226 = v225 + 0x350;\n\tv227 = \"il2cpp_codegen_initialize_runtime_metadata\"(v226, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv231 = Il2CppMethodInfo;\n\tv232 = v231 + 0x868;\n\tv233 = \"il2cpp_codegen_initialize_runtime_metadata\"(v232, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv238 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv239 = v238 + 0x9D8;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v239, methodInfo, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv69 = 1;\n\t*([302AA2A]) = v69;\nL_0073:\n\tthis.maxParticles = *([28759B0]);\n\tthis.snowFluidType = 2.1219957914E-313d;\n\tv75 = new *([v30 @ X27_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v75);\n\tv85 = this + 0x40;\n\tthis.usedFluidTypes = v75;\n\tv87 = 0xF3F1B4(v85, v75, v52, v53, v54, v55, v56, v57, 2.1219957914E-313d, v59, v60, v61, v62, v63, v64, v65);\n\tthis.viscosityStrength = *([28759C0]);\n\tthis.buoyancyStrength = 3.16649651378037E-10d;\n\tthis.splashDownStrength = 8f;\n\tthis.powerUpThreshold = 1.060997895606E-312d;\n\tthis.particleRadius = *([28759D0]);\n\tthis.honeyRepelStrength = *([28759E0]);\n\tthis.destroyDuration = 3.051758520768999E-05d;\n\tthis.chainDelay = 0.5f;\n\tv107 = \"SzArrayNew\"(*([v35 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+350]), 3, v52, v53, v54, v55, v56, v57, 3.051758520768999E-05d, v59, v60, v61, v62, v63, v64, v65);\n\tv112 = this + 0x238;\n\tthis.powerUpMaterials = v107;\n\tv113 = 0xF3F1B4(v112, v107, v52, v53, v54, v55, v56, v57, 3.051758520768999E-05d, v59, v60, v61, v62, v63, v64, v65);\n\tv118 = new *([v37 @ X28_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+250])();\n\tSystem.Collections.Generic.List`1<PowerUp>::.ctor(v118);\n\tv127 = this + 0x240;\n\tthis.powerUps = v118;\n\tv129 = 0xF3F1B4(v127, v118, v52, v53, v54, v55, v56, v57, 3.051758520768999E-05d, v59, v60, v61, v62, v63, v64, v65);\n\tv134 = new *([v41 @ X23_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+480])();\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, PowerUp>::.ctor(v134);\n\tv143 = this + 0x248;\n\tthis.powerUpById = v134;\n\tv145 = 0xF3F1B4(v143, v134, v52, v53, v54, v55, v56, v57, 3.051758520768999E-05d, v59, v60, v61, v62, v63, v64, v65);\n\tv149 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv152 = new *([v149 @ X8_v13 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+9D8])();\n\tSystem.Collections.Generic.Queue`1<System.Int32>::.ctor(v152);\n\tv163 = this + 0x288;\n\tthis.explosionQueue = v152;\n\tv165 = 0xF3F1B4(v163, v152, v52, v53, v54, v55, v56, v57, 3.051758520768999E-05d, v59, v60, v61, v62, v63, v64, v65);\n\tthis.powerUpCohesionRadi\n// ... truncated")]
	public FluidSolver()
	{
		//IL_0014: Expected I, but got O
		//IL_0023: Expected I, but got O
		//IL_0031: Expected I, but got O
		//IL_0040: Expected I, but got O
		//IL_0506: Expected I4, but got F8
		//IL_051b: Expected I4, but got F8
		//IL_0531: Expected O, but got I
		//IL_0058: Expected F4, but got I
		//IL_0088: Expected I4, but got F8
		//IL_009d: Expected I4, but got F8
		//IL_00af: Expected F4, but got I
		//IL_00c1: Expected F4, but got I
		//IL_00f8: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_0182: Expected I, but got O
		//IL_019e: Expected O, but got I
		//IL_01c4: Expected F4, but got I
		//IL_01d6: Expected F4, but got I
		//IL_01e5: Expected I4, but got I8
		//IL_01f3: Expected I, but got O
		//IL_020f: Expected O, but got I
		//IL_0236: Expected I, but got O
		//IL_0252: Expected O, but got I
		//IL_0274: Expected I, but got O
		//IL_0290: Expected O, but got I
		//IL_02b7: Expected I, but got O
		//IL_02d3: Expected O, but got I
		//IL_0318: Expected O, but got I
		//IL_0355: Expected I, but got O
		//IL_0371: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03c7: Expected I, but got O
		//IL_03e3: Expected O, but got I
		//IL_0405: Expected I, but got O
		//IL_0421: Expected O, but got I
		//IL_0448: Expected I, but got O
		//IL_0464: Expected O, but got I
		base._002Ector();
		nint num2 = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759B0]");
		maxParticles = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759B0]");
		maxTypeBatches = (int)((nuint)0u >> 32);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759B0]");
		colorFluidTypes = (int)((nuint)0u >> 64);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759B0]");
		mudFluidType = (int)((nuint)0u >> 96);
		snowFluidType = 0;
		honeyFluidType = 2.1219957914E-313 >> 32;
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		usedFluidTypes = hashSet;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759C0]");
		viscosityStrength = 0f;
		buoyancyStrength = 4f;
		waterReactionMultiplier = 0.12f;
		splashDownStrength = 8f;
		powerUpThreshold = 0;
		bigPowerUpThreshold = 1.060997895606E-312 >> 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759D0]");
		particleRadius = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759E0]");
		honeyRepelStrength = 0f;
		destroyDuration = 0.2f;
		chargeDuration = 0.5f;
		chainDelay = 0.5f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::UnityEngine.Material[] array = default(global::UnityEngine.Material[]);
		powerUpMaterials = array;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<PowerUp> list = new global::System.Collections.Generic.List<PowerUp>();
		powerUps = list;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.Dictionary<int, PowerUp> dictionary = new global::System.Collections.Generic.Dictionary<int, PowerUp>();
		powerUpById = dictionary;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.Queue<int> queue = new global::System.Collections.Generic.Queue<int>();
		explosionQueue = queue;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759F0]");
		powerUpCohesionRadius = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759F0]");
		fishCohesionRadius = 0f;
		octopusHeadParticleCount = 4;
		global::System.Collections.Generic.List<Octopus> list2 = new global::System.Collections.Generic.List<Octopus>();
		octopi = list2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<Caterpillar> list3 = new global::System.Collections.Generic.List<Caterpillar>();
		caterpillars = list3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<Bee> list4 = new global::System.Collections.Generic.List<Bee>();
		bees = list4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<Sponge> list5 = new global::System.Collections.Generic.List<Sponge>();
		sponges = list5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		spongeCohesionRadius = 0.15f;
		spongeSpringStrength = 40f;
		global::System.Collections.Generic.HashSet<int> pendingRemovalIds = new global::System.Collections.Generic.HashSet<int>();
		_pendingRemovalIds = pendingRemovalIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		powerUpMergeDistance = 0.6f;
		mergeDuration = 0.5f;
		global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData> dictionary2 = new global::System.Collections.Generic.Dictionary<int, FluidSolver.PowerUpMergeData>();
		merging = dictionary2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.HashSet<int> hashSet2 = new global::System.Collections.Generic.HashSet<int>();
		exploding = hashSet2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<Honey> list6 = new global::System.Collections.Generic.List<Honey>();
		honeys = list6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<Clump> list7 = new global::System.Collections.Generic.List<Clump>();
		clumps = list7;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<Fish> list8 = new global::System.Collections.Generic.List<Fish>();
		fishes = list8;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		defaultGravity = default(global::Unity.Mathematics.float2);
		splashDestroyRadius = 0.4f;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x1007234", Offset = "0x1007234", Length = "0x108")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0020;\n\tv42 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv43 = v42 + 0x918;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v43, , methodInfo, v46, v47, v48, v49, v50, pos, v0, currR, v51, v52, v53, v54, v55);\n\tv58 = 1;\n\t*([2DD4420]) = v58;\nL_0020:\n\tv59 = pos - *([ @ X1 (<>c__DisplayClass183_0&)]);\n\tv60 = pos.y - *([ @ X1 (<>c__DisplayClass183_0&)+4]);\n\tgoto L_002A;\n\tv67 = \"il2cpp_codegen_runtime_class_init\"(v63, , methodInfo, v46, v47, v48, v49, v50, pos, v0, currR, v51, v52, v53, v54, v55);\nL_002A:\n\tv69 = v59 * v59;\n\tv70 = v60 * v60;\n\tv71 = v69 + v70;\n\tv72 = UnityEngine.Mathf::Sqrt(v71);\n\tv76 = v72 - currR;\n\tv77 = v76 < 0;\n\tv78 = v76 == 0;\n\tv79 = v72 ^ currR;\n\tv80 = v72 ^ v76;\n\tv81 = v79 & v80;\n\tv82 = v81 < 0;\n\tv83 = v77 == v82;\n\tv84 = ~v83;\n\tv85 = v84 | v78;\n\tv86 = ~v85;\n\tif (v86) goto L_FFFFFFFF;\n\tv87 = v72 < *([ @ X1 (<>c__DisplayClass183_0&)+8]);\n\tv107 = ~v87;\n\tv89 = v72 - *([ @ X1 (<>c__DisplayClass183_0&)+8]);\n\tv104 = v89 == 0;\n\tgoto L_004C;\nL_004C:\n\tv108 = ~v107;\n\tv109 = v108 | v104;\n\tif (v109) goto L_FFFFFFFF;\n\tv122 = v72 > this.destroyRadius;\n\tif (v122) goto L_FFFFFFFF;\n\tv141 = *([ @ X1 (<>c__DisplayClass183_0&)+18]) == 1;\n\tif (v141) goto L_0086;\n\tv199 = *([ @ X1 (<>c__DisplayClass183_0&)+18]) == 0;\n\tv200 = ~v199;\n\tif (v200) goto L_FFFFFFFF;\n\tv202 = UnityEngine.Mathf::Abs(v60);\n\tv217 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) - v202;\n\tv167 = v217 < 0;\n\tv220 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) ^ v202;\n\tv221 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) ^ v217;\n\tv222 = v220 & v221;\n\tv152 = v222 < 0;\n\tgoto L_009D;\nL_0085:\n\treturn returnVal1;\nL_0086:\n\tv201 = UnityEngine.Mathf::Abs(v60);\n\tv203 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) >= v201;\n\tif (v203) goto L_FFFFFFFF;\n\tv224 = UnityEngine.Mathf::Abs(v59);\n\tv232 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) - v224;\n\tv167 = v232 < 0;\n\tv229 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) ^ v224;\n\tv228 = *([ @ X1 (<>c__DisplayClass183_0&)+1C]) ^ v232;\n\tv227 = v229 & v228;\n\tv152 = v227 < 0;\nL_009D:\n\tv149 = v167 == v152;\n\tgoto L_0085;\n\tgoto L_0085;\n\treturn X0;\n// 99 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private bool _003CRadialDestroyRoutine_003Eg__ShouldHitAtPosition_007C183_0(global::Unity.Mathematics.float2 pos, float currR, ref FluidSolver._003C_003Ec__DisplayClass183_0 P_2)
	{
		//IL_007d: Expected O, but got F4
		//IL_008a: Expected O, but got F4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
		float num = float5.x - (float)P_2;
		float num2 = pos.y;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+4]");
		float num3 = num2 - 0f;
		float num4 = num * num;
		float num5 = num3 * num3;
		float f = num4 + num5;
		float num6 = global::UnityEngine.Mathf.Sqrt(f);
		float num7 = num6 - currR;
		bool flag = num7 < 0f;
		bool flag2 = num7 == 0f;
		object obj = num6 ^ currR;
		object obj2 = num6 ^ num7;
		int num8 = (int)((nint)obj & (nint)obj2);
		bool flag3 = num8 < 0;
		bool flag4 = flag == flag3;
		bool flag5 = !flag4;
		bool flag7;
		bool flag8;
		if (flag5 || flag2)
		{
			float num9 = num6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+8]");
			bool flag6 = num9 < 0f;
			flag7 = !flag6;
			float num10 = num6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+8]");
			float num11 = num10 - 0f;
			flag8 = num11 == 0f;
		}
		else
		{
			flag8 = false;
			flag7 = false;
		}
		bool flag9 = !flag7;
		if (!(flag9 || flag8) && !(num6 > destroyRadius))
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+18]");
			bool flag10;
			bool flag11;
			if ((nint)0 != 1)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+18]");
				if ((nint)0 != 0)
				{
					goto IL_030b;
				}
				float num12 = global::UnityEngine.Mathf.Abs(num3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				float num13 = 0f - num12;
				flag10 = num13 < 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				object obj3 = 0 ^ num12;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				object obj4 = 0 ^ num13;
				int num14 = (int)((nint)obj3 & (nint)obj4);
				flag11 = num14 < 0;
			}
			else
			{
				float num15 = global::UnityEngine.Mathf.Abs(num3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				if (!(0f < num15))
				{
					goto IL_030b;
				}
				float num16 = global::UnityEngine.Mathf.Abs(num);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				float num17 = 0f - num16;
				flag10 = num17 < 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				object obj5 = 0 ^ num16;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass183_0&)+1C]");
				object obj6 = 0 ^ num17;
				int num18 = (int)((nint)obj5 & (nint)obj6);
				flag11 = num18 < 0;
			}
			return flag10 == flag11;
		}
		return false;
		IL_030b:
		return true;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
	[global::Cpp2ILInjected.Address(RVA = "0x1007368", Offset = "0x1007368", Length = "0x190")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = 0x302A000;\n\tgoto L_0027;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0x968;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, , methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0x970;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, , methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0x978;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, , methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv82 = Il2CppMethodInfo;\n\tv83 = v82 + 0x998;\n\tv84 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, , methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv119 = Il2CppMethodInfo;\n\tv120 = v119 + 0xC28;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v120, , methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv53 = 1;\n\t*([302AA2B]) = v53;\nL_0027:\n\tv54 = 0;\n\tv59 = *([v128 @ X1_v1 (<>c__DisplayClass190_0&)]) == 0;\n\tif (v59) goto L_0063;\n\tv63 = Il2CppMethodInfo;\n\tv65 = Il2CppMethodInfo;\n\tv67 = Il2CppMethodInfo;\n\tv69 = Il2CppMethodInfo;\n\tv74 = System.Collections.Generic.HashSet`1::GetEnumerator /* +1 sharing this address */(*([v128 @ X1_v1 (<>c__DisplayClass190_0&)]), *([v63 @ X8_v4 (Il2CppMethodInfo)+998]));\n\tv81 = this + 0x1F8;\nL_003F:\n\tv107 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v54 @ stack_-68_v1, *([v65 @ X22_v3 (Il2CppMethodInfo)+970]));\n\tv121 = v107 & 1;\n\tv122 = v121 == 0;\n\tif (v122) goto L_0056;\n\tv100 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v81, 0, &v92 @ stack_-6C_v4, *([v67 @ X23_v3 (Il2CppMethodInfo)+C28]));\n\tv145 = v100 & 1;\n\tv102 = v145 == 0;\n\tif (v102) goto L_003F;\n\tv87 = v92 << 4;\n\tv104 = this.emissionColors + v87;\n\t*([v104 @ X8_v9]) = 0;\n\t*([v104 @ X8_v9+4]) = g;\n\t*([v104 @ X8_v9+8]) = 0;\n\t*([v104 @ X8_v9+C]) = a;\n\tgoto L_003F;\nL_0056:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v54 @ stack_-68_v1, *([v69 @ X21_v4 (Il2CppMethodInfo)+968]));\nL_0062:\n\treturn;\nL_0063:\n\tv75 = new System.NullReferenceException();\n\tgoto L_006F;\nL_006F:\n\tv118 = v128 != 1;\n\tif (v118) goto L_007F;\n\tv124 = 0x274A080(v75, v128, methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv142 = 0x274A098(v124, v128, methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v170, *([v30 @ X21_v1]));\n\tv133 = *([v124 @ X0_v11]) == 0;\n\tif (v133) goto L_0062;\n\tv131 = new System.OutOfMemoryException();\nL_007F:\n\tv137 = 0xBF092C(&v127 @ stack_-80, *([v30 @ X21_v1]), methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv144 = 0x27498DC(v134, *([v30 @ X21_v1]), methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\tv192 = 0xD6F8(v144, *([v30 @ X21_v1]), methodInfo, v39, v40, v41, v42, v43, g, a, v44, v45, v46, v47, v48, v49);\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void _003CHandleRejectFlash_003Eg__SetEmissionValues_007C190_0(float g, float a, ref FluidSolver._003C_003Ec__DisplayClass190_0 P_2)
	{
		//IL_0009: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_003c: Expected O, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		object obj = 50503680;
		object obj2 = 0;
		ref FluidSolver._003C_003Ec__DisplayClass190_0 reference = default(ref FluidSolver._003C_003Ec__DisplayClass190_0);
		if ((object)reference != null)
		{
			nint num = 0;
			nint num2 = 0;
			nint num3 = 0;
			nint num4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C35B0 (System.Collections.Generic.HashSet`1::GetEnumerator, and 1 more at this address)");
			object obj4 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj4 & 1) == 0)
				{
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
				if ((int)((nint)obj5 & 1) != 0)
				{
					int num5 = (int)((nint)obj6 << 4);
					object obj7 = emissionColors + num5;
					obj7 = 0;
					_ = 0;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag = global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			object obj9 = obj8;
			ex2 = (global::System.NullReferenceException)(object)ex3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}
}