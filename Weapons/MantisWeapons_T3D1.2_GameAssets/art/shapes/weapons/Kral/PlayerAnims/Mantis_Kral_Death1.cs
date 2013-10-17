singleton TSShapeConstructor(Mantis_Kral_Death1DAE)
{
   baseShape = "./Mantis_Kral_Death1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1050", "1090", true, true);
}
