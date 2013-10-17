singleton TSShapeConstructor(Mantis_Kralmok_Crouch_SideDAE)
{
   baseShape = "./Mantis_Kralmok_Crouch_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "740", "769", true, true);
}
