//------------------------------------------------------------------------------
// t2Compat.cs
//
// Tribes 2 script compatability layer for Torque3D. This compatability
// layer helps Tribes 2 scripts run on the Torque3D engine via various
// Torque Script & engine declared functions that implement missing
// functionality.
//------------------------------------------------------------------------------
$fixInterior=1;
if ($fixInterior) {
    exec ("./interiorFunctions.cs");
}
exec("./etcFunctions.cs");
exec("./audioFunctions.cs");
exec("./playerFunctions.cs");
exec("./inputFunctions.cs");
