//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ServiceRegistryImpl : global::java.lang.Object, global::org.drools.util.ServiceRegistry {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _get0;
        
        internal static global::net.sf.jni4net.jni.MethodId _registerLocator1;
        
        internal static global::net.sf.jni4net.jni.MethodId _unregisterLocator2;
        
        internal static global::net.sf.jni4net.jni.MethodId _addDefault3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInstance4;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorServiceRegistryImpl5;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ServiceRegistryImpl() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::org.drools.util.ServiceRegistryImpl.staticClass, global::org.drools.util.ServiceRegistryImpl.@__ctorServiceRegistryImpl5, this);
            }
        }
        
        protected ServiceRegistryImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.util.ServiceRegistryImpl.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.util.ServiceRegistryImpl.staticClass = @__class;
            global::org.drools.util.ServiceRegistryImpl._get0 = @__env.GetMethodID(global::org.drools.util.ServiceRegistryImpl.staticClass, "get", "(Ljava/lang/Class;)Ljava/lang/Object;");
            global::org.drools.util.ServiceRegistryImpl._registerLocator1 = @__env.GetMethodID(global::org.drools.util.ServiceRegistryImpl.staticClass, "registerLocator", "(Ljava/lang/Class;Ljava/util/concurrent/Callable;)V");
            global::org.drools.util.ServiceRegistryImpl._unregisterLocator2 = @__env.GetMethodID(global::org.drools.util.ServiceRegistryImpl.staticClass, "unregisterLocator", "(Ljava/lang/Class;)V");
            global::org.drools.util.ServiceRegistryImpl._addDefault3 = @__env.GetMethodID(global::org.drools.util.ServiceRegistryImpl.staticClass, "addDefault", "(Ljava/lang/Class;Ljava/lang/String;)V");
            global::org.drools.util.ServiceRegistryImpl._getInstance4 = @__env.GetStaticMethodID(global::org.drools.util.ServiceRegistryImpl.staticClass, "getInstance", "()Lorg/drools/util/ServiceRegistry;");
            global::org.drools.util.ServiceRegistryImpl.@__ctorServiceRegistryImpl5 = @__env.GetMethodID(global::org.drools.util.ServiceRegistryImpl.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object get(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.util.ServiceRegistryImpl._get0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;Ljava/util/concurrent/Callable;)V")]
        public virtual void registerLocator(global::java.lang.Class par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.util.ServiceRegistryImpl._registerLocator1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)V")]
        public virtual void unregisterLocator(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.util.ServiceRegistryImpl._unregisterLocator2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;Ljava/lang/String;)V")]
        public virtual void addDefault(global::java.lang.Class par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.util.ServiceRegistryImpl._addDefault3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/util/ServiceRegistry;")]
        public static global::org.drools.util.ServiceRegistry getInstance() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.util.ServiceRegistry>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.util.ServiceRegistryImpl.staticClass, global::org.drools.util.ServiceRegistryImpl._getInstance4));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.util.ServiceRegistryImpl(@__env);
            }
        }
    }
    #endregion
}
