singleton TSShapeConstructor(Mantis_Kralmok_Crouch_RootDAE)
{
   baseShape = "./Mantis_Kralmok_Crouch_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "580", "639", true, true);
}
