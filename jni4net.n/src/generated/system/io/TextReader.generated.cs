//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO {
    
    
    #region Component Designer generated code 
    public partial class TextReader_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.IO.@__TextReader.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IO.TextReader), typeof(global::System.IO.TextReader_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IO.TextReader), typeof(global::System.IO.TextReader_))]
    internal sealed partial class @__TextReader : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__TextReader(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.IO.@__TextReader.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__TextReader);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Dispose", "Dispose0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Close", "Close1", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Peek", "Peek2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Read", "Read3", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Read", "Read4", "([CII)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ReadToEnd", "ReadToEnd5", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ReadBlock", "ReadBlock6", "([CII)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ReadLine", "ReadLine7", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Synchronized", "Synchronized8", "(Lsystem/io/TextReader;)Lsystem/io/TextReader;"));
            return methods;
        }
        
        private static void Dispose0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            ((global::System.IDisposable)(@__real)).Dispose();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Close1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__real.Close();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static int Peek2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__return = ((int)(@__real.Peek()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int Read3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__return = ((int)(@__real.Read()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int Read4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle buffer, int index, int count) {
            // ([CII)I
            // ([CII)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__return = ((int)(@__real.Read(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cchar(@__env, buffer), index, count)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ReadToEnd5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.ReadToEnd());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int ReadBlock6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle buffer, int index, int count) {
            // ([CII)I
            // ([CII)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__return = ((int)(@__real.ReadBlock(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cchar(@__env, buffer), index, count)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ReadLine7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IO.TextReader @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.ReadLine());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Synchronized8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle reader) {
            // (Lsystem/io/TextReader;)Lsystem/io/TextReader;
            // (LSystem/IO/TextReader;)LSystem/IO/TextReader;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.IO.TextReader>(@__env, global::System.IO.TextReader.Synchronized(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.IO.TextReader>(@__env, reader)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.IO.@__TextReader(@__env);
            }
        }
    }
    #endregion
}
