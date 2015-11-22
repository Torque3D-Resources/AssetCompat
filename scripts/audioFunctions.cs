//------------------------------------------------------------------------------
// playerFunctions.cs
//
// Various helper functions that many Tribes 2 scripts expect to exist which
// can be implemented wholly in script. Those that must perform more
// sophisicated engines must be implemented as engine functions.
//------------------------------------------------------------------------------

function alxCreateSource(%profile, %file)
{
    %handle = sfxCreateSource(%profile, %file);
}

function alxPlay(%handle)
{
    %handle.play(-1);
}

function alxGetWaveLen(%file)
{

}
