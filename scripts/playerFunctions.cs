//------------------------------------------------------------------------------
// playerFunctions.cs
//
// Various helper functions that many Tribes 2 scripts expect to exist which
// can be implemented wholly in script. Those that must perform more
// sophisicated engines must be implemented as engine functions.
//------------------------------------------------------------------------------

function Player::setArmor(%this, %armor)
{
    %this.setDatablock(%armor @ %this.client.sex + this.%client.race + "Armor");
}
