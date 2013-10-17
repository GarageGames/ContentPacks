singleton TSShapeConstructor(Mantis_Kraad_RootDAE)
{
   baseShape = "./Mantis_Kraad_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "10", "99", true, true);
}
