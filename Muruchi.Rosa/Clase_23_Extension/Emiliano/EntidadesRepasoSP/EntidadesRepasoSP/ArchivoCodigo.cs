public delegate void DelegadoSueldo(EntidadesRepasoSP.Empleado empleado, float sueldo);
public delegate void DelegadoSueldoMejorado(EntidadesRepasoSP.EmpleadoMejorado empleado,  float sueldo);
public delegate void DelegadoSueldoMejoradoArgs(EntidadesRepasoSP.EmpleadoSueldoArgs empleado, float sueldo);
public enum TipoManejador { LimiteSueldo, Log, Ambos}