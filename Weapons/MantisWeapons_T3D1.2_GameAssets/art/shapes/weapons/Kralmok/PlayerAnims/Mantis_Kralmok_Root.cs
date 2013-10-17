singleton TSShapeConstructor(Mantis_Kralmok_RootDAE)
{
   baseShape = "./Mantis_Kralmok_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "10", "99", true, true);
}
