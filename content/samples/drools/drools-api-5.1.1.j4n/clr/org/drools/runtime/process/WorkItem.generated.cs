//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.process {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface WorkItem {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        long getId();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getState();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Object;")]
        global::java.lang.Object getResult(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Object;")]
        global::java.lang.Object getParameter(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getParameters();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getResults();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        long getProcessInstanceId();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class WorkItem_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.process.@__WorkItem.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PENDING {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::org.drools.runtime.process.@__WorkItem.staticClass, global::org.drools.runtime.process.@__WorkItem._PENDING8)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ACTIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::org.drools.runtime.process.@__WorkItem.staticClass, global::org.drools.runtime.process.@__WorkItem._ACTIVE9)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int COMPLETED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::org.drools.runtime.process.@__WorkItem.staticClass, global::org.drools.runtime.process.@__WorkItem._COMPLETED10)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ABORTED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::org.drools.runtime.process.@__WorkItem.staticClass, global::org.drools.runtime.process.@__WorkItem._ABORTED11)));
            }
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.process.WorkItem), typeof(global::org.drools.runtime.process.WorkItem_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.process.WorkItem), typeof(global::org.drools.runtime.process.WorkItem_))]
    internal sealed partial class @__WorkItem : global::java.lang.Object, global::org.drools.runtime.process.WorkItem {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getId1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getState2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResult3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameter4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameters5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResults6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProcessInstanceId7;
        
        internal static global::net.sf.jni4net.jni.FieldId _PENDING8;
        
        internal static global::net.sf.jni4net.jni.FieldId _ACTIVE9;
        
        internal static global::net.sf.jni4net.jni.FieldId _COMPLETED10;
        
        internal static global::net.sf.jni4net.jni.FieldId _ABORTED11;
        
        private @__WorkItem(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.process.@__WorkItem.staticClass = @__class;
            global::org.drools.runtime.process.@__WorkItem._getName0 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getName", "()Ljava/lang/String;");
            global::org.drools.runtime.process.@__WorkItem._getId1 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getId", "()J");
            global::org.drools.runtime.process.@__WorkItem._getState2 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getState", "()I");
            global::org.drools.runtime.process.@__WorkItem._getResult3 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getResult", "(Ljava/lang/String;)Ljava/lang/Object;");
            global::org.drools.runtime.process.@__WorkItem._getParameter4 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
            global::org.drools.runtime.process.@__WorkItem._getParameters5 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getParameters", "()Ljava/util/Map;");
            global::org.drools.runtime.process.@__WorkItem._getResults6 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getResults", "()Ljava/util/Map;");
            global::org.drools.runtime.process.@__WorkItem._getProcessInstanceId7 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItem.staticClass, "getProcessInstanceId", "()J");
            global::org.drools.runtime.process.@__WorkItem._PENDING8 = @__env.GetStaticFieldID(global::org.drools.runtime.process.@__WorkItem.staticClass, "PENDING", "I");
            global::org.drools.runtime.process.@__WorkItem._ACTIVE9 = @__env.GetStaticFieldID(global::org.drools.runtime.process.@__WorkItem.staticClass, "ACTIVE", "I");
            global::org.drools.runtime.process.@__WorkItem._COMPLETED10 = @__env.GetStaticFieldID(global::org.drools.runtime.process.@__WorkItem.staticClass, "COMPLETED", "I");
            global::org.drools.runtime.process.@__WorkItem._ABORTED11 = @__env.GetStaticFieldID(global::org.drools.runtime.process.@__WorkItem.staticClass, "ABORTED", "I");
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__WorkItem._getName0));
            }
        }
        
        public long getId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::org.drools.runtime.process.@__WorkItem._getId1)));
            }
        }
        
        public int getState() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.runtime.process.@__WorkItem._getState2)));
            }
        }
        
        public global::java.lang.Object getResult(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__WorkItem._getResult3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::java.lang.Object getParameter(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__WorkItem._getParameter4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::java.util.Map getParameters() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__WorkItem._getParameters5));
            }
        }
        
        public global::java.util.Map getResults() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.process.@__WorkItem._getResults6));
            }
        }
        
        public long getProcessInstanceId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::org.drools.runtime.process.@__WorkItem._getProcessInstanceId7)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__WorkItem);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "getName0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getId", "getId1", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getState", "getState2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getResult", "getResult3", "(Ljava/lang/String;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getParameter", "getParameter4", "(Ljava/lang/String;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getParameters", "getParameters5", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getResults", "getResults6", "()Ljava/util/Map;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProcessInstanceId", "getProcessInstanceId7", "()J"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getName0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static long getId1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = ((long)(@__real.getId()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getState2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = ((int)(@__real.getState()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getResult3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/Object;
            // (Ljava/lang/String;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.getResult(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getParameter4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/Object;
            // (Ljava/lang/String;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.getParameter(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getParameters5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getParameters());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getResults6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getResults());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static long getProcessInstanceId7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::org.drools.runtime.process.WorkItem @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItem>(@__env, @__obj);
            @__return = ((long)(@__real.getProcessInstanceId()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.process.@__WorkItem(@__env);
            }
        }
    }
    #endregion
}
