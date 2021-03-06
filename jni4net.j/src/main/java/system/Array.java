// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrType
public class Array extends system.Object implements system.ICloneable, system.collections.IList, system.collections.ICollection, system.collections.IEnumerable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Array(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected Array() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object Clone();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/IEnumerator;")
    public native system.collections.IEnumerator GetEnumerator();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;I)V")
    public native void CopyTo(system.Array array, int index);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getCount();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object getSyncRoot();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSynchronized();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)LSystem/Object;")
    public native system.Object getItem(int index);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILSystem/Object;)V")
    public native void setItem(int index, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int Add(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)Z")
    public native boolean Contains(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Clear();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isReadOnly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFixedSize();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int IndexOf(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILSystem/Object;)V")
    public native void Insert(int index, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)V")
    public native void Remove(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native void RemoveAt(int index);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;I)LSystem/Array;")
    public native static system.Array CreateInstance(system.Type elementType, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;II)LSystem/Array;")
    public native static system.Array CreateInstance(system.Type elementType, int length1, int length2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;III)LSystem/Array;")
    public native static system.Array CreateInstance(system.Type elementType, int length1, int length2, int length3);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;[I)LSystem/Array;")
    public native static system.Array CreateInstance(system.Type elementType, int[] lengths);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;[J)LSystem/Array;")
    public native static system.Array CreateInstance(system.Type elementType, long[] lengths);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;[I[I)LSystem/Array;")
    public native static system.Array CreateInstance(system.Type elementType, int[] lengths, int[] lowerBounds);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Array;I)V")
    public native static void Copy(system.Array sourceArray, system.Array destinationArray, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;ILSystem/Array;II)V")
    public native static void Copy(system.Array sourceArray, int sourceIndex, system.Array destinationArray, int destinationIndex, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;ILSystem/Array;II)V")
    public native static void ConstrainedCopy(system.Array sourceArray, int sourceIndex, system.Array destinationArray, int destinationIndex, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Array;J)V")
    public native static void Copy(system.Array sourceArray, system.Array destinationArray, long length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;JLSystem/Array;JJ)V")
    public native static void Copy(system.Array sourceArray, long sourceIndex, system.Array destinationArray, long destinationIndex, long length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;II)V")
    public native static void Clear(system.Array array, int index, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("([I)LSystem/Object;")
    public native system.Object GetValue(int[] indices);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)LSystem/Object;")
    public native system.Object GetValue(int index);
    
    @net.sf.jni4net.attributes.ClrMethod("(II)LSystem/Object;")
    public native system.Object GetValue(int index1, int index2);
    
    @net.sf.jni4net.attributes.ClrMethod("(III)LSystem/Object;")
    public native system.Object GetValue(int index1, int index2, int index3);
    
    @net.sf.jni4net.attributes.ClrMethod("(J)LSystem/Object;")
    public native system.Object GetValue(long index);
    
    @net.sf.jni4net.attributes.ClrMethod("(JJ)LSystem/Object;")
    public native system.Object GetValue(long index1, long index2);
    
    @net.sf.jni4net.attributes.ClrMethod("(JJJ)LSystem/Object;")
    public native system.Object GetValue(long index1, long index2, long index3);
    
    @net.sf.jni4net.attributes.ClrMethod("([J)LSystem/Object;")
    public native system.Object GetValue(long[] indices);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;I)V")
    public native void SetValue(system.Object value, int index);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;II)V")
    public native void SetValue(system.Object value, int index1, int index2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;III)V")
    public native void SetValue(system.Object value, int index1, int index2, int index3);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;[I)V")
    public native void SetValue(system.Object value, int[] indices);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;J)V")
    public native void SetValue(system.Object value, long index);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;JJ)V")
    public native void SetValue(system.Object value, long index1, long index2);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;JJJ)V")
    public native void SetValue(system.Object value, long index1, long index2, long index3);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;[J)V")
    public native void SetValue(system.Object value, long[] indices);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getLength();
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getLongLength();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)I")
    public native int GetLength(int dimension);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)J")
    public native long GetLongLength(int dimension);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getRank();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)I")
    public native int GetUpperBound(int dimension);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)I")
    public native int GetLowerBound(int dimension);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;)I")
    public native static int BinarySearch(system.Array array, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;IILSystem/Object;)I")
    public native static int BinarySearch(system.Array array, int index, int length, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;LSystem/Collections/IComparer;)I")
    public native static int BinarySearch(system.Array array, system.Object value, system.Object comparer);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;IILSystem/Object;LSystem/Collections/IComparer;)I")
    public native static int BinarySearch(system.Array array, int index, int length, system.Object value, system.Object comparer);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;J)V")
    public native void CopyTo(system.Array array, long index);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;)I")
    public native static int IndexOf(system.Array array, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;I)I")
    public native static int IndexOf(system.Array array, system.Object value, int startIndex);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;II)I")
    public native static int IndexOf(system.Array array, system.Object value, int startIndex, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;)I")
    public native static int LastIndexOf(system.Array array, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;I)I")
    public native static int LastIndexOf(system.Array array, system.Object value, int startIndex);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Object;II)I")
    public native static int LastIndexOf(system.Array array, system.Object value, int startIndex, int count);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;)V")
    public native static void Reverse(system.Array array);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;II)V")
    public native static void Reverse(system.Array array, int index, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;)V")
    public native static void Sort(system.Array array);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Array;)V")
    public native static void Sort(system.Array keys, system.Array items);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;II)V")
    public native static void Sort(system.Array array, int index, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Array;II)V")
    public native static void Sort(system.Array keys, system.Array items, int index, int length);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Collections/IComparer;)V")
    public native static void Sort(system.Array array, system.Object comparer);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Array;LSystem/Collections/IComparer;)V")
    public native static void Sort(system.Array keys, system.Array items, system.Object comparer);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;IILSystem/Collections/IComparer;)V")
    public native static void Sort(system.Array array, int index, int length, system.Object comparer);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;LSystem/Array;IILSystem/Collections/IComparer;)V")
    public native static void Sort(system.Array keys, system.Array items, int index, int length, system.Object comparer);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Initialize();
    
    public static system.Type typeof() {
        return system.Array.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.Array.staticType = staticType;
    }
    //</generated-proxy>
}
