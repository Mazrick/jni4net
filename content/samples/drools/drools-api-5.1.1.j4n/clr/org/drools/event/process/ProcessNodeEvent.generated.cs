//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.process {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ProcessNodeEvent : global::org.drools.@event.process.ProcessEvent {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/runtime/process/NodeInstance;")]
        global::org.drools.runtime.process.NodeInstance getNodeInstance();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ProcessNodeEvent_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.process.@__ProcessNodeEvent.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.process.ProcessNodeEvent), typeof(global::org.drools.@event.process.ProcessNodeEvent_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.process.ProcessNodeEvent), typeof(global::org.drools.@event.process.ProcessNodeEvent_))]
    internal sealed partial class @__ProcessNodeEvent : global::java.lang.Object, global::org.drools.@event.process.ProcessNodeEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getKnowledgeRuntime0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProcessInstance1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getNodeInstance2;
        
        private @__ProcessNodeEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.process.@__ProcessNodeEvent.staticClass = @__class;
            global::org.drools.@event.process.@__ProcessNodeEvent._getKnowledgeRuntime0 = @__env.GetMethodID(global::org.drools.@event.process.@__ProcessNodeEvent.staticClass, "getKnowledgeRuntime", "()Lorg/drools/runtime/KnowledgeRuntime;");
            global::org.drools.@event.process.@__ProcessNodeEvent._getProcessInstance1 = @__env.GetMethodID(global::org.drools.@event.process.@__ProcessNodeEvent.staticClass, "getProcessInstance", "()Lorg/drools/runtime/process/ProcessInstance;");
            global::org.drools.@event.process.@__ProcessNodeEvent._getNodeInstance2 = @__env.GetMethodID(global::org.drools.@event.process.@__ProcessNodeEvent.staticClass, "getNodeInstance", "()Lorg/drools/runtime/process/NodeInstance;");
        }
        
        public global::org.drools.runtime.KnowledgeRuntime getKnowledgeRuntime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.KnowledgeRuntime>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.process.@__ProcessNodeEvent._getKnowledgeRuntime0));
            }
        }
        
        public global::org.drools.runtime.process.ProcessInstance getProcessInstance() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.ProcessInstance>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.process.@__ProcessNodeEvent._getProcessInstance1));
            }
        }
        
        public global::org.drools.runtime.process.NodeInstance getNodeInstance() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.NodeInstance>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.process.@__ProcessNodeEvent._getNodeInstance2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ProcessNodeEvent);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKnowledgeRuntime", "getKnowledgeRuntime0", "()Lorg/drools/runtime/KnowledgeRuntime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProcessInstance", "getProcessInstance1", "()Lorg/drools/runtime/process/ProcessInstance;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getNodeInstance", "getNodeInstance2", "()Lorg/drools/runtime/process/NodeInstance;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getKnowledgeRuntime0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.process.ProcessNodeEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessNodeEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.KnowledgeRuntime>(@__env, ((global::org.drools.@event.KnowledgeRuntimeEvent)(@__real)).getKnowledgeRuntime());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProcessInstance1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/process/ProcessInstance;
            // ()Lorg/drools/runtime/process/ProcessInstance;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.process.ProcessNodeEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessNodeEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.process.ProcessInstance>(@__env, ((global::org.drools.@event.process.ProcessEvent)(@__real)).getProcessInstance());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getNodeInstance2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/process/NodeInstance;
            // ()Lorg/drools/runtime/process/NodeInstance;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.process.ProcessNodeEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessNodeEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.process.NodeInstance>(@__env, @__real.getNodeInstance());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.process.@__ProcessNodeEvent(@__env);
            }
        }
    }
    #endregion
}
