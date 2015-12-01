function InteriorInstance::onAdd(%this) {
    %this.exportToCollada(false);
    %ts = new TSStatic() {
        shapeName="compat/base/interiors/" @ getSubStr(%this.getModelFile(),0,strpos(%this.getModelFile(),".dif")) @ ".dae";
	    collisionType="Visible Mesh";
        decalType = "Visible Mesh";
        position=%this.position;
        rotation=%this.rotation;
        scale=%this.scale;
    };
    %this.delete();
}