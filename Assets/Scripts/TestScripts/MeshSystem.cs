using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

public class MeshSystem : ComponentSystem {

    public static unsafe void NativeAddRange<T>(this List<T> list, DynamicBuffer<T> dynamicBuffer)
            where T : struct {
        NativeAddRange(list, dynamicBuffer.GetBasePointer(), dynamicBuffer.Length);
    }

    private static unsafe void NativeAddRange<T>(List<T> list, void* arrayBuffer, int length)
        where T : struct {
        var index = list.Count;
        var newLength = index + length;

        // Resize our list if we require
        if(list.Capacity < newLength) {
            list.Capacity = newLength;
        }

        var items = NoAllocHelpers.ExtractArrayFromListT(list);
        var size = UnsafeUtility.SizeOf<T>();

        // Get the pointer to the end of the list
        var bufferStart = (IntPtr)UnsafeUtility.AddressOf(ref items[0]);
        var buffer = (byte*)(bufferStart + (size * index));

        UnsafeUtility.MemCpy(buffer, arrayBuffer, length * (long)size);

        NoAllocHelpers.ResizeList(list, newLength);
    }


    private readonly List<Vector3> verticesList = new List<Vector3>();
    private readonly List<Vector3> normalsList = new List<Vector3>();
    private readonly List<Vector3> uvsList = new List<Vector3>();
    private readonly List<int> trianglesList = new List<int>();

    // ...

    private void SetMesh(
        Mesh mesh,
        DynamicBuffer<Vector3> vertices,
        DynamicBuffer<Vector3> uvs,
        DynamicBuffer<Vector3> normals,
        DynamicBuffer<int> triangles) {
        mesh.Clear();

        if(vertices.Length == 0) {
            return;
        }

        this.verticesList.NativeAddRange(vertices);
        this.uvsList.NativeAddRange(uvs);
        this.normalsList.NativeAddRange(normals);
        this.trianglesList.NativeAddRange(triangles);

        mesh.SetVertices(this.verticesList);
        mesh.SetNormals(this.normalsList);
        mesh.SetUVs(0, this.uvsList);
        mesh.SetTriangles(this.trianglesList, 0);

        this.verticesList.Clear();
        this.normalsList.Clear();
        this.uvsList.Clear();
        this.trianglesList.Clear();
    }
    */