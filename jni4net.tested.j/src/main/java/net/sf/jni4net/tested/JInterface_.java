// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.jni4net.tested;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class JInterface_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return net.sf.jni4net.tested.JInterface_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.jni4net.tested.JInterface_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __JInterface extends system.Object implements net.sf.jni4net.tested.JInterface {
    
    protected __JInterface(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void run();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void runForrestRun();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void cdefined();
}
//</generated-proxy>
