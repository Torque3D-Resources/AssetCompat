exec ("materials.cs");
new SimSet(IIObjects) {
};
function serverCmdcollada() {
    for (%i=0; %i<IIObjects.getCount(); %i++) {
        changeToCollada(IIObjects.getObject(%i));
    }
    while(IIObjects.getCount() > 0) {
        IIObjects.getObject(0).delete();
    }
}
function InteriorInstance::onAdd(%this) {
    IIObjects.add(%this);
}
function changeToCollada(%ii) {
    %ii.exportToCollada(false);
    $ts = new TSStatic() {
        shapeName="compat/base/interiors/" @ getSubStr(%ii.getModelFile(),0,strpos(%ii.getModelFile(),".dif")) @ ".dae";
	    collisionType="Visible Mesh";
        decalType = "Visible Mesh";
        position=%ii.position;
        rotation=%ii.rotation;
        scale=%ii.scale;
    };
}