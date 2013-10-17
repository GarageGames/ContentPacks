singleton TSShapeConstructor(Mantis_Kraad_Death1DAE)
{
   baseShape = "./Mantis_Kraad_Death1.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1050", "1090", true, true);
}
