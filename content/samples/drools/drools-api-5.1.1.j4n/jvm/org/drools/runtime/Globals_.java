// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.runtime;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Globals_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.runtime.Globals_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.runtime.Globals_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Globals extends system.Object implements org.drools.runtime.Globals {
    
    protected __Globals(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Ljava/lang/Object;")
    public native java.lang.Object get(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;Ljava/lang/Object;)V")
    public native void set(java.lang.String par0, java.lang.Object par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/Globals;)V")
    public native void setDelegate(org.drools.runtime.Globals par0);
}
//</generated-proxy>
