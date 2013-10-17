singleton TSShapeConstructor(Mantis_Kraad_Crouch_SideDAE)
{
   baseShape = "./Mantis_Kraad_Crouch_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "740", "769", true, true);
}
