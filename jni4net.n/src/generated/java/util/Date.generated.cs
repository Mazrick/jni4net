//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Date : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Cloneable, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_parse2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_after3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_before4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getDate5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getHours6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getMinutes7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getMonth8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getSeconds9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTime10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getYear11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setTime12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getDay13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_UTC14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTimezoneOffset15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setDate16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setHours17;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setMinutes18;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setMonth19;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setSeconds20;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setYear21;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toGMTString22;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toLocaleString23;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDate24;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDate25;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDate26;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDate27;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDate28;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorDate29;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IIIIII)V")]
        public Date(int par0, int par1, int par2, int par3, int par4, int par5) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 22)){
            @__env.NewObject(global::java.util.Date.staticClass, global::java.util.Date.j4n__ctorDate24, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Date(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Date.staticClass, global::java.util.Date.j4n__ctorDate25, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IIIII)V")]
        public Date(int par0, int par1, int par2, int par3, int par4) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 20)){
            @__env.NewObject(global::java.util.Date.staticClass, global::java.util.Date.j4n__ctorDate26, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(III)V")]
        public Date(int par0, int par1, int par2) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.NewObject(global::java.util.Date.staticClass, global::java.util.Date.j4n__ctorDate27, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public Date(long par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Date.staticClass, global::java.util.Date.j4n__ctorDate28, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Date() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.util.Date.staticClass, global::java.util.Date.j4n__ctorDate29, this);
            }
        }
        
        protected Date(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.Date.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.Date.staticClass = @__class;
            global::java.util.Date.j4n_compareTo0 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.util.Date.j4n_compareTo1 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I");
            global::java.util.Date.j4n_parse2 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
            global::java.util.Date.j4n_after3 = @__env.GetMethodID(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z");
            global::java.util.Date.j4n_before4 = @__env.GetMethodID(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z");
            global::java.util.Date.j4n_getDate5 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDate", "()I");
            global::java.util.Date.j4n_getHours6 = @__env.GetMethodID(global::java.util.Date.staticClass, "getHours", "()I");
            global::java.util.Date.j4n_getMinutes7 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMinutes", "()I");
            global::java.util.Date.j4n_getMonth8 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMonth", "()I");
            global::java.util.Date.j4n_getSeconds9 = @__env.GetMethodID(global::java.util.Date.staticClass, "getSeconds", "()I");
            global::java.util.Date.j4n_getTime10 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTime", "()J");
            global::java.util.Date.j4n_getYear11 = @__env.GetMethodID(global::java.util.Date.staticClass, "getYear", "()I");
            global::java.util.Date.j4n_setTime12 = @__env.GetMethodID(global::java.util.Date.staticClass, "setTime", "(J)V");
            global::java.util.Date.j4n_getDay13 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDay", "()I");
            global::java.util.Date.j4n_UTC14 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
            global::java.util.Date.j4n_getTimezoneOffset15 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTimezoneOffset", "()I");
            global::java.util.Date.j4n_setDate16 = @__env.GetMethodID(global::java.util.Date.staticClass, "setDate", "(I)V");
            global::java.util.Date.j4n_setHours17 = @__env.GetMethodID(global::java.util.Date.staticClass, "setHours", "(I)V");
            global::java.util.Date.j4n_setMinutes18 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMinutes", "(I)V");
            global::java.util.Date.j4n_setMonth19 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMonth", "(I)V");
            global::java.util.Date.j4n_setSeconds20 = @__env.GetMethodID(global::java.util.Date.staticClass, "setSeconds", "(I)V");
            global::java.util.Date.j4n_setYear21 = @__env.GetMethodID(global::java.util.Date.staticClass, "setYear", "(I)V");
            global::java.util.Date.j4n_toGMTString22 = @__env.GetMethodID(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;");
            global::java.util.Date.j4n_toLocaleString23 = @__env.GetMethodID(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;");
            global::java.util.Date.j4n__ctorDate24 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
            global::java.util.Date.j4n__ctorDate25 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.util.Date.j4n__ctorDate26 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
            global::java.util.Date.j4n__ctorDate27 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(III)V");
            global::java.util.Date.j4n__ctorDate28 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(J)V");
            global::java.util.Date.j4n__ctorDate29 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Date;)I")]
        public virtual int compareTo(global::java.util.Date par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)J")]
        public static long parse(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((long)(@__env.CallStaticLongMethod(global::java.util.Date.staticClass, global::java.util.Date.j4n_parse2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Date;)Z")]
        public virtual bool after(global::java.util.Date par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Date.j4n_after3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Date;)Z")]
        public virtual bool before(global::java.util.Date par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Date.j4n_before4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getDate() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getDate5)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getHours() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getHours6)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getMinutes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getMinutes7)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getMonth() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getMonth8)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getSeconds() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getSeconds9)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getTime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::java.util.Date.j4n_getTime10)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getYear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getYear11)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void setTime(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setTime12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getDay() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getDay13)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IIIIII)J")]
        public static long UTC(int par0, int par1, int par2, int par3, int par4, int par5) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 22)){
            return ((long)(@__env.CallStaticLongMethod(global::java.util.Date.staticClass, global::java.util.Date.j4n_UTC14, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getTimezoneOffset() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::java.util.Date.j4n_getTimezoneOffset15)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setDate(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setDate16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setHours(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setHours17, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setMinutes(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setMinutes18, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setMonth(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setMonth19, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setSeconds(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setSeconds20, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setYear(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Date.j4n_setYear21, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toGMTString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Date.j4n_toGMTString22));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toLocaleString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Date.j4n_toLocaleString23));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.Date(@__env);
            }
        }
    }
    #endregion
}
