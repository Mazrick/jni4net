//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface JInterface {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void run();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void runForrestRun();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class JInterface_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__JInterface.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.tested.JInterface), typeof(global::net.sf.jni4net.tested.JInterface_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.JInterface), typeof(global::net.sf.jni4net.tested.JInterface_))]
    internal sealed partial class @__JInterface : global::java.lang.Object, global::net.sf.jni4net.tested.JInterface {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_run0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_runForrestRun1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_cdefined2;
        
        private @__JInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.@__JInterface.staticClass = @__class;
            global::net.sf.jni4net.tested.@__JInterface.j4n_run0 = @__env.GetMethodID(global::net.sf.jni4net.tested.@__JInterface.staticClass, "run", "()V");
            global::net.sf.jni4net.tested.@__JInterface.j4n_runForrestRun1 = @__env.GetMethodID(global::net.sf.jni4net.tested.@__JInterface.staticClass, "runForrestRun", "()V");
            global::net.sf.jni4net.tested.@__JInterface.j4n_cdefined2 = @__env.GetMethodID(global::net.sf.jni4net.tested.@__JInterface.staticClass, "cdefined", "()V");
        }
        
        public void run() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.@__JInterface.j4n_run0);
            }
        }
        
        public void runForrestRun() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.@__JInterface.j4n_runForrestRun1);
            }
        }
        
        public void cdefined() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.@__JInterface.j4n_cdefined2);
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__JInterface);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "run", "run0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "runForrestRun", "runForrestRun1", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "cdefined", "cdefined2", "()V"));
            return methods;
        }
        
        private static void run0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.JInterface @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.jni4net.tested.JInterface>(@__env, @__obj);
            @__real.run();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void runForrestRun1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.JInterface @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.jni4net.tested.JInterface>(@__env, @__obj);
            @__real.runForrestRun();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void cdefined2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.JInterface @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.jni4net.tested.JInterface>(@__env, @__obj);
            @__real.cdefined();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.@__JInterface(@__env);
            }
        }
    }
    #endregion
}
