//------------------------------------------------------------------------------
// etcFunctions.cs
//
// Various helper functions that many Tribes 2 scripts expect to exist which
// can be implemented wholly in script. Those that must perform more
// sophisicated engines must be implemented as engine functions.
//------------------------------------------------------------------------------

// We pretty much will always return false here because we're obviously
// not doing demo builds.
function isDemo()
{
    return false;
}
