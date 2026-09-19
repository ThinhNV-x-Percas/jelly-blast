namespace PathCreation.Examples
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.MeshFilter), typeof(global::UnityEngine.MeshRenderer))]
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	public class PlanarLineMeshCreator : global::PathCreation.Examples.PathSceneTool
	{
		[global::UnityEngine.Tooltip("Half-width of the ribbon (world units).")]
		[global::UnityEngine.Header("Shape")]
		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float thickness;

		[global::UnityEngine.Range(1f, 20f)]
		[global::UnityEngine.Tooltip("Sub-samples per repeat segment (smoothness).")]
		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int subdivisionsPerSegment;

		[global::UnityEngine.Header("Layering")]
		[global::UnityEngine.Tooltip("Local-space Z written into every vertex.")]
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float localZ;

		[global::UnityEngine.Header("UV Options")]
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool flipU;

		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool flipV;

		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::UnityEngine.MeshFilter mf;

		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::UnityEngine.MeshRenderer mr;

		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::UnityEngine.Mesh mesh;

		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float innerSegmentLengthRatio;

		[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
		protected override void PathUpdated()
		{
			if (pathCreator == null)
			{
				return;
			}
			if (mf == null)
			{
				mf = GetComponent<global::UnityEngine.MeshFilter>();
			}
			if (mr == null)
			{
				mr = GetComponent<global::UnityEngine.MeshRenderer>();
			}
			BuildMesh();
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
		private void BuildMesh()
		{
			if (mesh == null)
			{
				mesh = new global::UnityEngine.Mesh();
			}
			else
			{
				mesh.Clear();
			}

			global::PathCreation.VertexPath vertexPath = pathCreator.path;
			float usableLength = global::UnityEngine.Mathf.Max(0f, vertexPath.length - thickness * 2f);
			int numInnerSegments;
			float innerSegmentLength;
			if (usableLength > 0f)
			{
				float rawInnerSegmentLength = thickness * innerSegmentLengthRatio;
				numInnerSegments = global::UnityEngine.Mathf.Max(1, global::UnityEngine.Mathf.RoundToInt(usableLength / rawInnerSegmentLength));
				innerSegmentLength = usableLength / numInnerSegments;
			}
			else
			{
				numInnerSegments = 0;
				innerSegmentLength = 0f;
			}

			global::System.Collections.Generic.List<float> segmentStarts = new global::System.Collections.Generic.List<float>();
			global::System.Collections.Generic.List<float> segmentEnds = new global::System.Collections.Generic.List<float>();
			segmentStarts.Add(0f);
			segmentEnds.Add(thickness);
			for (int i = 0; i < numInnerSegments; i++)
			{
				segmentStarts.Add(thickness + i * innerSegmentLength);
				segmentEnds.Add(thickness + (i + 1) * innerSegmentLength);
			}
			segmentStarts.Add(vertexPath.length - thickness);
			segmentEnds.Add(vertexPath.length);

			int subdivisions = global::UnityEngine.Mathf.Max(1, subdivisionsPerSegment);

			global::System.Collections.Generic.List<float> sampleDistances = new global::System.Collections.Generic.List<float>();
			global::System.Collections.Generic.List<int> sampleSegmentIndex = new global::System.Collections.Generic.List<int>();
			global::System.Collections.Generic.List<float> sampleT = new global::System.Collections.Generic.List<float>();
			for (int i = 0; i < segmentStarts.Count; i++)
			{
				float start = segmentStarts[i];
				float end = segmentEnds[i];
				float length = end - start;
				int jStart = (i == 0) ? 0 : 1;
				if (i != 0)
				{
					sampleDistances.Add(start);
					sampleSegmentIndex.Add(i);
					sampleT.Add(0f);
				}
				for (int j = jStart; j <= subdivisions; j++)
				{
					float t = (float)j / subdivisions;
					sampleDistances.Add(start + length * t);
					sampleSegmentIndex.Add(i);
					sampleT.Add(t);
				}
			}

			if (sampleDistances.Count < 2)
			{
				mf.sharedMesh = mesh;
				return;
			}

			int capacity = sampleDistances.Count << 1;
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> verts = new global::System.Collections.Generic.List<global::UnityEngine.Vector3>(capacity);
			global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs = new global::System.Collections.Generic.List<global::UnityEngine.Vector2>(capacity);
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> normals = new global::System.Collections.Generic.List<global::UnityEngine.Vector3>(capacity);
			global::System.Collections.Generic.List<int> triangles = new global::System.Collections.Generic.List<int>(sampleDistances.Count * 6);

			global::UnityEngine.Transform tr = base.transform;
			global::UnityEngine.Vector3 localNormal = tr.InverseTransformDirection(global::UnityEngine.Vector3.back);
			float normalLen = localNormal.magnitude;
			localNormal = (normalLen > 1E-05f) ? (localNormal / normalLen) : global::UnityEngine.Vector3.back;

			for (int k = 0; k < sampleDistances.Count; k++)
			{
				float d = sampleDistances[k];
				global::UnityEngine.Vector3 pointAtDistance = vertexPath.GetPointAtDistance(d, global::PathCreation.EndOfPathInstruction.Stop);
				global::UnityEngine.Vector3 directionAtDistance = vertexPath.GetDirectionAtDistance(d, global::PathCreation.EndOfPathInstruction.Stop);
				float len = global::UnityEngine.Mathf.Sqrt(directionAtDistance.y * directionAtDistance.y + directionAtDistance.x * directionAtDistance.x);
				float px;
				float py;
				if (len > 1E-05f)
				{
					px = 0f - directionAtDistance.y / len;
					py = directionAtDistance.x / len;
				}
				else
				{
					px = 0f;
					py = 0f;
				}

				global::UnityEngine.Vector3 leftWorld = new global::UnityEngine.Vector3(pointAtDistance.x - px * thickness, pointAtDistance.y - py * thickness, pointAtDistance.z);
				global::UnityEngine.Vector3 rightWorld = new global::UnityEngine.Vector3(pointAtDistance.x + px * thickness, pointAtDistance.y + py * thickness, pointAtDistance.z);
				global::UnityEngine.Vector3 leftLocal = tr.InverseTransformPoint(leftWorld);
				leftLocal.z = localZ;
				global::UnityEngine.Vector3 rightLocal = tr.InverseTransformPoint(rightWorld);
				rightLocal.z = localZ;
				verts.Add(leftLocal);
				verts.Add(rightLocal);
				normals.Add(localNormal);
				normals.Add(localNormal);

				float t = sampleT[k];
				float u = flipU ? (1f - t) : t;
				float vA = flipV ? 1f : 0f;
				float vB = flipV ? 0f : 1f;
				uvs.Add(new global::UnityEngine.Vector2(u, vA));
				uvs.Add(new global::UnityEngine.Vector2(u, vB));
			}

			for (int k = 1; k < sampleDistances.Count; k++)
			{
				if (sampleSegmentIndex[k] != sampleSegmentIndex[k - 1])
				{
					continue;
				}
				int baseIndex = (k - 1) * 2;
				triangles.Add(baseIndex);
				triangles.Add(baseIndex + 1);
				triangles.Add(baseIndex + 2);
				triangles.Add(baseIndex + 2);
				triangles.Add(baseIndex + 1);
				triangles.Add(baseIndex + 3);
			}

			mesh.SetVertices(verts);
			mesh.SetUVs(0, uvs);
			mesh.SetNormals(normals);
			mesh.SetTriangles(triangles, 0);
			mesh.RecalculateBounds();
			mf.sharedMesh = mesh;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1024EEC", Offset = "0x1024EEC", Length = "0x20")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.thickness = 0.05f;\n\tthis.innerSegmentLengthRatio = 4f;\n\tPathCreation.Examples.PathSceneTool::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public PlanarLineMeshCreator()
		{
			thickness = 0.05f;
			innerSegmentLengthRatio = 4f;
		}
	}
}
