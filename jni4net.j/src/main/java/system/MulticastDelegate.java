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
public class MulticastDelegate extends system.Delegate {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected MulticastDelegate(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected MulticastDelegate() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    public static system.Type typeof() {
        return system.MulticastDelegate.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.MulticastDelegate.staticType = staticType;
    }
    //</generated-proxy>
}
