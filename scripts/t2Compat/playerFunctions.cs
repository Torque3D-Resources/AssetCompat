//------------------------------------------------------------------------------
// playerFunctions.cs
//
// Various helper functions that many Tribes 2 scripts expect to exist which
// can be implemented wholly in script. Those that must perform more
// sophisicated engines must be implemented as engine functions.
//------------------------------------------------------------------------------

package PlayerCompatability
{
    // The Tribes 2 engine behavior is to auto-fade the blown up player
    // upon calling this function.
    function Player::blowup(%this)
    {
        parent::blowup(%this);
        %this.startFade(1,0,1);
    }
};

activatePackage(PlayerCompatability);
