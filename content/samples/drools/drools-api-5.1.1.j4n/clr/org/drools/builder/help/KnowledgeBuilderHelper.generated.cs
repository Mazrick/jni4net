//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder.help {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class KnowledgeBuilderHelper : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _addXsdModel0;
        
        internal static global::net.sf.jni4net.jni.MethodId _newJAXBContext1;
        
        internal static global::net.sf.jni4net.jni.MethodId _newJAXBContext2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDroolsJaxbHelperProvider3;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorKnowledgeBuilderHelper4;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public KnowledgeBuilderHelper() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, global::org.drools.builder.help.KnowledgeBuilderHelper.@__ctorKnowledgeBuilderHelper4, this);
            }
        }
        
        protected KnowledgeBuilderHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass = @__class;
            global::org.drools.builder.help.KnowledgeBuilderHelper._addXsdModel0 = @__env.GetStaticMethodID(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, "addXsdModel", "(Lorg/drools/io/Resource;Lorg/drools/builder/KnowledgeBuilder;Lcom/sun/tools/xjc/" +
                    "Options;Ljava/lang/String;)[Ljava/lang/String;");
            global::org.drools.builder.help.KnowledgeBuilderHelper._newJAXBContext1 = @__env.GetStaticMethodID(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, "newJAXBContext", "([Ljava/lang/String;Ljava/util/Map;Lorg/drools/KnowledgeBase;)Ljavax/xml/bind/JAX" +
                    "BContext;");
            global::org.drools.builder.help.KnowledgeBuilderHelper._newJAXBContext2 = @__env.GetStaticMethodID(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, "newJAXBContext", "([Ljava/lang/String;Lorg/drools/KnowledgeBase;)Ljavax/xml/bind/JAXBContext;");
            global::org.drools.builder.help.KnowledgeBuilderHelper._getDroolsJaxbHelperProvider3 = @__env.GetStaticMethodID(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, "getDroolsJaxbHelperProvider", "()Lorg/drools/builder/help/DroolsJaxbHelperProvider;");
            global::org.drools.builder.help.KnowledgeBuilderHelper.@__ctorKnowledgeBuilderHelper4 = @__env.GetMethodID(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/io/Resource;Lorg/drools/builder/KnowledgeBuilder;Lcom/sun/tools/xjc/" +
            "Options;Ljava/lang/String;)[Ljava/lang/String;")]
        public static java.lang.String[] addXsdModel(global::org.drools.io.Resource par0, global::org.drools.builder.KnowledgeBuilder par1, global::java.lang.Object par2, global::java.lang.String par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, global::org.drools.builder.help.KnowledgeBuilderHelper._addXsdModel0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.io.Resource>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.builder.KnowledgeBuilder>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;Ljava/util/Map;Lorg/drools/KnowledgeBase;)Ljavax/xml/bind/JAX" +
            "BContext;")]
        public static global::java.lang.Object newJAXBContext(java.lang.String[] par0, global::java.util.Map par1, global::org.drools.KnowledgeBase par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, global::org.drools.builder.help.KnowledgeBuilderHelper._newJAXBContext1, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.KnowledgeBase>(@__env, par2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;Lorg/drools/KnowledgeBase;)Ljavax/xml/bind/JAXBContext;")]
        public static global::java.lang.Object newJAXBContext(java.lang.String[] par0, global::org.drools.KnowledgeBase par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, global::org.drools.builder.help.KnowledgeBuilderHelper._newJAXBContext2, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.KnowledgeBase>(@__env, par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/builder/help/DroolsJaxbHelperProvider;")]
        public static global::org.drools.builder.help.DroolsJaxbHelperProvider getDroolsJaxbHelperProvider() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.help.DroolsJaxbHelperProvider>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.builder.help.KnowledgeBuilderHelper.staticClass, global::org.drools.builder.help.KnowledgeBuilderHelper._getDroolsJaxbHelperProvider3));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.help.KnowledgeBuilderHelper(@__env);
            }
        }
    }
    #endregion
}
