//------------------------------------------------------------------------------
// inputFunctions.cs
//
// Various helper functions that many Tribes 2 scripts expect to exist which
// can be implemented wholly in script. Those that must perform more
// sophisicated engines must be implemented as engine functions.
//------------------------------------------------------------------------------

// Apparently our Torque3D build already has this in it, how convenient.
function mouseJet(%jetting)
{
    $player::jumpJetTrigger = %jetting;
}
